using BankingApp.L0.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.DataAccess.Infrastructures
{
    public class BankingContext : DbContext
    {
        public BankingContext() : base ("name=bankingdb")
        {

        }
        public virtual DbSet<Compte> Comptes { get; set; }
    }
}
