using Microsoft.AspNetCore.SignalR;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GateCommunityMvc.Data
{
    public class VisitorHub : Hub
    {
        //public async Task SendVisitorNotification(string adminId, string visitorName, string visitorLink)
        //{
        //    // Send the visitor notification to the specified admin client
        //    await Clients.Client(adminId).SendAsync("ReceiveVisitorNotification", visitorName, visitorLink);
        //}
        public async Task SendNotification(string userId, string message)
        {
            await Clients.User(userId).SendAsync("ReceiveNotification", message);
        }
    }
}
