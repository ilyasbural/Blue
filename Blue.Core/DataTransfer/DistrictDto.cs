namespace Blue.Core
{
    public class DistrictRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class DistrictUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class DistrictDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class DistrictSelectDto
    {
        public Guid Id { get; set; }
    }
}