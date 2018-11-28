using PeriodicalLiterature.Servises.Providers.IProviders;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeriodicalLiterature.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProviderPublisherRepository providerPublisher;

        public HomeController(IProviderPublisherRepository providerPublisher)
        {
            this.providerPublisher = providerPublisher;
        }

        public ActionResult Index()
        {
            if (User.IsInRole("Boss"))
                return RedirectToAction("Index", "Boss");
            if (User.IsInRole("Admin"))
                return RedirectToAction("Index", "Admin");
            if (User.IsInRole("Publisher"))
            {
                var PublisherId = new Guid(User.Identity.GetUserId());

                if (!providerPublisher.PublisherContains(PublisherId))
                    providerPublisher.AddBaseAccount(PublisherId);

                return RedirectToAction("Index", "Publisher");
            }
               
            if (User.IsInRole("User"))
                return RedirectToAction("Index", "User");
            return View();
        }


       

    }
}