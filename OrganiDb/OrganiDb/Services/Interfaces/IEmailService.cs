namespace OrganiDb.Services.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string html, string from = null);
    }
}
