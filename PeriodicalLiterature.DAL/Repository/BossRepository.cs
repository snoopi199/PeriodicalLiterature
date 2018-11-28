using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.DAL.Repository
{
    public class BossRepository:IBossRepository
    {
        private readonly ApplicationContext _context;
        public BossRepository(ApplicationContext context) => _context = context;

        public IQueryable<Boss> Query
        {
            get { return _context.Set<Boss>(); }
        }

        public void Add(Boss entity)
        {
            _context.Bosses.Add(entity);
        }

        public void Delete(Boss entity)
        {
            _context.Bosses.Remove(entity);
        }

        public List<Boss> FetchAll()
        {
            return Query.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}