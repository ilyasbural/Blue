namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class BuildingTypeValidator : AbstractValidator<BuildingType>
    {
        public BuildingTypeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}