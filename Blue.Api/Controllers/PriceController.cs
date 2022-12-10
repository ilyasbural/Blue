namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IPriceService Service;
        public PriceController(IPriceService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/price")]
        public async Task<PriceWebResponse> Create([FromBody] PriceInsertDataTransfer Model)
        {
            PriceServiceResponse priceServiceResponse = await Service.InsertAsync(Model);
            return new PriceWebResponse { Price = priceServiceResponse.Price };
        }

        [HttpPut]
        [Route("api/price")]
        public async Task<PriceWebResponse> Update([FromBody] PriceUpdateDataTransfer Model)
        {
            PriceServiceResponse priceServiceResponse = await Service.UpdateAsync(Model);
            return new PriceWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/price")]
        public async Task<PriceWebResponse> Delete([FromBody] PriceDeleteDataTransfer Model)
        {
            PriceServiceResponse priceServiceResponse = await Service.DeleteAsync(Model);
            return new PriceWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/price")]
        public async Task<PriceWebResponse> Get([FromBody] PriceSelectDataTransfer Model)
        {
            PriceServiceResponse priceServiceResponse = await Service.SelectAsync(Model);
            return new PriceWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/price/{id}")]
        public async Task<PriceWebResponse> Get([FromBody] PriceAnyDataTransfer Model)
        {
            PriceServiceResponse priceServiceResponse = await Service.AnySelectAsync(Model);
            return new PriceWebResponse
            {


            };
        }
    }
}