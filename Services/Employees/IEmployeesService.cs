
using ReviewEF.Domains.Entities;
using System.Text.Json.Serialization;

namespace ReviewEF.Services.Employees
{
    public interface IEmployeesService
    {
        public Task<List<GetAllEmployeesResponse>> GetAll(GetAllEmployeesQuery query);
        public Task<GetDetailEmployeesResponse> GetDetail(long id);
        public Task<int> Post(PostEmployeesBody body);
        public void Put(string Id, string body);
        public void Delete(long id);
    }

    #region GetAll
    public class GetAllEmployeesQuery
    {
        public int limit { get; set; } = 10;
        public int offset { get; set; } = 0;
        public ESearchField? searchField { get; set; }
        public string searchValue { get; set; } = "";
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ESearchField
    {
        FirstName,
        LastName,
        Department,
        Extension,
        Email
    }

    public class GetAllEmployeesResponse
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
    }
    #endregion

    #region GetDetail
    public class GetDetailEmployeesResponse
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string OtherDetails { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
    #endregion

    #region Post
    public class PostEmployeesBody
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string OtherDetails { get; set; }
    }
    #endregion

    #region Put
    public class PutEmployeesBody
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string OtherDetails { get; set; }
    }
    #endregion
}
