using Glass.Mapper.Sc.Web.Mvc;
using sc93.Models;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace sc93.Controllers
{
    public class HomeController : BaseController
    {
        //public ISitecoreContext _sitecoreContext = null;
        // GET: Home
        public ActionResult Index()
        {
            IMvcContext mvcContext = new MvcContext();

            HelloWorld model = mvcContext.GetRenderingItem<HelloWorld>();
            HelloWorld model1 = this._mvcContext.GetRenderingItem<HelloWorld>();
            return View(model1);
        }
    }
}