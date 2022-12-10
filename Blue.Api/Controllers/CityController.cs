namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService Service;
        public CityController(ICityService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/city")]
        public async Task<CityWebResponse> Create([FromBody] CityInsertDataTransfer Model)
        {
            CityServiceResponse announceResponse = await Service.InsertAsync(Model);
            return new CityWebResponse { City = announceResponse.City };
        }

        [HttpPut]
        [Route("api/city")]
        public async Task<CityWebResponse> Update([FromBody] CityUpdateDataTransfer Model)
        {
            CityServiceResponse announceResponse = await Service.UpdateAsync(Model);
            return new CityWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/city")]
        public async Task<CityWebResponse> Delete([FromBody] CityDeleteDataTransfer Model)
        {
            CityServiceResponse announceResponse = await Service.DeleteAsync(Model);
            return new CityWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/city")]
        public async Task<CityWebResponse> Get([FromBody] CitySelectDataTransfer Model)
        {
            CityServiceResponse announceResponse = await Service.SelectAsync(Model);
            return new CityWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/city/{id}")]
        public async Task<CityWebResponse> Get([FromBody] CityAnyDataTransfer Model)
        {
            CityServiceResponse announceResponse = await Service.AnySelectAsync(Model);
            return new CityWebResponse
            {


            };
        }
    }
}