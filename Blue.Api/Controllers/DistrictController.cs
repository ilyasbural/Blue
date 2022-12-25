namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class DistrictController : ControllerBase
    {
        readonly IDistrictService Service;
        public DistrictController(IDistrictService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/district")]
        public async Task<Response<District>> Create([FromBody] DistrictInsertDataTransfer Model)
        {
            Response<District> Response = await Service.InsertAsync(Model);
            return new Response<District>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/district")]
        public async Task<Response<District>> Update([FromBody] DistrictUpdateDataTransfer Model)
        {
            Response<District> Response = await Service.UpdateAsync(Model);
            return new Response<District>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/district")]
        public async Task<Response<District>> Delete([FromBody] DistrictDeleteDataTransfer Model)
        {
            Response<District> Response = await Service.DeleteAsync(Model);
            return new Response<District>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/district")]
        public async Task<Response<District>> Get([FromBody] DistrictSelectDataTransfer Model)
        {
            Response<District> Response = await Service.SelectAsync(Model);
            return new Response<District>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/district/{id}")]
        public async Task<Response<District>> Get([FromBody] DistrictAnyDataTransfer Model)
        {
            Response<District> Response = await Service.AnySelectAsync(Model);
            return new Response<District>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}