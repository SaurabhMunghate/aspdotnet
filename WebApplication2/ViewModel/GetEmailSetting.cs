namespace WebApplication2.ViewModel
{
    public class GetEmailSetting
    {
        public string SecretKey { get; set; }  
        public string From {  get; set; }   
        public String SmtpServer { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }
    }
}
