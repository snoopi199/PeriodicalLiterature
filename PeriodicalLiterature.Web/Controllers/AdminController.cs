using PeriodicalLiterature.Models;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeriodicalLiterature.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProviderContractRepository providerContract;
       
        public AdminController(IProviderContractRepository providerContract)
        {
            this.providerContract = providerContract;
       
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


       

        public ActionResult Contract()
        {
            var contracts = providerContract.GetContractByStatus(Status.FirstStageVerification);
            return View(contracts);
        }
    }
}