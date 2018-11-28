using PeriodicalLiterature.Models.Entity.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models.Entity
{
    public class Contract
    {
        public Guid Id { get; set; }

        public Guid PublisherId { get; set; }
        //public Publisher Publisher { get; set; }

        public string Status { get; set; }
        //first stage verification
        //second stage verification
        //canceled
        //confirmed

        public string Answer { get; set; }

        public string TitleEdition { get; set; }

        public string Category { get; set; }
        //magazine
        //newspaper

        public string Language { get; set; }
        //ru
        //uk
        //en
        
        public ICollection<string> Genre { get; set; }

        public string DescriptionEdition { get; set; }

        public string Periodical { get; set; }

        public decimal PriceForNewRelease { get; set; }

        public decimal PriceForOldRelease { get; set; }

        public Guid FileId { get; set; }

        public Guid CoverId { get; set; }

        public ICollection<Edition> Editions { get; set; }
       

        public Contract()
        {
            
            Genre = new List<string>();
            Editions = new List<Edition>();
        }
    }
}