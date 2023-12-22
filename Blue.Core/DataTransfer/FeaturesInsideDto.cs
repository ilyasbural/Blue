namespace Blue.Core
{
    public class FeaturesInsideRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FeaturesInsideUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class FeaturesInsideDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class FeaturesInsideSelectDto
    {
        public Guid Id { get; set; }
    }
}