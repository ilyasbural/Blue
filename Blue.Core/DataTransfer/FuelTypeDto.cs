namespace Blue.Core
{
    public class FuelTypeRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FuelTypeUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class FuelTypeDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class FuelTypeSelectDto
    {
        public Guid Id { get; set; }
    }
}