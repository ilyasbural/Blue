namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class SizeController : ControllerBase
    {
        private readonly ISizeService Service;
        public SizeController(ISizeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/size")]
        public async Task<SizeWebResponse> Create([FromBody] SizeInsertDataTransfer Model)
        {
            SizeServiceResponse sizeServiceResponse = await Service.InsertAsync(Model);
            return new SizeWebResponse { Size = sizeServiceResponse.Size };
        }

        [HttpPut]
        [Route("api/size")]
        public async Task<SizeWebResponse> Update([FromBody] SizeUpdateDataTransfer Model)
        {
            SizeServiceResponse sizeServiceResponse = await Service.UpdateAsync(Model);
            return new SizeWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/size")]
        public async Task<SizeWebResponse> Delete([FromBody] SizeDeleteDataTransfer Model)
        {
            SizeServiceResponse sizeServiceResponse = await Service.DeleteAsync(Model);
            return new SizeWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/size")]
        public async Task<SizeWebResponse> Get([FromBody] SizeSelectDataTransfer Model)
        {
            SizeServiceResponse sizeServiceResponse = await Service.SelectAsync(Model);
            return new SizeWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/size/{id}")]
        public async Task<SizeWebResponse> Get([FromBody] SizeAnyDataTransfer Model)
        {
            SizeServiceResponse sizeServiceResponse = await Service.AnySelectAsync(Model);
            return new SizeWebResponse
            {


            };
        }
    }
}