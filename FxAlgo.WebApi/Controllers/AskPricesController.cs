using AutoMapper;
using FxAlgo.Repository;
using FxAlgo.WebApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace FxAlgo.WebApi.Controllers
{

    [Route("api/askprices")]
    public class AskPricesController : ApiController
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AskPricesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            using (var unit = _unitOfWork)
            {
                var price = unit.AskPrices.Get(id);
                return Ok(_mapper.Map<PriceModel>(price));
            }
        }

        //api/Price/Get
        [HttpGet]
        public IHttpActionResult Get()
        {
            using (var unit = _unitOfWork)
            {
                var price = unit.AskPrices.GetAll();
                return Ok(_mapper.Map<IEnumerable<PriceModel>>(price));
            }
        }
    }
}
