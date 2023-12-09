namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class DistrictValidator : AbstractValidator<District>
    {
        public DistrictValidator()
        {
            //RuleFor(x => x.City).NotEmpty().WithMessage("City can not be null");
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}