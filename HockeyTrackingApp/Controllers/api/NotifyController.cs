using HockeyTrackingApp.WebSockets;
using Microsoft.Web.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace HockeyTrackingApp.Controllers.api
{
    /// <summary>
    /// This controller handles websocket subscriptions for notifications.
    /// A Get request upgrades the connection to websockets.
    /// </summary>
    public class NotifyController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            HttpContext.Current.AcceptWebSocketRequest(new NotifyWebSocketHandler());
            return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);
        }
    }
}
