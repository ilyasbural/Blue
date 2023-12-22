namespace Blue.Core
{
    public class RoomRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class RoomUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class RoomDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class RoomSelectDto
    {
        public Guid Id { get; set; }
    }
}