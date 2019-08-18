using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL;
using Turbo.Models;
using Turbo.ViewModel;

namespace Turbo.Controllers
{
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
        public IActionResult Detail(int? Id)
        {
            if (Id == null)
            {
                RedirectToAction(nameof(Index));
            }
            Meqale meqale = db.Meqaleler.Include(x => x.User).FirstOrDefault(x => x.Id == Id);
            if (meqale == null)
            {
                return NotFound();
            }

            ElanYaratViewModel vm = new ElanYaratViewModel
            {
                Meqale = meqale,
                Reyler = db.Reyler.Where(x => x.Meqale.Id == Id).Include(x => x.User)

            };
            return View(vm);
        }
        [HttpPost]
        
        [Route("[controller]/[action]/{id}/{text}")]
        [Authorize]
        public async Task<IActionResult> WriteComment(int id, string text)
        {
            
           if (string.IsNullOrEmpty(text.Trim()))
            {
              return Content("false");
           }
            User user = await userManager.FindByNameAsync(User.Identity.Name);
            Rey comment = new Rey
            {
                MeqaleId = id,
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
