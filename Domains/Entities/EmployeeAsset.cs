using ReviewEF.Shared.Sql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewEF.Domains.Entities
{
    public class EmployeeAsset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("ITAsset")]
        public long AssetId { get; set; }

        [ForeignKey("Employee")]
        public long EmployeeId { get; set; }

        public DateTime DateOut { get; set; }
        public DateTime? DateReturned { get; set; }
        public string ConditionOut { get; set; }
        public string ConditionReturned { get; set; }
        public string OtherDetails { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? CreateDate { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? ModifiedDate { get; set; }

        [SqlDefaultValue("false")]
        public bool? IsDeleted { get; set; }

        public Employee Employee { get; set; }
        public ITAsset ITAsset { get; set; }

    }
}
