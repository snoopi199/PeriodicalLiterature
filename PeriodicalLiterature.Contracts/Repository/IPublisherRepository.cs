using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Contracts.Repository
{
    public interface IPublisherRepository
    {
        List<Publisher> FetchAll();
        IQueryable<Publisher> Query { get; }
        void Add(Publisher entity);
        void Delete(Publisher entity);
        void Save();
    }
}