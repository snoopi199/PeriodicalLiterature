using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity.Role;
using PeriodicalLiterature.Servises.Providers.IProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Servises.Providers
{
    public class ProviderAdminRepository:IProviderAdminRepository
    {
        IAdminRepository _context;

        public ProviderAdminRepository(IAdminRepository adminRepository)
        {
            _context = adminRepository;
        }

        public ProviderAdminRepository()
        {
        }



        public Admin GetPublisherById(Guid adminId)
        {
            return _context.Query.FirstOrDefault(x => x.Id == adminId);
        }

        public void AddBaseAccount(Admin admin)
        {
            _context.Add(admin);
            _context.Save();
        }
    }
}