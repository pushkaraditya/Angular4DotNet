using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRChat
{
  [HubName("chat")]
  public class ChatHub : Hub
  {
    public void SayHello(string message)
    {
      Clients.All.speak(message + " from the server");
    }
  }
}