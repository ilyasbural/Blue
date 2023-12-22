namespace Blue.Core
{
    public class FurnitureRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FurnitureUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class FurnitureDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class FurnitureSelectDto
    {
        public Guid Id { get; set; }
    }
}