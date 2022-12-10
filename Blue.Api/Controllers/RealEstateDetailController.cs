namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class RealEstateDetailController : ControllerBase
    {
        private readonly IRealEstateDetailService Service;
        public RealEstateDetailController(IRealEstateDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/realestatedetail")]
        public async Task<RealEstateDetailWebResponse> Create([FromBody] RealEstateDetailInsertDataTransfer Model)
        {
            RealEstateDetailServiceResponse realEstateDetailServiceResponse = await Service.InsertAsync(Model);
            return new RealEstateDetailWebResponse { RealEstateDetail = realEstateDetailServiceResponse.RealEstateDetail };
        }

        [HttpPut]
        [Route("api/realestatedetail")]
        public async Task<RealEstateDetailWebResponse> Update([FromBody] RealEstateDetailUpdateDataTransfer Model)
        {
            RealEstateDetailServiceResponse realEstateDetailServiceResponse = await Service.UpdateAsync(Model);
            return new RealEstateDetailWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/realestatedetail")]
        public async Task<RealEstateDetailWebResponse> Delete([FromBody] RealEstateDetailDeleteDataTransfer Model)
        {
            RealEstateDetailServiceResponse realEstateDetailServiceResponse = await Service.DeleteAsync(Model);
            return new RealEstateDetailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/realestatedetail")]
        public async Task<RealEstateDetailWebResponse> Get([FromBody] RealEstateDetailSelectDataTransfer Model)
        {
            RealEstateDetailServiceResponse realEstateDetailServiceResponse = await Service.SelectAsync(Model);
            return new RealEstateDetailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/realestatedetail/{id}")]
        public async Task<RealEstateDetailWebResponse> Get([FromBody] RealEstateDetailAnyDataTransfer Model)
        {
            RealEstateDetailServiceResponse realEstateDetailServiceResponse = await Service.AnySelectAsync(Model);
            return new RealEstateDetailWebResponse
            {


            };
        }
    }
}