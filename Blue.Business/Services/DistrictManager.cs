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
            await UnitOfWork.SaveChangesAsync();

            return new DistrictServiceResponse { District = district };
        }

        public async Task<DistrictServiceResponse> UpdateAsync(DistrictUpdateDataTransfer Model)
        {
            List<District> DataSource = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id);
            District district = Mapper.Map<District>(DataSource[0]);
            district.UpdateDate = DateTime.Now;

            await UnitOfWork.District.UpdateAsync(district);
            await UnitOfWork.SaveChangesAsync();

            DistrictServiceResponse districtServiceResponse = Mapper.Map<DistrictServiceResponse>(district);
            return new DistrictServiceResponse {   };
        }

        public async Task<DistrictServiceResponse> DeleteAsync(DistrictDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<DistrictServiceResponse> SelectAsync(DistrictSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<DistrictServiceResponse> AnySelectAsync(DistrictAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}