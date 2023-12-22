namespace Blue.Core
{
    public class FeaturesAroundRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FeaturesAroundUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class FeaturesAroundDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class FeaturesAroundSelectDto
    {
        public Guid Id { get; set; }
    }
}