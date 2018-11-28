using PeriodicalLiterature.Models.Entity;
using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;

namespace PeriodicalLiterature.Models.Entity
{
    public class Edition
    {
        public Guid Id { get; set; }

        public string Status { get; set; }
        
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }

        //public User Bought { get; set; }

        public decimal Cost { get; set; }

        public DateTime DateOfIssue { get; set; }

        public byte Number { get; set; }
        public string DescriptionNumber { get; set; }

        public int Pages { get; set; }

        public Guid PictureId { get; set; }
        public Guid FileId { get; set; }

        public double Rating { get; set; }

        public uint Readership { get; set; }

        public ICollection<Comment> Comments { get; set; }      
    }
}