using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Hubs{
    public class ChatHub : Hub{

        //this method will send a notification to all clients
        //if client wants to communicate it will call <SendMessage()> method
        //if client wants to recieve a notification from the server it will use <ReceiveMessage()> method
        public async Task SendMessage(string user, string message){
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        //notifies everyone except the ones who have joined the chat
        public async Task JoinChat(string user, string message){
            await Clients.Others.SendAsync("ReceiveMessage", user, message);
        }

    }
}