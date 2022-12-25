namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementController : ControllerBase
    {
        readonly IManagementService Service;
        public ManagementController(IManagementService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/management")]
        public async Task<Response<Management>> Create([FromBody] ManagementInsertDataTransfer Model)
        {
            Response<Management> Response = await Service.InsertAsync(Model);
            return new Response<Management>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/management")]
        public async Task<Response<Management>> Update([FromBody] ManagementUpdateDataTransfer Model)
        {
            Response<Management> Response = await Service.UpdateAsync(Model);
            return new Response<Management>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/management")]
        public async Task<Response<Management>> Delete([FromBody] ManagementDeleteDataTransfer Model)
        {
            Response<Management> Response = await Service.DeleteAsync(Model);
            return new Response<Management>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/management")]
        public async Task<Response<Management>> Get([FromBody] ManagementSelectDataTransfer Model)
        {
            Response<Management> Response = await Service.SelectAsync(Model);
            return new Response<Management>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/management/{id}")]
        public async Task<Response<Management>> Get([FromBody] ManagementAnyDataTransfer Model)
        {
            Response<Management> Response = await Service.AnySelectAsync(Model);
            return new Response<Management>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}