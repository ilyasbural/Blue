namespace Blue.Core
{
    public class BuyingTypeRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class BuyingTypeUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class BuyingTypeDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class BuyingTypeSelectDto
    {
        public Guid Id { get; set; }
    }
}