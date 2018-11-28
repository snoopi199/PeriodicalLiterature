using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers.IProviders
{
    public interface IProviderPublisherRepository
    {
        Publisher GetPublisherById(Guid publisherId);

        bool PublisherContains(Guid publisherId);
        void AddBaseAccount(Guid publisherId);
    }
}