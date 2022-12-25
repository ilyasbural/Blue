namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CityController : ControllerBase
    {
        readonly ICityService Service;
        public CityController(ICityService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/city")]
        public async Task<Response<City>> Create([FromBody] CityInsertDataTransfer Model)
        {
            Response<City> Response = await Service.InsertAsync(Model);
            return new Response<City>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/city")]
        public async Task<Response<City>> Update([FromBody] CityUpdateDataTransfer Model)
        {
            Response<City> Response = await Service.UpdateAsync(Model);
            return new Response<City>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/city")]
        public async Task<Response<City>> Delete([FromBody] CityDeleteDataTransfer Model)
        {
            Response<City> Response = await Service.DeleteAsync(Model);
            return new Response<City>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/city")]
        public async Task<Response<City>> Get([FromBody] CitySelectDataTransfer Model)
        {
            Response<City> Response = await Service.SelectAsync(Model);
            return new Response<City>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/city/{id}")]
        public async Task<Response<City>> Get([FromBody] CityAnyDataTransfer Model)
        {
            Response<City> Response = await Service.AnySelectAsync(Model);
            return new Response<City>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}