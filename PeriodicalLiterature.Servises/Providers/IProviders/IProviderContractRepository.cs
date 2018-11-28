using PeriodicalLiterature.Models;
using PeriodicalLiterature.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers.IProviders
{
    public interface IProviderContractRepository
    {
        void CreateNewContrarct(ContractView contract);
        IEnumerable<Contract> GetContractByStatus(string status);
    }
}