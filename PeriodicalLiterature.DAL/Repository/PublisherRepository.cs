using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;


namespace PeriodicalLiterature.DAL.Repository
{
    public class PublisherRepository: IPublisherRepository
    {
        private readonly ApplicationContext _context;
        public PublisherRepository(ApplicationContext context) => _context = context;

        public IQueryable<Publisher> Query
        {
            get
            {
                return _context.Set<Publisher>();

            }
        }

        public void Add(Publisher entity)
        {
            _context.Publishers.Add(entity);
        }

        public void Delete(Publisher entity)
        {
            _context.Publishers.Remove(entity);
        }

        public List<Publisher> FetchAll()
        {
            return Query.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}