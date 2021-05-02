using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public class MakeElectionRepository : Repository<MakeElection, int, RegistrationContext>, IMakeElectionRepository
    {
        public MakeElectionRepository(RegistrationContext dbContext)
            : base(dbContext)
        {

        }

        public IList<MakeElection> GetLatestMakeElection() 
        {
            throw new NotImplementedException();
        }
    }
}
