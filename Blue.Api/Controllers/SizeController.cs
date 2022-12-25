namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class SizeController : ControllerBase
    {
        readonly ISizeService Service;
        public SizeController(ISizeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/size")]
        public async Task<Response<Size>> Create([FromBody] SizeInsertDataTransfer Model)
        {
            Response<Size> Response = await Service.InsertAsync(Model);
            return new Response<Size>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/size")]
        public async Task<Response<Size>> Update([FromBody] SizeUpdateDataTransfer Model)
        {
            Response<Size> Response = await Service.UpdateAsync(Model);
            return new Response<Size>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/size")]
        public async Task<Response<Size>> Delete([FromBody] SizeDeleteDataTransfer Model)
        {
            Response<Size> Response = await Service.DeleteAsync(Model);
            return new Response<Size>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/size")]
        public async Task<Response<Size>> Get([FromBody] SizeSelectDataTransfer Model)
        {
            Response<Size> Response = await Service.SelectAsync(Model);
            return new Response<Size>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/size/{id}")]
        public async Task<Response<Size>> Get([FromBody] SizeAnyDataTransfer Model)
        {
            Response<Size> Response = await Service.AnySelectAsync(Model);
            return new Response<Size>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}