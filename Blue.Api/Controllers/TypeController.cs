namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class TypeController : ControllerBase
    {
        readonly ITypeService Service;
        public TypeController(ITypeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/type")]
        public async Task<Response<Type>> Create([FromBody] TypeInsertDataTransfer Model)
        {
            Response<Type> Response = await Service.InsertAsync(Model);
            return new Response<Type>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/type")]
        public async Task<Response<Type>> Update([FromBody] TypeUpdateDataTransfer Model)
        {
            Response<Type> Response = await Service.UpdateAsync(Model);
            return new Response<Type>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/type")]
        public async Task<Response<Type>> Delete([FromBody] TypeDeleteDataTransfer Model)
        {
            Response<Type> Response = await Service.DeleteAsync(Model);
            return new Response<Type>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/type")]
        public async Task<Response<Type>> Get([FromBody] TypeSelectDataTransfer Model)
        {
            Response<Type> Response = await Service.SelectAsync(Model);
            return new Response<Type>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/type/{id}")]
        public async Task<Response<Type>> Get([FromBody] TypeAnyDataTransfer Model)
        {
            Response<Type> Response = await Service.AnySelectAsync(Model);
            return new Response<Type>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}