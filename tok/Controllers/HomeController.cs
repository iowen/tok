using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenTokSDK;
namespace tok.Controllers
{
    public class HomeController : Controller
    {

        static int ApiKey = 45273952; // YOUR API KEY
        static string ApiSecret = "76fd4d22697620e85e5fdd6bcc3b1f53eed2c7a8";
        public ActionResult Index()
        {
            var OpenTok = new OpenTok(ApiKey, ApiSecret);

            //// Create a session that will attempt to transmit streams directly between clients
            //var session = OpenTok.CreateSession();
            //// Store this sessionId in the database for later use:
            //string sessionId = session.Id;

            // Create a session that uses the OpenTok Media Router (which is required for archiving)
            var session =  OpenTok.CreateSession(mediaMode: MediaMode.ROUTED);
            // Store this sessionId in the database for later use:
           // string sessionId = session.Id;

            //// Create an automatically archived session:
            //var session = OpenTok.CreateSession(mediaMode: MediaMode.ROUTED, ArchiveMode.ALWAYS);
            // Store this sessionId in the database for later use:
            ViewBag.sessionId = session.Id;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}