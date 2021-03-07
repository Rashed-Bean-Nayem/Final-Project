using Demo.Foundation.Entities;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class AddingService : IAddingService
    {
        private readonly IRegistrationUnitOfWork _registrationUnitOfWork;
        private readonly IElectionUnitOfWork _electionUnitOfWork; 
        public AddingService(IRegistrationUnitOfWork registrationUnitOfWork,
                             IElectionUnitOfWork electionUnitOfWork) 
        {
            _registrationUnitOfWork = registrationUnitOfWork;
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
    }
}