namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class TypeValidator : AbstractValidator<Type>
    {
        public TypeValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}