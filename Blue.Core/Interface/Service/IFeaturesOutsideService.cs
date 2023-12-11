﻿namespace Blue.Core
{
    public interface IFeaturesOutsideService
    {
        Task<Response<FeaturesOutside>> InsertAsync(FeaturesOutsideRegisterDto Model);
        Task<Response<FeaturesOutside>> UpdateAsync(FeaturesOutsideUpdateDto Model);
        Task<Response<FeaturesOutside>> DeleteAsync(FeaturesOutsideDeleteDto Model);
    }
}