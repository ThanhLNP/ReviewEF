namespace ReviewEF.Domains.Entities
{
    public class Employees : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string? OtherDetails { get; set; }

        public ICollection<EmployeeAssets> EmployeeAssetsNavigation { get; set; }
    }
}
