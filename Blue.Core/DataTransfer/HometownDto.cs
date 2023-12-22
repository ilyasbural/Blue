namespace Blue.Core
{
    public class HometownRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class HometownUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class HometownDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class HometownSelectDto
    {
        public Guid Id { get; set; }
    }
}