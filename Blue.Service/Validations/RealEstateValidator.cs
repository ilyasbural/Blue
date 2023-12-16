namespace Blue.Service
{
	using Core;
	using FluentValidation;

	public class RealEstateValidator : AbstractValidator<RealEstate>
	{
		public RealEstateValidator()
		{
			//RuleFor(x => x.City).NotEmpty().WithMessage("City area can not be null");
			//RuleFor(x => x.District).NotEmpty().WithMessage("District can not be null");
			//RuleFor(x => x.Furniture).NotEmpty().WithMessage("Furniture can not be null");
			//RuleFor(x => x.Price).NotEmpty().WithMessage("Price area can not be null");
			//RuleFor(x => x.Size).NotEmpty().WithMessage("Size area can not be null");
			//RuleFor(x => x.Type).NotEmpty().WithMessage("Type area can not be null");
			//RuleFor(x => x.Warming).NotEmpty().WithMessage("Warming area can not be null");
			//RuleFor(x => x.Title).NotEmpty().WithMessage("Title area can not be null");
		}
	}
}