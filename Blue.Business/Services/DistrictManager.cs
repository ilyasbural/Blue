namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class DistrictManager : BusinessObjectBase<District>, IDistrictService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public DistrictManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<DistrictServiceResponse> InsertAsync(DistrictInsertDataTransfer Model)
        {
            District district = Mapper.Map<District>(Model);
            district.Id = Guid.NewGuid();
            district.RegisterDate = DateTime.Now;
            district.UpdateDate = DateTime.Now;
            district.IsActive = true;

            await UnitOfWork.District.InsertAsync(district);
            int result = await UnitOfWork.SaveChangesAsync();

            return new DistrictServiceResponse 
            { 
                Single = district, 
                Success = result 
            };
        }

        public async Task<DistrictServiceResponse> UpdateAsync(DistrictUpdateDataTransfer Model)
        {
            List<District> DataSource = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id);
            District district = Mapper.Map<District>(DataSource[0]);
            district.UpdateDate = DateTime.Now;

            await UnitOfWork.District.UpdateAsync(district);
            int result = await UnitOfWork.SaveChangesAsync();

            return new DistrictServiceResponse
            {
                Single = district,
                Success = result
            };
        }

        public async Task<DistrictServiceResponse> DeleteAsync(DistrictDeleteDataTransfer Model)
        {
            List<District> dataSource = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id);
            District district = Mapper.Map<District>(dataSource[0]);

            await UnitOfWork.District.DeleteAsync(district);
            int result = await UnitOfWork.SaveChangesAsync();

            return new DistrictServiceResponse { Success = result };
        }

        public async Task<DistrictServiceResponse> SelectAsync(DistrictSelectDataTransfer Model)
        {
            List<District> DataSource = await UnitOfWork.District.SelectAsync(x => x.IsActive == true);
            return new DistrictServiceResponse { List = DataSource };
        }

        public async Task<DistrictServiceResponse> AnySelectAsync(DistrictAnyDataTransfer Model)
        {
            DistrictServiceResponse response = new DistrictServiceResponse();
            response.IsAvailable = await UnitOfWork.City.AnySelectAsync(x => x.Id == Model.Id);
            return response;
        }
    }
}