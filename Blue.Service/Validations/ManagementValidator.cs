namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class ManagementValidator : AbstractValidator<Management>
    {
        public ManagementValidator()
        {
            //RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Email area can not be null");
            //RuleFor(x => x.Password).NotEmpty().WithMessage("Password area can not be null");
        }
    }
}