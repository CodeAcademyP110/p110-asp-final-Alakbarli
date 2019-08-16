using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Turbo.Utilities.SD;
using Turbo.ViewModel;
using Turbo.DAL;
using Turbo.Models;

namespace Turbo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRole)]

    public class DashboardController : Controller
    {
        private readonly DB db;
        public DashboardController(DB dB)
        {
            db = dB;
        }
        public IActionResult Index()
        {
            ElanYaratViewModel model = new ElanYaratViewModel
            {
                Markalar = db.Markalar,
                Modeller = db.Modeller,
                Seherler = db.Seherler,
                Rengler = db.Rengler,

            };
            return View(model);
        }
        public IActionResult addstatic()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult addstatic(StaticDbData data)
        {
            if (data.Name == null)
            {
                ModelState.AddModelError("Name", "Adi daxil edin");
                return View(data);
            }

            if (data.Name.Trim() == null)
            {
                ModelState.AddModelError("Name", "Adi daxil edin");
                return View(data);
            }
            if (data.StaticDataName.Trim() == null)
            {
                ModelState.AddModelError("", "Data novu secin");
                return View(data);
            }

            switch (data.StaticDataName)
            {
                case "marka":
                    Marka marka = db.Markalar.FirstOrDefault(x => x.Name.ToLower() == data.Name.ToLower());
                    if (marka != null)
                    {
                        ModelState.AddModelError("", "Data artiq movcuddur");
                        return View(data);
                    }
                    db.Markalar.Add(new Models.Marka { Name = data.Name });
                    break;

                case "reng":
                    Reng reng = db.Rengler.FirstOrDefault(x => x.Name.ToLower() == data.Name.ToLower());
                    if (reng != null)
                    {
                        ModelState.AddModelError("", "Data artiq movcuddur");
                        return View(data);
                    }
                    db.Rengler.Add(new Models.Reng { Name = data.Name });
                    break;

                case "seher":
                    Seher seher = db.Seherler.FirstOrDefault(x => x.Name.ToLower() == data.Name.ToLower());
                    if (seher != null)
                    {
                        ModelState.AddModelError("", "Data artiq movcuddur");
                        return View(data);
                    }
                    db.Seherler.Add(new Models.Seher { Name = data.Name });
                    break;

                default:
                    ModelState.AddModelError("", "Data novunu duzgun secin");
                    return View(data);
            }
            db.SaveChangesAsync();
            TempData["data"] = true;
            return RedirectToAction(nameof(Index));
        }
        public IActionResult addmodel()
        {
            ViewBag.Markalar = db.Markalar.OrderBy(x => x.Name);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult addmodel(StaticDbData data)
        {
            if (data.Name == null)
            {
                ModelState.AddModelError("Name", "Adi daxil edin");
                ViewBag.Markalar = db.Markalar.OrderBy(x => x.Name);
                return View(data);
            }

            if (data.Name.Trim() == null)
            {
                ModelState.AddModelError("Name", "Adi daxil edin");
                ViewBag.Markalar = db.Markalar.OrderBy(x => x.Name);
                return View(data);
            }

            if (data.MarkaId == 0)
            {
                ModelState.AddModelError("Name", "Marka secin");
                ViewBag.Markalar = db.Markalar.OrderBy(x => x.Name);
                return View(data);
            }
            int id = data.MarkaId;

            Marka marka = db.Markalar.FirstOrDefault(x => x.Id == id);
            if (marka == null)
            {
                ModelState.AddModelError("Name", "Marka tapilmadi");
                ViewBag.Markalar = db.Markalar.OrderBy(x => x.Name);
                return View(data);
            }
            Model find = db.Modeller.FirstOrDefault(x => x.Name.ToLower() == data.Name.ToLower());
            if (find != null)
            {
                if(find.MarkaId == marka.Id)
                {
                    ModelState.AddModelError("Name", "Data artiq movcuddur");
                    ViewBag.Markalar = db.Markalar.OrderBy(x => x.Name);
                    return View(data);
                }
            }
               
                Model model = new Model { MarkaId = marka.Id, Name = data.Name };
            
            db.Modeller.Add(model);
            db.SaveChangesAsync();
            TempData["data"] = true;
            return RedirectToAction(nameof(Index));
        }

    }
}