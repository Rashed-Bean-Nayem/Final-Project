﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Demo.Foundation.Contexts;
using Demo.DataAccessLayer;
using Demo.Foundation.Entities;

namespace Demo.Foundation.Repositories
{
    public class VoterRepository : Repository<ElectionVoter, int, ElectionContext>, IVoterRepository
    {
        public VoterRepository(ElectionContext dbContext)
            : base(dbContext)
        {

        }
        public IList<ElectionVoter> GetLatestVoterRepository() 
        {
            throw new NotImplementedException();
        }
    }
}
