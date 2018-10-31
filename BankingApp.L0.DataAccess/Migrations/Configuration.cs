namespace BankingApp.L0.DataAccess.Migrations
{
    using BankingApp.L0.DataAccess.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BankingApp.L0.DataAccess.Infrastructures.BankingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankingApp.L0.DataAccess.Infrastructures.BankingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Comptes.AddOrUpdate(new Compte { Numero = "c1000", Proprietaire="Imen" , Solde=5000M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "c2000", Proprietaire = "Ons", Solde = 3000M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "c3000", Proprietaire = "Syrine", Solde = 2000M });
            context.Comptes.AddOrUpdate(new Compte { Numero = "c4000", Proprietaire = "Elyne", Solde = 1000M });
        }
    }
}
