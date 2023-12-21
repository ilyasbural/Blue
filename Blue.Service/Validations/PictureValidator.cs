namespace Blue.Service
{
    using Core;
    using FluentValidation;

    public class PictureValidator : AbstractValidator<Picture>
    {
        public PictureValidator()
        {
            //RuleFor(p => p.Name).NotEmpty().WithMessage("Name area can not be null");
        }
    }
}