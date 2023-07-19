namespace GateCommunityMvc.Data
{
	public class EmailMessage
	{
		public string To { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
	}
	public class SmtpSettings
	{
		public string Server { get; set; }
		public int Port { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}


}
