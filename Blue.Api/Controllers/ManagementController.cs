namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementController : ControllerBase
    {
        private readonly IManagementService Service;
        public ManagementController(IManagementService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Create([FromBody] ManagementInsertDataTransfer Model)
        {
            ManagementServiceResponse managementServiceResponse = await Service.InsertAsync(Model);
            return new ManagementWebResponse { Management = managementServiceResponse.Management };
        }

        [HttpPut]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Update([FromBody] ManagementUpdateDataTransfer Model)
        {
            ManagementServiceResponse managementServiceResponse = await Service.UpdateAsync(Model);
            return new ManagementWebResponse
            {


            };
        }

        [HttpDelete]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Delete([FromBody] ManagementDeleteDataTransfer Model)
        {
            ManagementServiceResponse managementServiceResponse = await Service.DeleteAsync(Model);
            return new ManagementWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/management")]
        public async Task<ManagementWebResponse> Get([FromBody] ManagementSelectDataTransfer Model)
        {
            ManagementServiceResponse managementServiceResponse = await Service.SelectAsync(Model);
            return new ManagementWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/management/{id}")]
        public async Task<ManagementWebResponse> Get([FromBody] ManagementAnyDataTransfer Model)
        {
            ManagementServiceResponse managementServiceResponse = await Service.AnySelectAsync(Model);
            return new ManagementWebResponse
            {


            };
        }
    }
}