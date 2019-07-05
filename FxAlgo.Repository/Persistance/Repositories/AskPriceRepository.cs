namespace FxAlgo.Repository.Persistance.Repositories
{
    public class AskPriceRepository : Repository<AskPrice>, IAskPriceRepository
    {
        public AskPriceRepository(FxAlgoContext context) : base(context)
        {
        }

        public FxAlgoContext FxAlgoContext
        {
            get { return Context as FxAlgoContext; }
        }

        //public AskPrice GetPrice(int id)
        //{
        //    return FxAlgoContext.AskPrices.Find(id);
        //}

        //public IEnumerable<AskPrice> GetPrices(int pageIndex, int pageSize)
        //{
        //    return FxAlgoContext.AskPrices.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        //}

        //public void AddPrice(AskPrice askPrice)
        //{
        //    FxAlgoContext.AskPrices.Add(askPrice);
        //}

        //public void AddPrices(IEnumerable<AskPrice> askPrices)
        //{
        //    FxAlgoContext.AskPrices.AddRange(askPrices);
        //}
    }
}
