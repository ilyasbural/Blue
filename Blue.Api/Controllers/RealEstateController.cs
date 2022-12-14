namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class RealEstateController : ControllerBase
    {
        private readonly IRealEstateService Service;
        public RealEstateController(IRealEstateService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/realestate")]
        public async Task<RealEstateWebResponse> Create([FromBody] RealEstateInsertDataTransfer Model)
        {
            RealEstateServiceResponse realEstateServiceResponse = await Service.InsertAsync(Model);
            return new RealEstateWebResponse { Single = realEstateServiceResponse.Single };
        }

        [HttpPut]
        [Route("api/realestate")]
        public async Task<RealEstateWebResponse> Update([FromBody] RealEstateUpdateDataTransfer Model)
        {
            RealEstateServiceResponse realEstateServiceResponse = await Service.UpdateAsync(Model);
            return new RealEstateWebResponse { Single = realEstateServiceResponse.Single };
        }

        [HttpDelete]
        [Route("api/realestate")]
        public async Task<RealEstateWebResponse> Delete([FromBody] RealEstateDeleteDataTransfer Model)
        {
            RealEstateServiceResponse realEstateServiceResponse = await Service.DeleteAsync(Model);
            return new RealEstateWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/realestate")]
        public async Task<RealEstateWebResponse> Get([FromBody] RealEstateSelectDataTransfer Model)
        {
            RealEstateServiceResponse realEstateServiceResponse = await Service.SelectAsync(Model);
            return new RealEstateWebResponse { List = realEstateServiceResponse.List };
        }

        [HttpGet]
        [Route("api/realestate/{id}")]
        public async Task<RealEstateWebResponse> Get([FromBody] RealEstateAnyDataTransfer Model)
        {
            RealEstateServiceResponse realEstateServiceResponse = await Service.AnySelectAsync(Model);
            return new RealEstateWebResponse { Single = realEstateServiceResponse.Single };
        }
    }
}