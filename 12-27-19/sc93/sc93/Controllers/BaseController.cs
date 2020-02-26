using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sc93.Controllers
{
    public class BaseController : Controller
    {
        protected IMvcContext _mvcContext;
        public BaseController()
        {
            _mvcContext = new MvcContext();
        }
    }
}