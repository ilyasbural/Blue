﻿namespace Blue.Core
{
    public class FeaturesInsideRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FeaturesInsideUpdateDto
    {
        public Guid Id { get; set; }
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