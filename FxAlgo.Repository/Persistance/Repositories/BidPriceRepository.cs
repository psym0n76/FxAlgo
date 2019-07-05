namespace FxAlgo.Repository.Persistance.Repositories
{
    public class BidPriceRepository : Repository<BidPrice>, IBidPriceRepository
    {
        public BidPriceRepository(FxAlgoContext context) : base(context)
        {
        }

        public FxAlgoContext FxAlgoContext
        {
            get { return Context as FxAlgoContext; }
        }

        //public BidPrice GetPrice(int id)
        //{
        //    return FxAlgoContext.BidPrices.Find(id);
        //}

        //public IEnumerable<BidPrice> GetPrices(int pageIndex, int pageSize)
        //{
        //    return FxAlgoContext.BidPrices.Skip((pageIndex - 1) * pageIndex).Take(pageSize).ToList();
        //}

        //public void AddPrice(BidPrice bidPrice)
        //{
        //    FxAlgoContext.BidPrices.Add(bidPrice);
        //}

        //public void AddPrices(IEnumerable<BidPrice> bidPrices)
        //{
        //    FxAlgoContext.BidPrices.AddRange(bidPrices);
        //}
    }
}
