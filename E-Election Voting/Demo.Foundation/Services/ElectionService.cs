using Demo.Foundation.Entities;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class ElectionService : IElectionService
    {
        private readonly IElectionUnitOfWork _electionUnitOfWork; 
        public ElectionService(IElectionUnitOfWork shopingUnitOfWork)
        {
            _electionUnitOfWork = shopingUnitOfWork;
        }

        public IList<ElectionCandidate> GetCandidates() 
        {
            return _electionUnitOfWork.CandidateRepository.GetAll();
        }
        public void AddCandidate(ElectionCandidate electionCandidate)
        {
            _electionUnitOfWork.CandidateRepository.Add(electionCandidate);
            _electionUnitOfWork.Save();
        }

        public IList<ElectionVoter> GetVoters()
        {
            return _electionUnitOfWork.VoterRepository.GetAll(); 
        }

        public void AddVoter(ElectionVoter electionVoter)
        {
            _electionUnitOfWork.VoterRepository.Add(electionVoter);
            _electionUnitOfWork.Save();
        }
    }
}
