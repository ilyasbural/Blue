namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class RealEstateDetailValidator : AbstractValidator<RealEstateDetail>
    {
        public RealEstateDetailValidator()
        {
            //RuleFor(x => x.Description).NotEmpty().WithMessage("Description area can not be null");
        }
    }
}