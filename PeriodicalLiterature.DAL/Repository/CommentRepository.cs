using PeriodicalLiterature.Contracts.Repository;
using PeriodicalLiterature.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.DAL.Repository
{
    public class CommentRepository:ICommentRepository
    {
        private readonly ApplicationContext _context;
        public CommentRepository(ApplicationContext context) => _context = context;

        public IQueryable<Comment> Query
        {
            get { return _context.Set<Comment>(); }
        }

        public void Add(Comment entity)
        {
            _context.Comments.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _context.Comments.Remove(entity);
        }

        public List<Comment> FetchAll()
        {
            return Query.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}