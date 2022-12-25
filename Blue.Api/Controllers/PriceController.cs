namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PriceController : ControllerBase
    {
        readonly IPriceService Service;
        public PriceController(IPriceService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/price")]
        public async Task<Response<Price>> Create([FromBody] PriceInsertDataTransfer Model)
        {
            Response<Price> Response = await Service.InsertAsync(Model);
            return new Response<Price>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/price")]
        public async Task<Response<Price>> Update([FromBody] PriceUpdateDataTransfer Model)
        {
            Response<Price> Response = await Service.UpdateAsync(Model);
            return new Response<Price>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/price")]
        public async Task<Response<Price>> Delete([FromBody] PriceDeleteDataTransfer Model)
        {
            Response<Price> Response = await Service.DeleteAsync(Model);
            return new Response<Price>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/price")]
        public async Task<Response<Price>> Get([FromBody] PriceSelectDataTransfer Model)
        {
            Response<Price> Response = await Service.SelectAsync(Model);
            return new Response<Price>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/price/{id}")]
        public async Task<Response<Price>> Get([FromBody] PriceAnyDataTransfer Model)
        {
            Response<Price> Response = await Service.AnySelectAsync(Model);
            return new Response<Price>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}