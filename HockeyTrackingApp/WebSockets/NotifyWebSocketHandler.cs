using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HockeyTrackingApp.WebSockets
{
    public class NotifyWebSocketHandler : WebSocketHandler
    {
        private static WebSocketCollection _clients = new WebSocketCollection();

        public override void OnOpen()
        {
            _clients.Add(this);
        }

        public void PlayerCreated(string player)
        {
            _clients.Broadcast(player + " added to system.");
        }
    }
}