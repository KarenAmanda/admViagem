﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTeste.Controllers
{
    public class BudgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}