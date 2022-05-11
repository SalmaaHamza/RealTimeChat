using Microsoft.AspNetCore.SignalR.Client;
namespace chatApp
{
    public partial class Form1 : Form
    {
        public string name { get; set; }
        public Form1()
        {
            InitializeComponent();
            name = "ali";
        }
        HubConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            //defineconnectio +build
             con = new HubConnectionBuilder().WithUrl("https://localhost:44389/chat").Build();


            //start con
            con.StartAsync();

            //subcribe event

            con.On<messdata>("newmess", (m) => lb_mess.Items.Add(m.name + ":" + m.txt));

            con.On<string, string>("newmember", (g, n) => lb_mess.Items.Add(n + " joinned " + g));
            con.On<string, string, string>("newgroupmessage", (g, m, n) => lb_mess.Items.Add(n + "(" + g + "):" + m));
        
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("sendmessage", new messdata() { name = name, txt = txt_mess.Text });
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("joingroup", txt_group.Text, name);
        }

        private void btn_sendgroup_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("senttogroup", txt_group.Text, txt_mess.Text, name);
        }
    }
}