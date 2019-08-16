using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Turbo.DAL;
using Turbo.Models;
using static Turbo.Utilities.SD;
using Turbo.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Turbo.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly DB db;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        public HomeController(DB dB, RoleManager<IdentityRole> roleM, UserManager<User> userM, SignInManager<User> sManager)
        {
            db = dB;
            roleManager = roleM;
            userManager = userM;
            signInManager = sManager;
        }
        
        public IActionResult Index()
        {
            ElanYaratViewModel model = new ElanYaratViewModel
            {
                Meqaleler = db.Meqaleler.Include(x => x.User),
                Markalar = db.Markalar,
                Elanlar = db.Elanlar.Where(x => x.Register == true).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
            };
            return View(model);
        }
        public async Task SeedRoles()
        {
            if (!await roleManager.RoleExistsAsync(AdminRole))
            {
                await roleManager.CreateAsync(new IdentityRole(AdminRole));
            }
            
            if (!await roleManager.RoleExistsAsync(MemberRole))
            {
                await roleManager.CreateAsync(new IdentityRole(MemberRole));
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
