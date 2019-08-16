using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL;
using Turbo.Extentions;
using Turbo.Models;
using Turbo.ViewModel;
using static Turbo.Utilities.SD;

namespace Turbo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRole)]
    public class MeqaleController : Controller
    {
        private readonly DB db;
        private readonly IHostingEnvironment env;

        private readonly UserManager<User> userManager;
        public MeqaleController(DB dB, UserManager<User> userM, IHostingEnvironment _env)
        {
            db = dB;
            userManager = userM;
            env = _env;
        }
        public IActionResult Index()
        {
            ElanYaratViewModel model = new ElanYaratViewModel
            {
                Meqaleler = db.Meqaleler.Include(x => x.User)
            };
            return View(model);
        }
        public IActionResult Yarat()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Yarat(Meqale _meqale)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Nese xeta bas verdi");
                return View(_meqale);
            }
            User user =await userManager.FindByNameAsync(User.Identity.Name);
            Meqale meqale = new Meqale
            {
                Basliq = _meqale.Basliq,
                Melumat = _meqale.Melumat,
                YazilmaVaxti=DateTime.Now,
                UserId=user.Id

            };
            if (_meqale.file == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa sekil elave edin");
                return View(_meqale);
            }
            
            meqale.Sekil = await _meqale.file.Save(env, "images/Cars");
            db.Meqaleler.Add(meqale);
            await db.SaveChangesAsync();
            TempData["PostAdded"] = true;
            return RedirectToAction("index","Meqale");
        }
        
        public async Task<IActionResult> Delete(int Id)
        {
            Meqale meqale = db.Meqaleler.FirstOrDefault(x => x.Id == Id);
            if (meqale == null) { return NotFound(); }
            System.IO.File.Delete(Path.Combine(env.WebRootPath, "images/Cars", meqale.Sekil));
            db.Meqaleler.Remove(meqale);
            await db.SaveChangesAsync();

            return Content("true");
        }
        public IActionResult Edit(int id)
        {
            Meqale meqale = db.Meqaleler.FirstOrDefault(x => x.Id == id);
            if (meqale == null)
            {
                return NotFound();
            }
            return View(meqale);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Edit(Meqale _meqale)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Melumatlari duzgun daxil edin");
                return View(_meqale);
            }
            int id = 0;
            id = _meqale.Id;
            if (id == 0)
            {
                ModelState.AddModelError("", "Meqale yenilenmedi.");
                return View(_meqale);
            }
            Meqale meqale = db.Meqaleler.FirstOrDefault(x => x.Id == _meqale.Id);
            meqale.Basliq = _meqale.Basliq;
            meqale.Melumat = _meqale.Melumat;
            if (_meqale.file != null)
            {
                System.IO.File.Delete(Path.Combine(env.WebRootPath, "images/Cars", meqale.Sekil));
                meqale.Sekil = await _meqale.file.Save(env, "images/Cars");
                
            }
            await db.SaveChangesAsync();
            TempData["PostEdited"] = true;
            return RedirectToAction("index", "Meqale");
        }
        public IActionResult Detail(int? Id)
        {
            if (Id == null)
            {
                RedirectToAction(nameof(Index));
            }
            Meqale meqale = db.Meqaleler.Include(x=>x.User).FirstOrDefault(x => x.Id == Id);
            if (meqale == null)
            {
                return NotFound();
            }

            ElanYaratViewModel vm = new ElanYaratViewModel
            {
                Meqale = meqale,
                Reyler = db.Reyler.Where(x => x.Meqale.Id == Id).Include(x=>x.User)

            };
            return View(vm);
        }
        [HttpPost]
       // [Route("[controller]/[action]/{id}/{text}")]
        [Authorize(Roles =AdminRole)]
        public async Task<IActionResult> WriteComment(int Id, string text)
        {
            if (string.IsNullOrEmpty(text.Trim()))
            {
                return Content("false");
            }
            User user = await userManager.FindByNameAsync(User.Identity.Name);
            Rey comment = new Rey
            {
                MeqaleId = Id,
                dateTime = DateTime.Now,
                Text = text,
                UserId = user.Id

            };
            db.Reyler.Add(comment);
            await db.SaveChangesAsync();
            comment.User = user;
            return PartialView("_CommentPartial", comment);
        }
    }
}