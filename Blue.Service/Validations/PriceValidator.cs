namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class PriceValidator : AbstractValidator<Price>
    {
        public PriceValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name can not be null");
        }
    }
}