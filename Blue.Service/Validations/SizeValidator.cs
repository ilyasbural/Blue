namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class SizeValidator : AbstractValidator<Size>
    {
        public SizeValidator()
        {
            //RuleFor(p => p.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}