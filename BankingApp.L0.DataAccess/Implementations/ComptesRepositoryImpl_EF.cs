using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Facade;
using BankingApp.L0.DataAccess.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.DataAccess.Implementations
{
    public class ComptesRepositoryImpl_EF : IComptesRepository
    {
        public void Create(Compte c)
        {
            using (var ctxt = new BankingContext())
            {
                ctxt.Comptes.Add(c);
                ctxt.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (var ctxt = new BankingContext())
            {
                ctxt.Comptes.Remove(ctxt.Comptes.Find(id));
                ctxt.SaveChanges();
            }
        }

        public IEnumerable<Compte> FindAll()
        {
            using (var ctxt = new BankingContext())
            {
                return ctxt.Comptes.ToList();
            }
        }

        public Compte FindById(string id)
        {
            using (var ctxt = new BankingContext())
            {
                return ctxt.Comptes.Find(id);
            
            }
            
        }

        public void Update(Compte c)
        {
            throw new NotImplementedException();
        }
    }
}
