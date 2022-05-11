using Microsoft.AspNetCore.SignalR;
using SignalrD1Core;
namespace SignalrD1Core.Hubs
{
    public class chatHub:Hub
    {
        chatContext db;
        public chatHub(chatContext db)
        {
            this.db = db;
        }
        
        public void sendmessage(message m)
        {
            Clients.Others.SendAsync("newmess",m);

            db.messages.Add(m);
            db.SaveChanges();
           
        }

        public void joingroup(string gname , string name)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, gname);
            Clients.OthersInGroup(gname).SendAsync("newmember", gname, name);
        }


        public void senttogroup(string  gname , string message , string name)
        {
            Clients.OthersInGroup(gname).SendAsync("newgroupmessage", gname, message, name);
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

    }
}
