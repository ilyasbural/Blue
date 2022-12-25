namespace Blue.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class RealEstateDetailController : ControllerBase
    {
        readonly IRealEstateDetailService Service;
        public RealEstateDetailController(IRealEstateDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/realestatedetail")]
        public async Task<Response<RealEstateDetail>> Create([FromBody] RealEstateDetailInsertDataTransfer Model)
        {
            Response<RealEstateDetail> Response = await Service.InsertAsync(Model);
            return new Response<RealEstateDetail>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/realestatedetail")]
        public async Task<Response<RealEstateDetail>> Update([FromBody] RealEstateDetailUpdateDataTransfer Model)
        {
            Response<RealEstateDetail> Response = await Service.UpdateAsync(Model);
            return new Response<RealEstateDetail>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/realestatedetail")]
        public async Task<Response<RealEstateDetail>> Delete([FromBody] RealEstateDetailDeleteDataTransfer Model)
        {
            Response<RealEstateDetail> Response = await Service.DeleteAsync(Model);
            return new Response<RealEstateDetail>
            {
                Message = Response.Message,
                Data = Response.Data,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/realestatedetail")]
        public async Task<Response<RealEstateDetail>> Get([FromBody] RealEstateDetailSelectDataTransfer Model)
        {
            Response<RealEstateDetail> Response = await Service.SelectAsync(Model);
            return new Response<RealEstateDetail>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/realestatedetail/{id}")]
        public async Task<Response<RealEstateDetail>> Get([FromBody] RealEstateDetailAnyDataTransfer Model)
        {
            Response<RealEstateDetail> Response = await Service.AnySelectAsync(Model);
            return new Response<RealEstateDetail>
            {
                Message = Response.Message,
                Collection = Response.Collection,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}