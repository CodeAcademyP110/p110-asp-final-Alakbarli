using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Turbo.DAL;

namespace Turbo.Controllers
{
    public class AjaxController : Controller
    {
        private readonly DB db;
        public AjaxController(DB dB)
        {
            db = dB;
        }

        [HttpPost]
        public IActionResult LoadModelOption(int Id)
        {
            return PartialView("_ModelOptionsPartial", db.Modeller.Where(x => x.MarkaId == Id));
        }
    }
}