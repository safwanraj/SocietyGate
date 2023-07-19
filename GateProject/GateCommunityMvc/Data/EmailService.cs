using GateCommunityMvc.Data;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Options;


namespace GateCommunityMvc.Data
{

	public interface IEmailService
	{
		void SendEmail(EmailMessage message);
	}
	public class EmailService : IEmailService
	{
		private readonly SmtpSettings _smtpSettings;

		public EmailService(IOptions<SmtpSettings> smtpSettings)
		{
			_smtpSettings = smtpSettings.Value;
		}

		public void SendEmail(EmailMessage message)
		{
			var email = new MimeMessage();
			email.From.Add(new MailboxAddress(_smtpSettings.Username, _smtpSettings.Username));
			email.To.Add(new MailboxAddress(message.To, message.To));
			email.Subject = message.Subject;
			email.Body = new TextPart("plain")
			{
				Text = message.Body
			};

			using (var client = new SmtpClient())
			{
				client.Connect(_smtpSettings.Server, _smtpSettings.Port, false);
				client.Authenticate(_smtpSettings.Username, _smtpSettings.Password);
				client.Send(email);
				client.Disconnect(true);
			}
		}

	}
}

	
