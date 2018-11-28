using System;
using System.Collections.Generic;



namespace PeriodicalLiterature.Models.Entity.Role
{
    public class Publisher
    {
        
        public Guid Id { get; set; }

        public string PublisherName { get; set; }

        public ICollection<Contract> Contracts { get; set; }

        public decimal Account { get; set; }

        public decimal PlannedAccount { get; set; }

        public Publisher()
        {
            Contracts = new List<Contract>();
        }
    }
}