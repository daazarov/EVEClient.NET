﻿namespace EVEClient.NET.Pipline.Modifications
{
    internal class AdditionalComponent
    {
        public required PiplineComponent PiplineComponent { get; init; }
        public string? AddAfter { get; set; }
        public bool AddToEnd { get; set; }
        public bool AddToStart { get; set; }
        public int? EndOrder { get; set; }
        public int? StartOrder { get; set; }
    }
}
