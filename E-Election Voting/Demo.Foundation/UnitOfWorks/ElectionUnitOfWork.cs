﻿using Demo.DataAccessLayer;
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
        public IRegistrationRepository RegistrationRepository { get; set; }
        public IMakeElectionRepository MakeElectionRepository { get; set; }
        public IVoterCheckRepository VoterCheckRepository { get; set; }

        public ElectionUnitOfWork(RegistrationContext context, 
            IVoterRepository productRepositroy,
            ICandidateRepository categoryRepository,
            IRegistrationRepository registrationRepository,
            IMakeElectionRepository makeElectionRepository,
            IVoterCheckRepository voterCheckRepository
            )
            : base(context)
        {
            VoterRepository = productRepositroy;
            CandidateRepository = categoryRepository;
            RegistrationRepository= registrationRepository;
            MakeElectionRepository = makeElectionRepository;
            VoterCheckRepository = voterCheckRepository;
        }
    }
}