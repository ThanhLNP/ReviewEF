using ReviewEF.Shared.Sql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewEF.Domains.Entities
{
    public class ITAssetInventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("ITAsset")]
        public long AssetId { get; set; }

        public DateTime InventoryDate { get; set; }

        [SqlDefaultValue("0")]
        [Range(0, Double.PositiveInfinity)]
        public int NumberAssigned { get; set; }

        [SqlDefaultValue("0")]
        [Range(0, Double.PositiveInfinity)]
        public int NumberInStock { get; set; }

        public string OtherDetails { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? CreateDate { get; set; }

        [SqlDefaultValue("now()")]
        public DateTime? ModifiedDate { get; set; }

        [SqlDefaultValue("false")]
        public bool? IsDeleted { get; set; }

        public ITAsset ITAsset { get; set; }
    }
}
