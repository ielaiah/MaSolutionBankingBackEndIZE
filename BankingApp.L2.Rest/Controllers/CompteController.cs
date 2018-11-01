using BankingApp.L0.DataAccess.Domain;
using BankingApp.L1.Business.Facade;
using BankingApp.L1.Business.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BankingApp.L2.Rest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CompteController : ApiController
    {

        private IComptesBusiness business;// = new ComptesBusinessImpl();

        public CompteController(IComptesBusiness business)
        {
            this.business = business;
        }
        // GET api/comptes
        public IEnumerable<Compte> Get()
        {
            return business.TousLesComptes();
        }
    }
}
