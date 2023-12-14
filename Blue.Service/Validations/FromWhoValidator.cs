namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class FromWhoValidator : AbstractValidator<FromWho>
    {
        public FromWhoValidator()
        {
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}