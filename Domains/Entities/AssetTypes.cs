using System.ComponentModel.DataAnnotations;

namespace ReviewEF.Domains.Entities
{
    public class AssetTypes
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ITAssets> ITAssets { get; set; }
    }
}
