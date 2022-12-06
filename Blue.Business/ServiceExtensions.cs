namespace Blue.Business
{
    using Core;
    using DataAccess;
    //using FluentValidation;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceExtensions
    {
        public static IServiceCollection LoadServices(this IServiceCollection Service)
        {
            //Service.AddDbContext<DbContext>();
            //Service.AddDbContext<MiyloContext>();

            //Service.AddScoped<IFriendRepository, FriendRepositoryEF>();
            //Service.AddScoped<ILanguageDetailRepository, LanguageDetailRepositoryEF>();
            //Service.AddScoped<ILanguageRepository, LanguageRepositoryEF>();
            //Service.AddScoped<IManagementDetailRepository, ManagementDetailRepositoryEF>();
            //Service.AddScoped<IManagementRepository, ManagementRepositoryEF>();
            //Service.AddScoped<IRegionRepository, RegionRepositoryEF>();
            //Service.AddScoped<IScheduleDetailRepository, ScheduleDetailRepositoryEF>();
            //Service.AddScoped<IScheduleRepository, ScheduleRepositoryEF>();
            //Service.AddScoped<IScheduleTypeRepository, ScheduleTypeRepositoryEF>();
            //Service.AddScoped<IUserDetailRepository, UserDetailRepositoryEF>();
            //Service.AddScoped<IUserRepository, UserRepositoryEF>();
            //Service.AddScoped<IUserPictureRepository, UserPictureRepositoryEF>();
            //Service.AddScoped<IUserSettingsRepository, UserSettingsRepositoryEF>();

            //Service.AddScoped<IValidator<Friend>, FriendValidator>();
            //Service.AddScoped<IValidator<LanguageDetail>, LanguageDetailValidator>();
            //Service.AddScoped<IValidator<Language>, LanguageValidator>();
            //Service.AddScoped<IValidator<ManagementDetail>, ManagementDetailValidator>();
            //Service.AddScoped<IValidator<Management>, ManagementValidator>();
            //Service.AddScoped<IValidator<Region>, RegionValidator>();
            //Service.AddScoped<IValidator<ScheduleDetail>, ScheduleDetailValidator>();
            //Service.AddScoped<IValidator<Schedule>, ScheduleValidator>();
            //Service.AddScoped<IValidator<ScheduleType>, ScheduleTypeValidator>();
            //Service.AddScoped<IValidator<UserDetail>, UserDetailValidator>();
            //Service.AddScoped<IValidator<User>, UserValidator>();
            //Service.AddScoped<IValidator<UserPicture>, UserPictureValidator>();
            //Service.AddScoped<IValidator<UserSettings>, UserSettingsValidator>();

            //Service.AddScoped<IFriendService, FriendManager>();
            //Service.AddScoped<ILanguageDetailService, LanguageDetailManager>();
            //Service.AddScoped<ILanguageService, LanguageManager>();
            //Service.AddScoped<IManagementDetailService, ManagementDetailManager>();
            //Service.AddScoped<IManagementService, ManagementManager>();
            //Service.AddScoped<IRegionService, RegionManager>();
            //Service.AddScoped<IScheduleDetailService, ScheduleDetailManager>();
            //Service.AddScoped<IScheduleService, ScheduleManager>();
            //Service.AddScoped<IScheduleTypeService, ScheduleTypeManager>();
            //Service.AddScoped<IUserDetailService, UserDetailManager>();
            //Service.AddScoped<IUserService, UserManager>();
            //Service.AddScoped<IUserPictureService, UserPictureManager>();
            //Service.AddScoped<IUserSettingsService, UserSettingsManager>();

            return Service;
        }
    }
}