using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Turbo.DAL;
using Turbo.Models;
using Turbo.ViewModel;
using static Turbo.Utilities.SD;

namespace Turbo.Controllers
{
    public class AccountController : Controller
    {
        private readonly DB db;
        private readonly UserManager<User> userManger;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AccountController(DB dB, UserManager<User> um, SignInManager<User> inManager, RoleManager<IdentityRole> roleManagerr)
        {
            db = dB;
            userManger = um;
            signInManager = inManager;
            roleManager = roleManagerr;
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost][ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(SignIn signInUs)
        {
            if (!ModelState.IsValid)
            {
                return View(signInUs);
            }
            User user = await userManger.FindByNameAsync(signInUs.usernameOrEmail);
            User user2= await userManger.FindByEmailAsync(signInUs.usernameOrEmail);
            if (user == null && user2 != null)
            {
                user = user2;
            }
            if (user == null)
            {
                ModelState.AddModelError("", "Username or Password is wrong");
                return View(signInUs);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await signInManager.PasswordSignInAsync(user, signInUs.Password, signInUs.Remember, true);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username,Email or Password is wrong");
                return View(signInUs);
            }
            return RedirectToAction("Index", "Home");
            
        }
        public IActionResult Signup()
        {
            
            return View();
        }
        [HttpPost][ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup(SignUp signUp)
        {

            if (!ModelState.IsValid)
            {
               
                return View(signUp);
            }
            User user = new User
            {
                Ad = signUp.Ad,
                Soyad = signUp.Soyad,
                Email = signUp.Email,
                UserName = signUp.Username,
                PhoneNumber=signUp.Telofon
                

            };
            IdentityResult identityResult = await userManger.CreateAsync(user, signUp.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var er in identityResult.Errors)
                {
                    ModelState.AddModelError("", er.Description);
                }
               
                return View(signUp);
            }
            await userManger.AddToRoleAsync(user, MemberRole);

            await signInManager.SignInAsync(user, true);
            return RedirectToAction("Index", "Home");

            
        }
        public async Task<IActionResult> Signout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}