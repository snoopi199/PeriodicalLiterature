using PeriodicalLiterature.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Contracts.Repository
{
    public interface ICommentRepository
    {
        List<Comment> FetchAll();
        IQueryable<Comment> Query { get; }
        void Add(Comment entity);
        void Delete(Comment entity);
        void Save();
    }
}