using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.DAL.Repository
{
    public class AdminRepository:IAdminRepository
    {
        private readonly ApplicationContext _context;
        public AdminRepository (ApplicationContext context) => _context = context;

        public IQueryable<Admin> Query
        {
            get { return _context.Set<Admin>(); }
        }

        public void Add(Admin entity)
        {
            _context.Admins.Add(entity);
        }

        public void Delete(Admin entity)
        {
            _context.Admins.Remove(entity);
        }

        public List<Admin> FetchAll()
        {
            return Query.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}