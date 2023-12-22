namespace Blue.Core
{
    public class BuildingTypeRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class BuildingTypeUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }

    public class BuildingTypeDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class BuildingTypeSelectDto
    {
        public Guid Id { get; set; }
    }
}