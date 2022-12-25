namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class FurnitureController : ControllerBase
    {
        readonly IFurnitureService Service;
        public FurnitureController(IFurnitureService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/furniture")]
        public async Task<Response<Furniture>> Create([FromBody] FurnitureInsertDataTransfer Model)
        {
            Response<Furniture> Response = await Service.InsertAsync(Model);
            return new Response<Furniture>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/furniture")]
        public async Task<Response<Furniture>> Update([FromBody] FurnitureUpdateDataTransfer Model)
        {
            Response<Furniture> Response = await Service.UpdateAsync(Model);
            return new Response<Furniture>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/furniture")]
        public async Task<Response<Furniture>> Delete([FromBody] FurnitureDeleteDataTransfer Model)
        {
            Response<Furniture> Response = await Service.DeleteAsync(Model);
            return new Response<Furniture>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/furniture")]
        public async Task<Response<Furniture>> Get([FromBody] FurnitureSelectDataTransfer Model)
        {
            Response<Furniture> Response = await Service.SelectAsync(Model);
            return new Response<Furniture>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/furniture/{id}")]
        public async Task<Response<Furniture>> Get([FromBody] FurnitureAnyDataTransfer Model)
        {
            Response<Furniture> Response = await Service.AnySelectAsync(Model);
            return new Response<Furniture>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}