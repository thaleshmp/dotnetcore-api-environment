namespace dotnetcore_api_environment.Infrastructure
{
    public class AppConfiguration
    {
        public int MinimunAgeToAllowRegister { get; set; }
        public SMTPConfiguration SMTP { get; set; }
    }

    public class SMTPConfiguration
    {
        public string Domain {get;set;}
        public string Credential { get; set; }
    }
}