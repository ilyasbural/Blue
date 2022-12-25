namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PictureController : ControllerBase
    {
        readonly IPictureService Service;
        public PictureController(IPictureService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/picture")]
        public async Task<Response<Picture>> Create([FromBody] PictureInsertDataTransfer Model)
        {
            Response<Picture> Response = await Service.InsertAsync(Model);
            return new Response<Picture>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/picture")]
        public async Task<Response<Picture>> Update([FromBody] PictureUpdateDataTransfer Model)
        {
            Response<Picture> Response = await Service.UpdateAsync(Model);
            return new Response<Picture>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/picture")]
        public async Task<Response<Picture>> Delete([FromBody] PictureDeleteDataTransfer Model)
        {
            Response<Picture> Response = await Service.DeleteAsync(Model);
            return new Response<Picture>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/picture")]
        public async Task<Response<Picture>> Get([FromBody] PictureSelectDataTransfer Model)
        {
            Response<Picture> Response = await Service.SelectAsync(Model);
            return new Response<Picture>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/picture/{id}")]
        public async Task<Response<Picture>> Get([FromBody] PictureAnyDataTransfer Model)
        {
            Response<Picture> Response = await Service.AnySelectAsync(Model);
            return new Response<Picture>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}