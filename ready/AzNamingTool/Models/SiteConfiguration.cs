﻿namespace AzureNamingTool.Models
{
    public class SiteConfiguration
    {
        public string? SALTKey { get; set; }
        public string? AdminPassword { get; set; }
        public string? APIKey { get; set; }
        public string? AppTheme { get; set; }
        public bool? DevMode { get; set; } = false;
    }
}
