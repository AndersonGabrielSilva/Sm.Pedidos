namespace Domain.Settings
{
    public class AppSettings
    {
        public string SecretJwt { get; set; }
        public int ExpirationHours { get; set; }
        public string Issuer { get; set; }
        public string[] ValidOn { get; set; }
    }
}
