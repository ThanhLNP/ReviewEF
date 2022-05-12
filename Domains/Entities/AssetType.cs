using ReviewEF.Shared.Sql;
using System.ComponentModel.DataAnnotations;

namespace ReviewEF.Domains.Entities
{
    public class AssetType
    {
        [Key]
        [MaxLength(12)]
        public string Code { get; set; }

        public string Description { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? CreateDate { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? ModifiedDate { get; set; }

        [SqlDefaultValue("false")]
        public bool? IsDeleted { get; set; }

        public ICollection<ITAsset> ITAssets { get; set; }
    }
}
