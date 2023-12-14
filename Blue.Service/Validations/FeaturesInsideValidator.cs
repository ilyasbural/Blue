namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class FeaturesInsideValidator : AbstractValidator<FeaturesInside>
    {
        public FeaturesInsideValidator()
        {
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}