using System;

namespace FxAlgo.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        //list each tables interface
        IAskPriceRepository AskPrices { get; }
        IBidPriceRepository BidPrices { get; }

        int Complete();
    }

}
