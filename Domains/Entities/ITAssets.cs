using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewEF.Domains.Entities
{
    public class ITAssets : BaseEntity
    {
        [ForeignKey("AssetTypes")]
        public string AssetTypeCode { get; set; }
        public string Description { get; set; }
        public string? OtherDetais { get; set; }

        public virtual AssetTypes AssetTypesNavigation { get; set; }

        public ICollection<ITAssetInventory> ITAssetInventory { get; set; }
        public ICollection<EmployeeAssets> EmployeeAssets { get; set; }
    }
}
