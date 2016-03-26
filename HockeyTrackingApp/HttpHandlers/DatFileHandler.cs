using System.Web;

namespace HockeyTrackingApp.HttpHandlers
{
    /// <summary>
    /// Custom http handler for dat files.
    /// This has the following corresponding entry in the web.config:
    ///    <!--<add verb="*" path="*.dat" type="DatFileHandler"/>-->
    /// </summary>
    public class DatFileHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("This site does not serve .DAT files!");
        }
    }
}