namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly ITypeService Service;
        public TypeController(ITypeService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/type")]
        public async Task<TypeWebResponse> Create([FromBody] TypeInsertDataTransfer Model)
        {
            TypeServiceResponse typeServiceResponse = await Service.InsertAsync(Model);
            return new TypeWebResponse { Single = typeServiceResponse.Single };
        }

        [HttpPut]
        [Route("api/type")]
        public async Task<TypeWebResponse> Update([FromBody] TypeUpdateDataTransfer Model)
        {
            TypeServiceResponse typeServiceResponse = await Service.UpdateAsync(Model);
            return new TypeWebResponse { Single = typeServiceResponse.Single };
        }

        [HttpDelete]
        [Route("api/type")]
        public async Task<TypeWebResponse> Delete([FromBody] TypeDeleteDataTransfer Model)
        {
            TypeServiceResponse typeServiceResponse = await Service.DeleteAsync(Model);
            return new TypeWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/type")]
        public async Task<TypeWebResponse> Get([FromBody] TypeSelectDataTransfer Model)
        {
            TypeServiceResponse typeServiceResponse = await Service.SelectAsync(Model);
            return new TypeWebResponse { List = typeServiceResponse.List };
        }

        [HttpGet]
        [Route("api/type/{id}")]
        public async Task<TypeWebResponse> Get([FromBody] TypeAnyDataTransfer Model)
        {
            TypeServiceResponse typeServiceResponse = await Service.AnySelectAsync(Model);
            return new TypeWebResponse { Single = typeServiceResponse.Single };
        }
    }
}