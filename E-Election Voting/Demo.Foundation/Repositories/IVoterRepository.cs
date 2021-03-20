using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public interface IVoterRepository : IRepository<ElectionVoter, int, RegistrationContext>
    {
        IList<ElectionVoter> GetLatestVoterRepository(); 
    } 
}
