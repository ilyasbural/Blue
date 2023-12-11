namespace Blue.Core
{
    public interface IFeaturesAroundService
    {
        Task<Response<FeaturesAround>> InsertAsync(FeaturesAroundRegisterDto Model);
        Task<Response<FeaturesAround>> UpdateAsync(FeaturesAroundUpdateDto Model);
        Task<Response<FeaturesAround>> DeleteAsync(FeaturesAroundDeleteDto Model);
    }
}