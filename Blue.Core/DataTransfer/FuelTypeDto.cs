﻿namespace Blue.Core
{
    public class FuelTypeRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FuelTypeUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
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