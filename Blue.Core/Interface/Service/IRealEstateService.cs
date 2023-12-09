namespace Blue.Core
{
    public interface IRealEstateService
    {
        Task<Response<RealEstate>> InsertAsync(RealEstateRegisterDto Model);
        Task<Response<RealEstate>> UpdateAsync(RealEstateUpdateDto Model);
        Task<Response<RealEstate>> DeleteAsync(RealEstateDeleteDto Model);
        Task<Response<RealEstate>> SelectAsync(RealEstateSelectDto Model);
        Task<Response<RealEstate>> SelectSingleAsync(RealEstateSelectDto Model);
    }
}