using PeriodicalLiterature.Models;
using PeriodicalLiterature.Models.Entity;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises
{
    public class Maper
    {
        public static Contract ContractViewToContract(ContractView contractView)
        {
            var contract = new Contract()
            {             
                Category = contractView.Category,
                DescriptionEdition = contractView.DescriptionEdition,
                PriceForNewRelease = contractView.PriceForNewRelease,
                Genre = contractView.Genre,
                Language = contractView.Language,
                Periodical = contractView.Periodical,                         
                Status = Status.FirstStageVerification,
                TitleEdition = contractView.TitleEdition       
            };
            return contract;
        }
    }
}