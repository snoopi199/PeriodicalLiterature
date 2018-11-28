using PeriodicalLiterature.Models;
using System;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using System.IO;
using PeriodicalLiterature.Servises.Providers.IProviders;
using PeriodicalLiterature.Models.Entity;
using PeriodicalLiterature.Servises;

namespace PeriodicalLiterature.Web.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IProviderContractRepository providerContract;
        private readonly IProviderPublisherRepository providerPublisher;
        public PublisherController(IProviderContractRepository providerContract, IProviderPublisherRepository providerPublisher)
        {
            this.providerContract = providerContract;
            this.providerPublisher = providerPublisher;
        }


        [Authorize(Roles = "Publisher")]
        public ActionResult Index()
        {
            return View();
        }


        [Authorize(Roles = "Publisher")]
        public ActionResult MyAccount()
        {
            return View(providerPublisher.GetPublisherById(new Guid(User.Identity.GetUserId())));
        }


        [Authorize(Roles = "Publisher")]
        public ActionResult ComposeContract()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Publisher")]
        public ActionResult ComposeContract(ContractView contractView)
        {           
            if (ModelState.IsValid)
            {
                if (contractView.Genre.Count == 0)
                {
                    ModelState.AddModelError("", "Выберете один или несколько жанров");
                }                

                var extensionCover = Path.GetExtension(contractView.Cover.FileName);
                if(!(extensionCover == ".png" || extensionCover == ".jpg"))
                {
                    ModelState.AddModelError("", "Ошибка. Допустимые расширения файлов для обложки - '.png', '.jpg'");
                    return View(contractView);
                }
                
                var extensionFile = Path.GetExtension(contractView.File.FileName);
                if (extensionFile != ".pdf")
                {
                    ModelState.AddModelError("", "Ошибка. Допустимые расширения для файла - '.pdf'");
                    return View(contractView);
                }

                var contract = Maper.ContractViewToContract(contractView);

                contract.Id = Guid.NewGuid();
                contract.PublisherId = new Guid(User.Identity.GetUserId());
                contract.CoverId = Guid.NewGuid();
                contract.FileId = Guid.NewGuid();

                var publisher = providerPublisher.GetPublisherById(contract.PublisherId);
           
                var fileName = contract.FileId.ToString() + extensionFile;
                contractView.File.SaveAs(Server.MapPath("../Uploads/" + fileName));

                var coverName = contract.CoverId.ToString() + extensionCover;
                contractView.File.SaveAs(Server.MapPath("../Uploads/" + coverName));

                
      
                providerContract.CreateNewContrarct(contractView);

                return View("Announcement", new ContractResult { Message = "Контракт передан в обработку", Contract = contractView });
            }

            return View(contractView);
        }
    }
}