using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewEF.Domains.Entities
{
    public class EmployeeAssets : BaseEntity
    {
        [ForeignKey("ITAssets")]
        public long AssetId { get; set; }

        [ForeignKey("Employees")]
        public long EmployeeId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateReturned { get; set; }
        public string ConditionOut { get; set; }
        public string? ConditionReturned { get; set; }
        public string? OtherDetails { get; set; }

        public virtual Employees Employees { get; set; }
        public virtual ITAssets ITAssets { get; set; }

    }
}
