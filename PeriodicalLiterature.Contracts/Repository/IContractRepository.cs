using PeriodicalLiterature.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Contracts.Repository
{
    public interface IContractRepository
    {
        List<Contract> FetchAll();
        IQueryable<Contract> Query { get; }
        void Add(Contract entity);
        void Delete(Contract entity);
        void Save();
    }
}