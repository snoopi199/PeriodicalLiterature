using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.DAL.Repository
{
    public class EditionRepository: IEditionRepository
    {
        private readonly ApplicationContext _context;
        public EditionRepository(ApplicationContext context) => _context = context;

        public IQueryable<Edition> Query
        {
            get { return _context.Set<Edition>(); }
        }

        public void Add(Edition entity)
        {
            _context.Editions.Add(entity);
        }

        public void Delete(Edition entity)
        {
            _context.Editions.Remove(entity);
        }

        public List<Edition> FetchAll()
        {
            return Query.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}