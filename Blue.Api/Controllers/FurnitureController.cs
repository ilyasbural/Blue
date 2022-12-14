namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class FurnitureController : ControllerBase
    {
        private readonly IFurnitureService Service;
        public FurnitureController(IFurnitureService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/furniture")]
        public async Task<FurnitureWebResponse> Create([FromBody] FurnitureInsertDataTransfer Model)
        {
            FurnitureServiceResponse furnitureServiceResponse = await Service.InsertAsync(Model);
            return new FurnitureWebResponse { Single = furnitureServiceResponse.Single };
        }

        [HttpPut]
        [Route("api/furniture")]
        public async Task<FurnitureWebResponse> Update([FromBody] FurnitureUpdateDataTransfer Model)
        {
            FurnitureServiceResponse furnitureServiceResponse = await Service.UpdateAsync(Model);
            return new FurnitureWebResponse { Single = furnitureServiceResponse.Single };
        }

        [HttpDelete]
        [Route("api/furniture")]
        public async Task<FurnitureWebResponse> Delete([FromBody] FurnitureDeleteDataTransfer Model)
        {
            FurnitureServiceResponse furnitureServiceResponse = await Service.DeleteAsync(Model);
            return new FurnitureWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/furniture")]
        public async Task<FurnitureWebResponse> Get([FromBody] FurnitureSelectDataTransfer Model)
        {
            FurnitureServiceResponse furnitureServiceResponse = await Service.SelectAsync(Model);
            return new FurnitureWebResponse { List = furnitureServiceResponse.List };
        }

        [HttpGet]
        [Route("api/furniture/{id}")]
        public async Task<FurnitureWebResponse> Get([FromBody] FurnitureAnyDataTransfer Model)
        {
            FurnitureServiceResponse furnitureServiceResponse = await Service.AnySelectAsync(Model);
            return new FurnitureWebResponse { Single = furnitureServiceResponse.Single };
        }
    }
}