namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService Service;
        public DistrictController(IDistrictService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/district")]
        public async Task<DistrictWebResponse> Create([FromBody] DistrictInsertDataTransfer Model)
        {
            DistrictServiceResponse districtServiceResponse = await Service.InsertAsync(Model);
            return new DistrictWebResponse { District = districtServiceResponse.District };
        }

        [HttpPut]
        [Route("api/district")]
        public async Task<DistrictWebResponse> Update([FromBody] DistrictUpdateDataTransfer Model)
        {
            DistrictServiceResponse districtServiceResponse = await Service.UpdateAsync(Model);
            return new DistrictWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/district")]
        public async Task<DistrictWebResponse> Delete([FromBody] DistrictDeleteDataTransfer Model)
        {
            DistrictServiceResponse districtServiceResponse = await Service.DeleteAsync(Model);
            return new DistrictWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/district")]
        public async Task<DistrictWebResponse> Get([FromBody] DistrictSelectDataTransfer Model)
        {
            DistrictServiceResponse districtServiceResponse = await Service.SelectAsync(Model);
            return new DistrictWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/district/{id}")]
        public async Task<DistrictWebResponse> Get([FromBody] DistrictAnyDataTransfer Model)
        {
            DistrictServiceResponse districtServiceResponse = await Service.AnySelectAsync(Model);
            return new DistrictWebResponse
            {


            };
        }
    }
}