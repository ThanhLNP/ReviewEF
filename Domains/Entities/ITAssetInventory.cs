using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewEF.Domains.Entities
{
    public class ITAssetInventory : BaseEntity
    {
        [ForeignKey("ITAssets")]
        public long AssetId { get; set; }
        public DateTime InventoryDate { get; set; }
        public int NumberAssigned { get; set; }
        public int NumberInStock { get; set; }
        public string? OtherDetails { get; set; }

        public virtual ITAssets ITAssetsNavigation { get; set; }
    }
}
