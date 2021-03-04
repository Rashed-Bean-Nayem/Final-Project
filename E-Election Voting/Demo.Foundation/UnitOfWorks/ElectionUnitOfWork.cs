using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.UnitOfworks
{
    public class ElectionUnitOfWork : UnitOfWork, IElectionUnitOfWork
    {
        public IVoterRepository VoterRepository { get; set; }
        public ICandidateRepository CandidateRepository { get; set; }
        public ElectionUnitOfWork(ElectionContext context, 
            IVoterRepository productRepositroy,
            ICandidateRepository categoryRepository
            )
            : base(context)
        {
            VoterRepository = productRepositroy;
            CandidateRepository = categoryRepository;
        }
    }
}
//