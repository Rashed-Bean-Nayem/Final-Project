using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public class VoterCheckRepository : Repository<VoterCheck, int, RegistrationContext>, IVoterCheckRepository
    {
        public VoterCheckRepository(RegistrationContext dbContext)
            : base(dbContext)
        {
             
        }
        public IList<VoterCheck> GetLatestVoterCheck()
        {
            throw new NotImplementedException();
        }
    }
}
