﻿namespace Blue.Core
{
    public class FeaturesOutsideRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FeaturesOutsideUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class FeaturesOutsideDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class FeaturesOutsideSelectDto
    {
        public Guid Id { get; set; }
    }
}