namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class FeaturesOutsideValidator : AbstractValidator<FeaturesOutside>
    {
        public FeaturesOutsideValidator()
        {
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}