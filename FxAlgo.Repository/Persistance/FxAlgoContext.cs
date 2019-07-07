using System.Data.Entity;

namespace FxAlgo.Repository.Persistance
{
    public class FxAlgoContext : DbContext
    {
        public FxAlgoContext() : base(nameOrConnectionString: "name=FxAlgoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<AskPrice> AskPrices { get; set; }
        public virtual DbSet<BidPrice> BidPrices { get; set; }

    }
}
