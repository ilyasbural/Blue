namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class WarmingController : ControllerBase
    {
        readonly IWarmingService Service;
        public WarmingController(IWarmingService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/warming")]
        public async Task<Response<Warming>> Create([FromBody] WarmingInsertDataTransfer Model)
        {
            Response<Warming> Response = await Service.InsertAsync(Model);
            return new Response<Warming>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/warming")]
        public async Task<Response<Warming>> Update([FromBody] WarmingUpdateDataTransfer Model)
        {
            Response<Warming> Response = await Service.UpdateAsync(Model);
            return new Response<Warming>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/warming")]
        public async Task<Response<Warming>> Delete([FromBody] WarmingDeleteDataTransfer Model)
        {
            Response<Warming> Response = await Service.DeleteAsync(Model);
            return new Response<Warming>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/warming")]
        public async Task<Response<Warming>> Get([FromBody] WarmingSelectDataTransfer Model)
        {
            Response<Warming> Response = await Service.SelectAsync(Model);
            return new Response<Warming>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/warming/{id}")]
        public async Task<Response<Warming>> Get([FromBody] WarmingAnyDataTransfer Model)
        {
            Response<Warming> Response = await Service.AnySelectAsync(Model);
            return new Response<Warming>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}