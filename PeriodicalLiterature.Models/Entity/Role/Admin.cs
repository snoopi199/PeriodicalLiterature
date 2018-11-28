using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models.Entity.Role
{
    public class Admin
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }

        public ICollection<Contract> VerifiedContracts { get; set; }

        public ICollection<Edition> VerifiedEditions { get; set; }

    }
}