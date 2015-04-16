using System.Web;
using System.Web.Mvc;

namespace SPA.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /

        public ActionResult Index ()
        {
            return View ();
        }

    }
}
