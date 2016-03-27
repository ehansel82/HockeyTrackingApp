using System;
using System.Diagnostics;
using System.Web;

namespace HockeyTrackingApp.HttpModules
{
    public class PreRequestHandlerModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.PreRequestHandlerExecute += new EventHandler(PreRequestHandlerRoutine);
        }

        public void PreRequestHandlerRoutine(object sender, EventArgs e)
        {
            if( HttpContext.Current.Handler != null)
            {
                var handlerMessage = "Current handler is: " + HttpContext.Current.Handler.ToString();
                Debug.Print(handlerMessage);
                HttpContext.Current.Items.Add("handlerMessage", handlerMessage);
            } 
        }
    }
}