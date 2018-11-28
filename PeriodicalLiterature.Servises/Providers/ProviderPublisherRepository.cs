using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity;
using PeriodicalLiterature.Models.Entity.Role;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers
{
    public class ProviderPublisherRepository: IProviderPublisherRepository
    {
        IPublisherRepository _context;

        public ProviderPublisherRepository(IPublisherRepository publisherRepository)
        {
            _context = publisherRepository;
        }

        public ProviderPublisherRepository()
        {
        }

        public bool PublisherContains(Guid publisherId)
        {
            var publisher = _context.Query.FirstOrDefault(x=>x.Id == publisherId);
            if (publisher == null)
                return false;
            return true;
        }

        public Publisher GetPublisherById(Guid publisherId)
        {
            return _context.Query.FirstOrDefault(x => x.Id == publisherId);
        }

        public void AddBaseAccount(Guid publisherId)
        {
            _context.Add(new Publisher { Id = publisherId, Account = 0, PlannedAccount = 0 });
            _context.Save();
        }


        public void AddContract(Guid publisherId, Contract contract)
        {
            _context.Query.FirstOrDefault(x => x.Id == publisherId).Contracts.Add(contract);
            _context.Save();
        }
    }
}