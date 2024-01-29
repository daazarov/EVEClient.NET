namespace EVEOnline.Esi.Communication.Configuration
{
    public class EsiClientConfiguration
    {
        internal const string DefaultEsiConfigurationSectionName = "EsiClientConfiguration";

        public string BaseUrl { get; set; }
        public string Server { get; set; }
        public string UserAgent { get; set; }
        public bool EnableETag { get; set; }
    }
}
