﻿namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FromWhoManager : BusinessObject<FromWho>, IFromWhoService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FromWho> Validator;

        public FromWhoManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FromWho> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<FromWho>> InsertAsync(FromWhoRegisterDto Model)
        {
            Data = Mapper.Map<FromWho>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<FromWho>(Data);
            await UnitOfWork.FromWho.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FromWho>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<FromWho>> UpdateAsync(FromWhoUpdateDto Model)
        {
            Collection = await UnitOfWork.FromWho.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            Collection[0].Name = Model.Name;
            Collection[0].UpdateDate = DateTime.Now;
            await UnitOfWork.FromWho.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FromWho>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FromWho>> DeleteAsync(FromWhoDeleteDto Model)
        {
            Collection = await UnitOfWork.FromWho.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.FromWho.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FromWho>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FromWho>> SelectAsync(FromWhoSelectDto Model)
        {
            Collection = await UnitOfWork.FromWho.SelectAsync(x => x.IsActive == true);
            return new Response<FromWho>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FromWho>> SelectSingleAsync(FromWhoSelectDto Model)
        {
            Collection = await UnitOfWork.FromWho.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<FromWho>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}