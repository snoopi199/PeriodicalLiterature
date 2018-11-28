using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models.Entity
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public Guid From{ get; set; }

    }
}