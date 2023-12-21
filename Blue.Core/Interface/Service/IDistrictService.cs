namespace Blue.Core
{
    public interface IDistrictService
    {
        Task<Response<District>> InsertAsync(DistrictRegisterDto Model);
        Task<Response<District>> UpdateAsync(DistrictUpdateDto Model);
        Task<Response<District>> DeleteAsync(DistrictDeleteDto Model);
        Task<Response<District>> SelectAsync(DistrictSelectDto Model);
        Task<Response<District>> SelectSingleAsync(DistrictSelectDto Model);
    }
}