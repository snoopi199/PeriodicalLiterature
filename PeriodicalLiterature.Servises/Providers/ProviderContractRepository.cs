using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models;
using PeriodicalLiterature.Models.Entity;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers
{
    public class ProviderContractRepository: IProviderContractRepository
    {
        IContractRepository _context;

        public ProviderContractRepository(IContractRepository contractRepository)
        {
            _context = contractRepository;
        }
        public void CreateNewContrarct(ContractView contract)
        {
            _context.Add(Maper.ContractViewToContract(contract));
            _context.Save();
        }

        public IEnumerable<Contract> GetContractByStatus(string status) => _context.Query.Where(x => x.Status == status);
    }
}