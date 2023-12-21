namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class FeaturesAroundValidator : AbstractValidator<FeaturesAround>
    {
        public FeaturesAroundValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}