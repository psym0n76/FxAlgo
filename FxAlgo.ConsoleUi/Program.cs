using FxAlgo.Repository.Persistance;

namespace FxAlgo.ConsoleUi
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new FxAlgoContext()))
            {
                var price = unitOfWork.AskPrices.Get(1);

                var prices = unitOfWork.AskPrices.GetAll();

                unitOfWork.AskPrices.Remove(price);
                unitOfWork.AskPrices.RemoveRange(prices);

                unitOfWork.Complete();
            }
        }
    }
}
