using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.AuthorizationOfModels;
using PeriodicalLiterature.Models.Entity.Role;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers
{
    public class ProviderBossRepository: IProviderBossRepository
    {
        IBossRepository _context;

        public ProviderBossRepository(IBossRepository bossRepository)
        {
            _context = bossRepository;
        }

        public ProviderBossRepository()
        {
        }

        

        public Boss GetPublisherById(Guid bossId)
        {
            return _context.Query.FirstOrDefault(x => x.Id == bossId);
        }

        public void AddBaseAccount(Boss boss)
        {
            _context.Add(boss);
            _context.Save();
        }

        public void AddedAdmin(Guid bossId, AdminRegister admin)
        {
            _context.Query.FirstOrDefault(x => x.Id == bossId).RegisteredAdmins.Add(admin);
            _context.Save();
        }
    }
}