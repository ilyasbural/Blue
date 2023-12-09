namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}