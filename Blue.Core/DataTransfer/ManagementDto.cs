namespace Blue.Core
{
    public class ManagementRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class ManagementUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class ManagementDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class ManagementSelectDto
    {
        public Guid Id { get; set; }
    }
}