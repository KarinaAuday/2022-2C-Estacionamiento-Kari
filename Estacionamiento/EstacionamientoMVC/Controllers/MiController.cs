﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMVC.Controllers
{
    public class MiController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }
    }
}
