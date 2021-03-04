﻿using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public class CandidateRepository : Repository<ElectionCandidate, int, ElectionContext>, ICandidateRepository
    {
        public CandidateRepository(ElectionContext dbContext)
            : base(dbContext)
        {

        }

        public IList<ElectionCandidate> GetLatestElectionCandidate() 
        {
            throw new NotImplementedException();
        }
    }
}
