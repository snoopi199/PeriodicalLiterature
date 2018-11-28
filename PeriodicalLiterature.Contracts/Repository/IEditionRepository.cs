using PeriodicalLiterature.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicalLiterature.Contracts.Repository
{
    public interface IEditionRepository
    {
        List<Edition> FetchAll();
        IQueryable<Edition> Query { get; }
        void Add(Edition entity);
        void Delete(Edition entity);
        void Save();
    }
}
