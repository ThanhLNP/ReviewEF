using Microsoft.EntityFrameworkCore;
using ReviewEF.Domains;
using ReviewEF.Domains.Entities;

namespace ReviewEF.Services.Employees
{
    public class EmployeesService : IEmployeesService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<EmployeesService> _logger;

        public EmployeesService(ILogger<EmployeesService> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<GetAllEmployeesResponse>> GetAll(GetAllEmployeesQuery query)
        {
            var queryDb = _context.Employees.AsNoTracking();
            queryDb = queryDb.Where(c => c.IsDeleted == false);
            queryDb = queryDb.OrderBy(c => c.FirstName);

            if (!string.IsNullOrEmpty(query.searchField.ToString()))
            {
                queryDb = queryDb.Where(c => c[query.searchField.ToString()].Contains(query.searchValue));
            }
            queryDb = queryDb.Skip(query.limit * query.offset).Take(query.limit);
            var response = await queryDb.ToListAsync();


            return response.Select(r => new GetAllEmployeesResponse
            {
                Id = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                Department = r.Department,
                Extension = r.Extension,
                Email = r.Email
            }).ToList();
        }

        public async Task<GetDetailEmployeesResponse> GetDetail(long id)
        {
            var queryDb = _context.Employees.AsNoTracking().Where(c => c.Id == id);
            var response = await queryDb.FirstOrDefaultAsync();

            if (response is null)
            {
                throw new Exception("404 Not Found");
            }

            return new GetDetailEmployeesResponse
            {
                Id = response.Id,
                FirstName = response.FirstName,
                LastName = response.LastName,
                Department = response.Department,
                Extension = response.Extension,
                Email = response.Email,
                OtherDetails = response.OtherDetails,
                CreateDate = response.CreateDate,
                ModifiedDate = response.ModifiedDate,
            };
        }
        public async Task<int> Post(PostEmployeesBody body)
        {
            Employee employee = new Employee
            {
                FirstName = body.FirstName,
                LastName = body.LastName,
                Department = body.Department,
                Extension = body.Extension,
                Email = body.Email,
                OtherDetails = body.OtherDetails
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return 1;

        }
        public async void Put(string Id, string body)
        {

        }
        public async void Delete(long id)
        {

        }

    }
}
