namespace Blue.Service
{
	using Core;
	using FluentValidation;

	public class BuyingTypeValidator : AbstractValidator<BuyingType>
	{
		public BuyingTypeValidator()
		{
			//RuleFor(x => x.Name).NotEmpty().WithMessage("Name area can not be null");
		}
	}
}