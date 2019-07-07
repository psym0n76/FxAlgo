using AutoMapper;
using FxAlgo.Repository;

namespace FxAlgo.WebApi.Models
{
    public class PriceMappingProfile : Profile
    {
        public PriceMappingProfile()
        {
            CreateMap<AskPrice, PriceModel>();
            CreateMap<BidPrice, PriceModel>();
        }
    }
}