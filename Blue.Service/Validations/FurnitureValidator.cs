namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class FurnitureValidator : AbstractValidator<Furniture>
    {
        public FurnitureValidator()
        {
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}