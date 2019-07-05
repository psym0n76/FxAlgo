using FxAlgo.Repository.Persistance.Repositories;

namespace FxAlgo.Repository.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly FxAlgoContext _context;

        public UnitOfWork(FxAlgoContext context)
        {
            _context = context;
            BidPrices = new BidPriceRepository(_context);
            AskPrices = new AskPriceRepository(_context);
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public IAskPriceRepository AskPrices { get; }
        public IBidPriceRepository BidPrices { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
