using PeriodicalLiterature.Models.AuthorizationOfModels;
using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers.IProviders
{
    public interface IProviderBossRepository
    {

        Boss GetPublisherById(Guid bossId);


        void AddBaseAccount(Boss boss);

        void AddedAdmin(Guid bossId, AdminRegister admin);


    }
}