﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestApi.Controllers
{
    public class ReminderController : Controller
    {
        //
        // GET: /Reminder/

        public ActionResult Index()
        {
            return View();
        }

    }
}
