namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class RealEstateController : ControllerBase
    {
        readonly IRealEstateService Service;
        public RealEstateController(IRealEstateService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/realestate")]
        public async Task<Response<RealEstate>> Create([FromBody] RealEstateInsertDataTransfer Model)
        {
            Response<RealEstate> Response = await Service.InsertAsync(Model);
            return new Response<RealEstate>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/realestate")]
        public async Task<Response<RealEstate>> Update([FromBody] RealEstateUpdateDataTransfer Model)
        {
            Response<RealEstate> Response = await Service.UpdateAsync(Model);
            return new Response<RealEstate>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/realestate")]
        public async Task<Response<RealEstate>> Delete([FromBody] RealEstateDeleteDataTransfer Model)
        {
            Response<RealEstate> Response = await Service.DeleteAsync(Model);
            return new Response<RealEstate>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/realestate")]
        public async Task<Response<RealEstate>> Get([FromBody] RealEstateSelectDataTransfer Model)
        {
            Response<RealEstate> Response = await Service.SelectAsync(Model);
            return new Response<RealEstate>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/realestate/{id}")]
        public async Task<Response<RealEstate>> Get([FromBody] RealEstateAnyDataTransfer Model)
        {
            Response<RealEstate> Response = await Service.AnySelectAsync(Model);
            return new Response<RealEstate>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}