namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementManager : BusinessObjectBase<Management>, IManagementService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public ManagementManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ManagementServiceResponse> InsertAsync(ManagementInsertDataTransfer Model)
        {
            Management management = Mapper.Map<Management>(Model);
            management.Id = Guid.NewGuid();
            management.RegisterDate = DateTime.Now;
            management.UpdateDate = DateTime.Now;
            management.IsActive = true;

            await UnitOfWork.Management.InsertAsync(management);
            await UnitOfWork.SaveChangesAsync();

            return new ManagementServiceResponse { Single = management };
        }

        public async Task<ManagementServiceResponse> UpdateAsync(ManagementUpdateDataTransfer Model)
        {
            List<Management> DataSource = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Management management = Mapper.Map<Management>(DataSource[0]);
            management.UpdateDate = DateTime.Now;

            await UnitOfWork.Management.UpdateAsync(management);
            await UnitOfWork.SaveChangesAsync();

            return new ManagementServiceResponse { Single = management };
        }

        public async Task<ManagementServiceResponse> DeleteAsync(ManagementDeleteDataTransfer Model)
        {
            List<Management> dataSource = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Management management = Mapper.Map<Management>(dataSource[0]);

            await UnitOfWork.Management.DeleteAsync(management);
            await UnitOfWork.SaveChangesAsync();

            return new ManagementServiceResponse {         };
        }

        public async Task<ManagementServiceResponse> SelectAsync(ManagementSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementServiceResponse> AnySelectAsync(ManagementAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}