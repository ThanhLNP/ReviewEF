using ReviewEF.Shared.Sql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewEF.Domains.Entities
{
    public class Employee
    {
        public string this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null).ToString(); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string OtherDetails { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? CreateDate { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? ModifiedDate { get; set; }

        [SqlDefaultValue("false")]
        public bool? IsDeleted { get; set; }

        public ICollection<EmployeeAsset> EmployeeAssets { get; set; }
    }
}
