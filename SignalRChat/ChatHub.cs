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
    public void SendMessage(SentData data)
    {
      Clients.Group(data.RoomName, Context.ConnectionId).newMessage(data.Name + ": " + data.Message);
    }

    public void JoinRoom(string roomName, string name)
    {
      Clients.OthersInGroup(roomName).newNotification(name + " has joined the room");
      Groups.Add(Context.ConnectionId, roomName);
    }

    public void LeaveRoom(string roomName, string name)
    {
      Clients.OthersInGroup(roomName).newNotification(name + " has left the room");
      Groups.Remove(Context.ConnectionId, roomName);
    }
  }

  public class SentData
  {
    public string RoomName { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
  }
}