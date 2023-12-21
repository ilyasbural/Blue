namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class WarmingValidator : AbstractValidator<Warming>
    {
        public WarmingValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Warming area can not be null");
        }
    }
}