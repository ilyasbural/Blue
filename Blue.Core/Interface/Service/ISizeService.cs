namespace Blue.Core
{
    public interface ISizeService
    {
        Task<Response<Size>> InsertAsync(SizeRegisterDto Model);
        Task<Response<Size>> UpdateAsync(SizeUpdateDto Model);
        Task<Response<Size>> DeleteAsync(SizeDeleteDto Model);
        Task<Response<Size>> SelectAsync(SizeSelectDto Model);
        Task<Response<Size>> SelectSingleAsync(SizeSelectDto Model);
    }
}