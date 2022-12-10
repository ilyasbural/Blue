namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class WarmingController : ControllerBase
    {
        private readonly IWarmingService Service;
        public WarmingController(IWarmingService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/warming")]
        public async Task<WarmingWebResponse> Create([FromBody] WarmingInsertDataTransfer Model)
        {
            WarmingServiceResponse warmingServiceResponse = await Service.InsertAsync(Model);
            return new WarmingWebResponse { Warming = warmingServiceResponse.Warming };
        }

        [HttpPut]
        [Route("api/warming")]
        public async Task<WarmingWebResponse> Update([FromBody] WarmingUpdateDataTransfer Model)
        {
            WarmingServiceResponse warmingServiceResponse = await Service.UpdateAsync(Model);
            return new WarmingWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/warming")]
        public async Task<WarmingWebResponse> Delete([FromBody] WarmingDeleteDataTransfer Model)
        {
            WarmingServiceResponse warmingServiceResponse = await Service.DeleteAsync(Model);
            return new WarmingWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/warming")]
        public async Task<WarmingWebResponse> Get([FromBody] WarmingSelectDataTransfer Model)
        {
            WarmingServiceResponse warmingServiceResponse = await Service.SelectAsync(Model);
            return new WarmingWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/warming/{id}")]
        public async Task<WarmingWebResponse> Get([FromBody] WarmingAnyDataTransfer Model)
        {
            WarmingServiceResponse warmingServiceResponse = await Service.AnySelectAsync(Model);
            return new WarmingWebResponse
            {


            };
        }
    }
}