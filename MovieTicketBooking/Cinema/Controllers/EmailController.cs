﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult SendEmail(string useremail)
        {

            return View();
        }
    }
}
