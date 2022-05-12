using Microsoft.EntityFrameworkCore;
using ReviewEF.Domains.Entities;
using ReviewEF.Shared.Sql;

namespace ReviewEF.Domains
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<ITAsset> ITAssets { get; set; }
        public virtual DbSet<ITAssetInventory> ITAssetInventories { get; set; }
        public virtual DbSet<EmployeeAsset> EmployeeAssets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseSerialColumns();
            base.OnModelCreating(builder);

            // Add customizations after calling base.OnModelCreating(builder);
            // https://stackoverflow.com/questions/32049742/ef-7-set-initial-default-value-for-datetime-column
            CustomDataTypeAttributeConvention.Apply(builder);
            DecimalPrecisionAttributeConvention.Apply(builder);
            SqlDefaultValueAttributeConvention.Apply(builder);
        }
    }
}
