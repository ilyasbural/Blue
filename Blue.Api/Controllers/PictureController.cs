namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PictureController : ControllerBase
    {
        private readonly IPictureService Service;
        public PictureController(IPictureService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/picture")]
        public async Task<PictureWebResponse> Create([FromBody] PictureInsertDataTransfer Model)
        {
            PictureServiceResponse pictureServiceResponse = await Service.InsertAsync(Model);
            return new PictureWebResponse { Single = pictureServiceResponse.Single };
        }

        [HttpPut]
        [Route("api/picture")]
        public async Task<PictureWebResponse> Update([FromBody] PictureUpdateDataTransfer Model)
        {
            PictureServiceResponse pictureServiceResponse = await Service.UpdateAsync(Model);
            return new PictureWebResponse { Single = pictureServiceResponse.Single };
        }

        [HttpDelete]
        [Route("api/picture")]
        public async Task<PictureWebResponse> Delete([FromBody] PictureDeleteDataTransfer Model)
        {
            PictureServiceResponse pictureServiceResponse = await Service.DeleteAsync(Model);
            return new PictureWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/picture")]
        public async Task<PictureWebResponse> Get([FromBody] PictureSelectDataTransfer Model)
        {
            PictureServiceResponse pictureServiceResponse = await Service.SelectAsync(Model);
            return new PictureWebResponse { List = pictureServiceResponse.List };
        }

        [HttpGet]
        [Route("api/picture/{id}")]
        public async Task<PictureWebResponse> Get([FromBody] PictureAnyDataTransfer Model)
        {
            PictureServiceResponse pictureServiceResponse = await Service.AnySelectAsync(Model);
            return new PictureWebResponse { Single = pictureServiceResponse.Single };
        }
    }
}