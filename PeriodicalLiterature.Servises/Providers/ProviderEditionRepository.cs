using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers
{
    public class ProviderEditionRepository: IProviderEditionRepository
    {
        IEditionRepository _context;

        public ProviderEditionRepository(IEditionRepository editionRepository)
        {
            _context = editionRepository;
        }


    }
}