namespace WebApplication2.Repository.Interface
{
    public interface IEmailSender
    {
        Task<bool> EmailSenderAsys(String email, String Subject, String message);
    }
}
