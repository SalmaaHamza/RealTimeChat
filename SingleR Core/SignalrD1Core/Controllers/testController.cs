using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalrD1Core.Hubs;
namespace SignalrD1Core.Controllers
{
    public class testController : Controller
    {
        IHubContext<chatHub> chat;
        public testController(IHubContext<chatHub> chat)
        {
            this.chat = chat;
        }
        public IActionResult Index()
        {

            chat.Clients.All.SendAsync("newmess", new message() { name = "test user", txt = "send from controller" });
            return View();
        }
    }
}
