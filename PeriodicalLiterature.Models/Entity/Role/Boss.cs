using PeriodicalLiterature.Models.AuthorizationOfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicalLiterature.Models.Entity.Role
{
    public class Boss
    {
        public Guid Id { get; set; }

        public string  Name { get; set; }

        public string SecondName { get; set; }

        public decimal  Account { get; set; }        

        /// <summary>
        /// This is the money that the company holds for subscriptions.
        /// </summary>
        public decimal FrozenMoney { get; set; }

        public ICollection<Contract> VerifiedContracts { get; set; }
        public ICollection<Contract> TerminatedContract { get; set; }

        public ICollection<AdminRegister> RegisteredAdmins { get; set; }

        public ICollection<Admin> AddedAdmins { get; set; }

        public ICollection<Admin> RemovedAdmins { get; set; }


    }
}