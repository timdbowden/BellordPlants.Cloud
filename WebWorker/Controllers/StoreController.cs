using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BellordPlants.Cloud.MVC.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello from Store.Index()";
        }

        

        public string Browse(string genus)
        {
            string strMessage = HttpUtility.HtmlEncode("The Genus of Flowers you are looking for is: " + genus);
            
            return strMessage;
        }

        public string Details(int id)
        {
            return "Hello from Details" + id;
        }

    }
}
