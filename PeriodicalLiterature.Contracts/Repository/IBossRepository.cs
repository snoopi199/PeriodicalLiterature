using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Contracts.Repository
{
    public interface IBossRepository
    {
        List<Boss> FetchAll();
        IQueryable<Boss> Query { get; }
        void Add(Boss entity);
        void Delete(Boss entity);
        void Save();
    }
}