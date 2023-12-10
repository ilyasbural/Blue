namespace Blue.Core
{
    public interface IFeaturesAroundService
    {
        Task<Response<FeaturesAround>> InsertAsync(FeaturesAroundRegisterDto Model);
    }
}