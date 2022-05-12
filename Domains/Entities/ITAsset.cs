using ReviewEF.Shared.Sql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewEF.Domains.Entities
{
    public class ITAsset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("AssetType")]
        public string AssetTypeCode { get; set; }

        public string Description { get; set; }
        public string OtherDetais { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? CreateDate { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? ModifiedDate { get; set; }

        [SqlDefaultValue("false")]
        public bool? IsDeleted { get; set; }

        public AssetType AssetType { get; set; }

        public ICollection<ITAssetInventory> ITAssetInventories { get; set; }
        public ICollection<EmployeeAsset> EmployeeAssets { get; set; }
    }
}
