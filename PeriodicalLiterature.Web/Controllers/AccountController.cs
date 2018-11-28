using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using PeriodicalLiterature.Models.AuthorizationOfModels;
using PeriodicalLiterature.Servises.Authorization;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PeriodicalLiterature.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IProviderBossRepository providerBoss;
       
        private ApplicationUserManager UserManager
        {
            get => HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();  
        }

        private IAuthenticationManager AuthenticationManager
        {
            get => HttpContext.GetOwinContext().Authentication;           
        }
         
        public AccountController(IProviderBossRepository providerBoss)
        {
            this.providerBoss = providerBoss;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(Register model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser { UserName = model.Email, Email = model.Email};

                IdentityResult result = await UserManager.CreateAsync(user, model.Password);
                
                await UserManager.AddToRoleAsync(user.Id, model.Role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }
            return View(model);
        }


        public ActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Login model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await UserManager.FindAsync(model.Email, model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Неверный логин или пароль.");
                }
                else
                {
                    ClaimsIdentity claim = await UserManager.CreateIdentityAsync(user,
                                            DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignOut();
                    AuthenticationManager.SignIn(new AuthenticationProperties
                    {
                        IsPersistent = true
                    }, claim);
                    if (String.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return Redirect(returnUrl);
                }
            }
            ViewBag.returnUrl = returnUrl;
            return View(model);
        }


        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }



        //[HttpGet]
        //public ActionResult Delete()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ActionName("Delete")]
        //public async Task<ActionResult> DeleteConfirmed()
        //{
        //    ApplicationUser user = await UserManager.FindByEmailAsync(User.Identity.Name);
        //    if (user != null)
        //    {
        //        IdentityResult result = await UserManager.DeleteAsync(user);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Logout", "Account");
        //        }
        //    }
        //    return RedirectToAction("Index", "Home");
        //}

        //private ApplicationRoleManager RoleManager
        //{
        //    get
        //    {
        //        return HttpContext.GetOwinContext().GetUserManager<ApplicationRoleManager>();

        //    }
        //}
        //public async Task<ActionResult> Role()
        //{
        //    await RoleManager.CreateAsync(new ApplicationRole
        //    {
        //        Name = "User"

        //    });
        //    await RoleManager.CreateAsync(new ApplicationRole
        //    {
        //        Name = "Publisher"

        //    });
        //    await RoleManager.CreateAsync(new ApplicationRole
        //    {
        //        Name = "Admin"

        //    });
        //    await RoleManager.CreateAsync(new ApplicationRole
        //    {
        //        Name = "Boss"
        //    });
        //    return RedirectToAction("Index", "Home");

        //}
        //public async Task<ActionResult> Edit()
        //{
        //    ApplicationUser user = await UserManager.FindByEmailAsync(User.Identity.Name);
        //    if (user != null)
        //    {
        //        EditUser model = new EditUser { Year = user.Year };
        //        return View(model);
        //    }
        //    return RedirectToAction("Login", "Account");
        //}

        //    [HttpPost]
        //    public async Task<ActionResult> Edit(EditUser model)
        //    {
        //        ApplicationUser user = await UserManager.FindByEmailAsync(User.Identity.Name);
        //        if (user != null)
        //        {
        //            user.Year = model.Year;
        //            IdentityResult result = await UserManager.UpdateAsync(user);
        //            if (result.Succeeded)
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Что-то пошло не так");
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Пользователь не найден");
        //        }

        //        return View(model);
        //    }
        //public async Task<ActionResult> RegisterBoss()
        //{
        //    ApplicationUser user = new ApplicationUser { UserName = "boss@gmail.com", Email = "boss@gmail.com" };
        //    IdentityResult result = await UserManager.CreateAsync(user,"qwekl011");
        //    await UserManager.AddToRoleAsync(user.Id, "Boss");
        //    var boss = new Boss()
        //    {
        //        Account = 0,
        //        Id = new Guid(user.Id),
        //        FrozenMoney = 0,
        //        Name = "Дмитрий",
        //        SecondName = "Орхипенко"
        //    };
        //    providerBoss.AddBaseAccount(boss);

        //    return RedirectToAction("Index", "Home");
        //}
    }
}