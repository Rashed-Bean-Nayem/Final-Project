using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.UnitOfworks
{
    public class RegistrationUnitOfWork : UnitOfWork, IRegistrationUnitOfWork
    {
        public ICandidateRepository CandidateRepository { get; set; }
        public IVoterRepository VoterRepository { get; set; }
        public IRegistrationRepository RegistrationRepository { get; set; }
        public IMakeElectionRepository MakeElectionRepository { get; set; }
        public IVoterCheckRepository VoterCheckRepository { get; set; }
        public IApiEntityRepository ApiEntityRepository { get; set; }

        public RegistrationUnitOfWork(RegistrationContext context,
            ICandidateRepository candidateRepository,
            IVoterRepository voterRepository, 
            IRegistrationRepository registrationRepository,
            IMakeElectionRepository makeElectionRepository,
            IVoterCheckRepository voterCheckRepository,
            IApiEntityRepository apiEntityRepository)
            : base(context)
        {
            CandidateRepository = candidateRepository;
            VoterRepository = voterRepository;
            RegistrationRepository = registrationRepository;
            MakeElectionRepository = makeElectionRepository;
            VoterCheckRepository = voterCheckRepository;
            ApiEntityRepository = apiEntityRepository;
        }
    }
}
