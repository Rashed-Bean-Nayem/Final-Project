using Demo.Foundation.Entities;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class AddingService : IAddingService
    {        
        private readonly IElectionUnitOfWork _electionUnitOfWork; 
        public AddingService(IElectionUnitOfWork electionUnitOfWork) 
        {
            _electionUnitOfWork = electionUnitOfWork;
        }

        public void AddCandidate(ElectionCandidate electionCandidate) 
        { 
            _electionUnitOfWork.CandidateRepository.Add(electionCandidate);
            _electionUnitOfWork.Save();
        }
        public void AddVoter(ElectionVoter electionVoter) 
        {
            _electionUnitOfWork.VoterRepository.Add(electionVoter);
            _electionUnitOfWork.Save();
        }
        public void AddRegistration(ElectionRegistration electionRegistration)
        {
            _electionUnitOfWork.RegistrationRepository.Add(electionRegistration);
            _electionUnitOfWork.Save();
        }

        public void AddElection(MakeElection makeElection)
        {
            _electionUnitOfWork.MakeElectionRepository.Add(makeElection);
            _electionUnitOfWork.Save();
        }
    }
}