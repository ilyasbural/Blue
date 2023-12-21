namespace Blue.Core
{
    public interface IFeaturesInsideService
    {
        Task<Response<FeaturesInside>> InsertAsync(FeaturesInsideRegisterDto Model);
        Task<Response<FeaturesInside>> UpdateAsync(FeaturesInsideUpdateDto Model);
        Task<Response<FeaturesInside>> DeleteAsync(FeaturesInsideDeleteDto Model);
        Task<Response<FeaturesInside>> SelectAsync(FeaturesInsideSelectDto Model);
        Task<Response<FeaturesInside>> SelectSingleAsync(FeaturesInsideSelectDto Model);
    }
}