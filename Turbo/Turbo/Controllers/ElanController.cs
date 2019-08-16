using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Turbo.DAL;
using Turbo.Models;
using Turbo.ViewModel;
using Turbo.Extentions;
using static Turbo.Utilities.SD;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Turbo.Controllers
{
    [Authorize]
    public class ElanController : Controller
    {
        private readonly DB db;
        private readonly IHostingEnvironment env;

        private readonly UserManager<User> userManager;

        public ElanController(DB dB, UserManager<User> userM, IHostingEnvironment _env)
        {
            db = dB;
            userManager = userM;
            env = _env;
        }
        public IActionResult Yarat()
        {
            ElanYaratViewModel elanYarat = new ElanYaratViewModel
            {
                BanNovleri = db.BanNovleri,
                IstehsalIllleri = db.IstehsalIlleri,
                Markalar = db.Markalar,
                MuherrikHecmleri = db.MuherrikHecmleri,
                Oturuculer = db.Oturuculer,
                Rengler = db.Rengler,
                Seherler = db.Seherler,
                SuretQutulari = db.SuretlerQutusu,
                YanacaqNovleri = db.YanacaqNovleri
            };
            ViewBag.Marka = db.Markalar;
            return View(elanYarat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Yarat(Elan elan)
        {
            ElanYaratViewModel elanYarat = new ElanYaratViewModel
            {
                BanNovleri = db.BanNovleri,
                IstehsalIllleri = db.IstehsalIlleri,
                Markalar = db.Markalar,
                MuherrikHecmleri = db.MuherrikHecmleri,
                Oturuculer = db.Oturuculer,
                Rengler = db.Rengler,
                Seherler = db.Seherler,
                SuretQutulari = db.SuretlerQutusu,
                YanacaqNovleri = db.YanacaqNovleri,
            };

            ViewBag.Marka = db.Markalar;
            if (!ModelState.IsValid)
            {
                ViewBag.Marka = db.Markalar;
                return View(elanYarat);
            }
            User user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                ViewBag.Marka = db.Markalar.OrderBy(x => x.Name);
                return View(elanYarat);
            }
            Elan _elan = new Elan
            {
                ModelId = elan.ModelId,
                BanNovuId = elan.BanNovuId,
                IstehsalIliId = elan.IstehsalIliId,
                MuherrikHecmiId = elan.MuherrikHecmiId,
                OturucuId = elan.OturucuId,
                RengId = elan.RengId,
                SeherId = elan.SeherId,
                SuretQutusuId = elan.SuretQutusuId,
                YanacaqNovuId = elan.YanacaqNovuId,
                UserId = user.Id,
                YurusMesafesi = elan.YurusMesafesi,
                YazilmaVaxti = DateTime.Now,
                Qiymet = elan.Qiymet,
                MuherrikGucu = elan.MuherrikGucu,
                Melumat = elan.Melumat,
                Vip = elan.Vip

            };
            if (elan.SekilFayllari == null)
            {

                ViewBag.Marka = db.Markalar.OrderBy(x => x.Name);
                ModelState.AddModelError("", "Zehmet olmasa sekil secin");
                return View(elanYarat);
            }
            if (elan.SekilFayllari.Count() > 5)
            {
                ViewBag.Marka = db.Markalar.OrderBy(x => x.Name);
                ModelState.AddModelError("", "Sekil sayi en cox 5 eded ola biler");
                return View(elanYarat);
            }
            db.Elanlar.Add(_elan);
            int maimgid;
            int count = 1;
            if (int.TryParse(elan.MainImageId, out maimgid))
            {

            }
            if (maimgid == 0)
            {
                maimgid = 1;
            }
            
            foreach (IFormFile img in elan.SekilFayllari)
            {
                Sekil sekil = new Sekil();
                sekil.ElanId = _elan.Id;
                sekil.Name = await img.Save(env, "images/Cars");
                db.Sekiller.Add(sekil);
                if (maimgid == count)
                {
                    _elan.SekilUrl = sekil.Name;
                }
                count++;

            }
            await db.SaveChangesAsync();
            ViewBag.Marka = db.Markalar.OrderBy(x => x.Name);
            TempData["Elan"] = true;
            return RedirectToAction("Oz", "Elan");

        }
        public async Task<IActionResult> Edit(int id)
        {

            Elan elan = await db.Elanlar.Include(x => x.Sekiller).FirstOrDefaultAsync(x => x.Id == id);
            User user = await userManager.FindByNameAsync(User.Identity.Name);
            if (elan.UserId != user.Id)
            {
                return NotFound();
            }
            Edit edit = new Edit
            {
                Id = elan.Id,
                Melumat = elan.Melumat,
                YurusMesafesi = elan.YurusMesafesi,
                Qiymet = elan.Qiymet,
                MuherrikGucu = elan.MuherrikGucu,
                MuherrikHecmiId = elan.MuherrikHecmiId,
                SeherId = elan.SeherId,
                OturucuId = elan.OturucuId,
                RengId = elan.RengId,
                SuretQutusuId = elan.SuretQutusuId,
                YanacaqNovuId = elan.YanacaqNovuId,

            };
            ElanYaratViewModel elanYarat = new ElanYaratViewModel
            {
                IstehsalIllleri = db.IstehsalIlleri,
                MuherrikHecmleri = db.MuherrikHecmleri,
                Oturuculer = db.Oturuculer,
                Rengler = db.Rengler,
                Seherler = db.Seherler,
                SuretQutulari = db.SuretlerQutusu,
                YanacaqNovleri = db.YanacaqNovleri,
                Elan = elan,
                Edit = edit

            };

            return View(elanYarat);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Edit edit)
        {
            Elan elan = db.Elanlar.Include(x => x.Sekiller)
            .Include(x => x.MuherrikHecmi).Include(x => x.Seher).Include(x => x.Oturucu)
            .Include(x => x.Reng).Include(x => x.Sekiller).Include(x => x.SuretQutusu)
            .Include(x => x.YanacaqNovu)
            .FirstOrDefault(x => x.Id == edit.Id);
            if (elan == null)
            {
                return NotFound();
            }

            ElanYaratViewModel elanYarat = new ElanYaratViewModel
            {
                IstehsalIllleri = db.IstehsalIlleri,
                MuherrikHecmleri = db.MuherrikHecmleri,
                Oturuculer = db.Oturuculer,
                Rengler = db.Rengler,
                Seherler = db.Seherler,
                SuretQutulari = db.SuretlerQutusu,
                YanacaqNovleri = db.YanacaqNovleri,
                Elan = elan,

            };

            User user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null || elan.UserId != user.Id)
            {

                return View(elanYarat);
            }


            if (!ModelState.IsValid)
            {
                ViewBag.Marka = db.Markalar;
                return View(elanYarat);
            }

            elan.MuherrikHecmiId = edit.MuherrikHecmiId;
            elan.OturucuId = edit.OturucuId;
            elan.RengId = edit.RengId;
            elan.SeherId = edit.SeherId;
            elan.SuretQutusuId = edit.SuretQutusuId;
            elan.YanacaqNovuId = edit.YanacaqNovuId;
            elan.YurusMesafesi = edit.YurusMesafesi;
            elan.YazilmaVaxti = DateTime.Now;
            elan.Qiymet = edit.Qiymet;
            elan.MuherrikGucu = edit.MuherrikGucu;
            elan.Melumat = edit.Melumat;
            if (edit.Vip)
            {
                elan.Vip = true;
            }
            int mainimage = 0;

            //Istidecinin her hansi silenecek fayl secdiyi ve sekil elave etdiyi hali
            if (edit.DeleteInput != null)
            {
                edit.DeletedPhotoId = edit.DeleteInput.Split(",").ToList();
                //var olan sekli silmesi ve.Istifadecinin teze sekil elave etmesi
                if (edit.SekilFayllari != null)
                {

                    if (elan.Sekiller.Count() - (edit.DeletedPhotoId.Count() - 1) + edit.SekilFayllari.Count() > 5 || elan.Sekiller.Count() - (edit.DeletedPhotoId.Count() - 1) + edit.SekilFayllari.Count() < 1)
                    {
                        ModelState.AddModelError("", "Sekil sayi en cox 5 eded ve en az 1 eded olmalidir");
                        edit.DeleteInput="";
                        return View(elanYarat);
                    }
                    if (edit.mainImageId != null)
                    {
                        if (int.TryParse(edit.mainImageId.Substring(1), out mainimage) && (edit.mainImageId.Contains("p")))
                        {

                        }
                    }

                    int count = 1;
                    foreach (IFormFile img in edit.SekilFayllari)
                    {
                        Sekil sekil = new Sekil();
                        sekil.ElanId = elan.Id;
                        sekil.Name = await img.Save(env, "images/Cars");
                        db.Sekiller.Add(sekil);
                        if (count == mainimage)
                        {

                            elan.SekilUrl = sekil.Name;
                        }
                        count++;

                    }
                    //silinen sekille esas seklin eyniliyi yoxlanmasi ucun bool
                    bool someimage = false;
                    int someimgid = 0;
                    foreach (var id in edit.DeletedPhotoId)
                    {
                        int ImgId;
                        if (id != "")
                        {
                            if (int.TryParse(id, out ImgId))
                            {
                                if (int.TryParse(edit.mainImageId, out mainimage))
                                {
                                    if (ImgId == mainimage)
                                    {
                                        ModelState.AddModelError("", "Esas sekil siline bilmez");
                                        return View(elanYarat);
                                    }
                                }
                                Sekil sekilDel = db.Sekiller.FirstOrDefault(x => x.Id == ImgId);

                                if (elan.Id == sekilDel.ElanId)
                                {
                                    if (sekilDel.Name.ImageHasFile("images/Cars", env))
                                    {
                                        if (elan.SekilUrl == sekilDel.Name)
                                        {
                                            someimage = true;
                                            someimgid = sekilDel.Id;

                                        }
                                        System.IO.File.Delete(Path.Combine(env.WebRootPath, "images/Cars", sekilDel.Name));
                                        db.Sekiller.Remove(sekilDel);

                                    }

                                }
                            }
                            else
                            {
                                ModelState.AddModelError("", "Sekillerin silinmesinde xeta bas verdi");
                                return View(elanYarat);
                            }
                        }

                    }
                    if (someimage)
                    {

                        elan.SekilUrl = elan.Sekiller.FirstOrDefault(x => x.Id != someimgid).Name;
                    }
                    //sava databaza

                }
                //silmemesi.istidecinin yeni sekil elave etmemesi
                else
                {
                    if (elan.Sekiller.Count() - (edit.DeletedPhotoId.Count() - 1) < 1)
                    {
                        ModelState.AddModelError("", "Sekil sayi en cox 5 eded ve en az 1 eded olmalidir");
                        edit.DeleteInput = "";
                        return View(elanYarat);
                    }
                    if (edit.mainImageId != null)
                    {
                        if (int.TryParse(edit.mainImageId, out mainimage) && !edit.mainImageId.Contains("p"))
                        {

                        }
                    }

                    //silinen sekille esas seklin eyniliyi
                    bool someimage = false;
                    int someimgid = 0;
                    foreach (var id in edit.DeletedPhotoId)
                    {
                        int ImgId;
                        if (id != "")
                        {
                            if (int.TryParse(id, out ImgId))
                            {
                                if (int.TryParse(edit.mainImageId, out mainimage))
                                {
                                    if (ImgId == mainimage)
                                    {
                                        ModelState.AddModelError("", "Esas sekil siline bilmez");
                                        return View(elanYarat);
                                    }

                                }
                                Sekil sekilDel = db.Sekiller.FirstOrDefault(x => x.Id == ImgId);

                                if (elan.Id == sekilDel.ElanId)
                                {
                                    if (sekilDel.Name.ImageHasFile("images/Cars", env))
                                    {
                                        if (elan.SekilUrl == sekilDel.Name)
                                        {
                                            someimage = true;
                                            someimgid = sekilDel.Id;

                                        }
                                        System.IO.File.Delete(Path.Combine(env.WebRootPath, "images/Cars", sekilDel.Name));

                                        db.Sekiller.Remove(sekilDel);

                                    }

                                }
                            }
                            else
                            {
                                ModelState.AddModelError("", "Sekillerin silinmesinde xeta bas verdi");
                                return View(elanYarat);
                            }
                        }

                    }
                    if (someimage)
                    {
                        elan.SekilUrl = elan.Sekiller.FirstOrDefault(x => x.Id != someimgid).Name;
                    }
                    else if (mainimage != 0)
                    {
                        Sekil sekil = db.Sekiller.FirstOrDefault(x => x.Id == mainimage);
                        elan.SekilUrl = sekil.Name;

                    }
                }

            }
            //silenecek faylin secilmediyi hal ve yeni sekillerin elave etdiyi hal
            else
            {
                if (edit.SekilFayllari != null)
                {

                    if (elan.Sekiller.Count() + edit.SekilFayllari.Count() > 5)
                    {
                        ModelState.AddModelError("", "Sekil sayi en cox 5 eded ve en az 1 eded olmalidir");
                        edit.DeleteInput = "";
                        return View(elanYarat);
                    }
                    if (edit.mainImageId != null)
                    {
                        if (int.TryParse(edit.mainImageId.Substring(1), out mainimage) && (edit.mainImageId.Contains("p")))
                        {

                        }
                    }

                    int count = 1;

                    foreach (IFormFile img in edit.SekilFayllari)
                    {
                        Sekil sekil = new Sekil();
                        sekil.ElanId = elan.Id;
                        sekil.Name = await img.Save(env, "images/Cars");
                        db.Sekiller.Add(sekil);
                        if (count == mainimage)
                        {

                            elan.SekilUrl = sekil.Name;
                        }
                        count++;

                    }

                }
                //ne sekil elave edilib nede silinib
                else
                {
                    if (edit.mainImageId != null)
                    {
                        if (int.TryParse(edit.mainImageId, out mainimage) && !edit.mainImageId.Contains("p"))
                        {

                        }
                    }

                    if (mainimage != 0)
                    {
                        Sekil sekil = db.Sekiller.FirstOrDefault(x => x.Id == mainimage);
                        elan.SekilUrl = sekil.Name;

                    }

                }

            }

            await db.SaveChangesAsync();

            TempData["yenile"] = true;

            return RedirectToAction("Oz", "Elan");

        }
        [AllowAnonymous]
        public IActionResult All(int? id)
        {
            if (id != null)
            {
                if (id == 1)
                {
                    ElanYaratViewModel model1 = new ElanYaratViewModel
                    {
                        Elanlar = db.Elanlar.Where(x => x.Register == true).Where(x => x.Vip == true).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
                    };
                    return View(model1);
                }
                else
                {
                    ElanYaratViewModel model2 = new ElanYaratViewModel
                    {
                        Elanlar = db.Elanlar.Where(x => x.Register == true).Where(x => x.Vip == false).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
                    };
                    return View(model2);
                }
            }
            else
            {
                ElanYaratViewModel model = new ElanYaratViewModel
                {
                    Elanlar = db.Elanlar.Where(x => x.Register == true).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
                };
                return View(model);
            }

        }
        [AllowAnonymous]
        public IActionResult Markalar(int id)
        {
            ElanYaratViewModel model = new ElanYaratViewModel
            {
                Elanlar = db.Elanlar.Where(x => x.Register == true).Where(x => x.Model.MarkaId == id).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
            };
            ViewBag.Name = db.Markalar.FirstOrDefault(x => x.Id == id).Name;
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Modeller(int id)
        {
            ElanYaratViewModel model = new ElanYaratViewModel
            {
                Elanlar = db.Elanlar.Where(x => x.Register == true).Where(x => x.ModelId == id).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
            };
            ViewBag.Name = db.Modeller.FirstOrDefault(x => x.Id == id).Name;
            return View(model);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Detail(int id)
        {
            Elan elan = await db.Elanlar.FirstOrDefaultAsync(x => x.Id == id);
            if (elan == null)
            {
                TempData["NotFoundCar"] = true;
                return View();
            }
            elan = await db.Elanlar.Include(x => x.Model).Include(x => x.BanNovu)
                .Include(x => x.Model.Marka).Include(x => x.IstehsalIli)
                .Include(x => x.User)
                .Include(x => x.MuherrikHecmi).Include(x => x.Seher).Include(x => x.Oturucu)
                .Include(x => x.Reng).Include(x => x.Sekiller).Include(x => x.SuretQutusu)
                .Include(x => x.YanacaqNovu).FirstOrDefaultAsync(x => x.Id == id); ;
            ElanYaratViewModel model = new ElanYaratViewModel
            {
                Elan = elan,
                Elanlar = db.Elanlar.Where(x => x.Register == true).Where(x => x.ModelId == elan.ModelId).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
            };

            return View(model);

        }
        public async Task<IActionResult> Delete(int id)
        {

            Elan elan = await db.Elanlar.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id);

            if (elan == null)
            {
                TempData["NotFoundCar"] = true;
                return RedirectToAction("Index", "Home");
            }

            User user = await userManager.FindByIdAsync(elan.User.Id);
            if (user == null || user.UserName != User.Identity.Name)
            {
                TempData["Suluq"] = true;
                return RedirectToAction("Index", "Home");
            }
            foreach (var sekil in db.Sekiller.Where(x => x.ElanId == elan.Id))
            {
                if (sekil.Name.ImageHasFile("image/Cars", env))
                {
                    sekil.Name.DeleteImage(env, "image/Cars");
                }
            }
            db.Sekiller.RemoveRange(db.Sekiller.Where(x => x.ElanId == elan.Id));
            db.Elanlar.Remove(elan);
            await db.SaveChangesAsync();
            TempData["Deleted"] = true;
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Oz()
        {
            User user = await userManager.FindByNameAsync(User.Identity.Name);
            ElanYaratViewModel model = new ElanYaratViewModel
            {

                Elanlar = db.Elanlar.Where(x => x.UserId == user.Id).Include(x => x.Model).Include(x => x.Model.Marka).Include(x => x.IstehsalIli).Include(x => x.MuherrikHecmi).Include(x => x.Seher)
            };

            return View(model);
        }
    }
}