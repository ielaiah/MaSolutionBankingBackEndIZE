using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Facade;
using BankingApp.L0.DataAccess.Implementations;
using BankingApp.L1.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.Business.Implementations
{
    public class ComptesBusinessImpl : IComptesBusiness
    {
        private IComptesRepository repository; //= new ComptesRepositoryImpl_EF();

        public ComptesBusinessImpl(IComptesRepository repository)
        {
            this.repository = repository;
        }

        public decimal? ConsulterSolde(string numero)
        {
            var resultat = repository.FindById(numero);
            return resultat?.Solde;
        }

        public IEnumerable<Compte> TousLesComptes()
        {
            return repository.FindAll();
        }
    }
}
