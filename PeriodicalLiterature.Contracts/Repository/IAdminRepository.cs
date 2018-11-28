using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Contracts.Repository
{
    public interface IAdminRepository
    {
        List<Admin> FetchAll();
        IQueryable<Admin> Query { get; }
        void Add(Admin entity);
        void Delete(Admin entity);
        void Save();
    }
}