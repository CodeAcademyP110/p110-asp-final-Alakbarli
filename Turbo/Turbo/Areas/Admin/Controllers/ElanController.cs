using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.DAL;
using Turbo.Models;
using Turbo.ViewModel;
using static Turbo.Utilities.SD;

namespace Turbo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRole)]
    public class ElanController : Controller
    {
        private readonly DB db;
        public ElanController(DB dB)
        {
            db = dB;
        }
        public IActionResult Conformed()
        {
            ElanYaratViewModel elan = new ElanYaratViewModel
            {
                Elanlar = db.Elanlar.Where(x => x.Register == true).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
            };
            return View(elan);
        }
        public IActionResult Notconformed()
        {

            ElanYaratViewModel elan = new ElanYaratViewModel
            {
                Elanlar = db.Elanlar.Where(x=>x.Register==false).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
            };
            return View(elan);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Elan elan = await db.Elanlar.FirstOrDefaultAsync(x => x.Id == id);
            if (elan == null)
            {
                TempData["NotFoundCar"]=true;
                return RedirectToAction(nameof(Notconformed));
            }
            elan = await db.Elanlar.Include(x => x.Model).Include(x => x.BanNovu)
                .Include(x => x.Model.Marka).Include(x => x.IstehsalIli)
                .Include(x=>x.User)
                .Include(x => x.MuherrikHecmi).Include(x => x.Seher).Include(x => x.Oturucu)
                .Include(x => x.Reng).Include(x => x.Sekiller).Include(x => x.SuretQutusu)
                .Include(x => x.YanacaqNovu).FirstOrDefaultAsync(x => x.Id == id); ;

            return View(elan);
            
        }
        public async Task<IActionResult> Doconform(int id)
        {
            Elan elan = await db.Elanlar.FirstOrDefaultAsync(x => x.Id == id);
            if (elan == null)
            {
                TempData["NotFoundCar"] = true;
                return RedirectToAction(nameof(Notconformed));
            }
            elan.Register = true;
            await db.SaveChangesAsync();
            TempData["DoConformed"] = true;
            return RedirectToAction(nameof(Notconformed));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Elan elan = await db.Elanlar.FirstOrDefaultAsync(x => x.Id == id);
            if (elan == null)
            {
                TempData["NotFoundCar"] = true;
                return RedirectToAction(nameof(Notconformed));
            }
            db.Sekiller.RemoveRange(db.Sekiller.Where(x => x.ElanId == elan.Id));
            db.Elanlar.Remove(elan);
            await db.SaveChangesAsync();
            TempData["Deleted"] = true;
            return RedirectToAction(nameof(Conformed));
        }
    }
}