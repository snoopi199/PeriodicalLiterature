using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.DAL.Repository
{
    public class ContractRepository: IContractRepository
    {
        private readonly ApplicationContext _context;
        public ContractRepository(ApplicationContext context) => _context = context;

        public IQueryable<Contract> Query
        {
            get { return _context.Set<Contract>(); }
        }

        public void Add(Contract entity)
        {
            _context.Contracts.Add(entity);
        }

        public void Delete(Contract entity)
        {
            _context.Contracts.Remove(entity);
        }

        public List<Contract> FetchAll()
        {
            return Query.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}