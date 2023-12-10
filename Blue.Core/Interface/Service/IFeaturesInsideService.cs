namespace Blue.Core
{
    public interface IFeaturesInsideService
    {
        Task<Response<FeaturesInside>> InsertAsync(FeaturesInsideRegisterDto Model);
    }
}