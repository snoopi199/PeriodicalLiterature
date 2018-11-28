using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers.IProviders
{
    public interface IProviderAdminRepository
    {
        Admin GetPublisherById(Guid adminId);

        void AddBaseAccount(Admin admin);
        
    }
}