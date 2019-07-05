using System.Data.Entity;

namespace FxAlgo.Repository.Persistance
{
    public class FxAlgoContext : DbContext
    {
        public FxAlgoContext() : base(nameOrConnectionString: "name=FxAlgoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<AskPrice> AskPrices { get; set; }
        public virtual DbSet<BidPrice> BidPrices { get; set; }

    }
}
