using BankingApp.L0.DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.DataAccess.Facade
{
    public interface IComptesRepository
    {
        //CRUD Contract

        void Create(Compte c);

        Compte FindById(string id);

        IEnumerable<Compte> FindAll();

        void Update(Compte c);

        void Delete(string id);
    }
}
