﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEvernote.WebApp.Controllers
{
    public class İnceleController : Controller
    {
        // GET: İncele
        public ActionResult ShowScriptComments()
        {
            return PartialView("_Partialİncele");
        }
    }
}