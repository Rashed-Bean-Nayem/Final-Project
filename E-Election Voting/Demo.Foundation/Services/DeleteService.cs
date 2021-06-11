using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class DeleteService:IDeleteService
    {
        private readonly IElectionUnitOfWork _electionUnitOfWork;
        public DeleteService(IElectionUnitOfWork electionUnitOfWork)
        {
            _electionUnitOfWork = electionUnitOfWork;
        }
        public void DeleteSingleElection(int id)
        {
            _electionUnitOfWork.MakeElectionRepository.Remove(id);
            _electionUnitOfWork.Save();
        }
        public void DeleteSingleCandidate(int id) 
        {
            _electionUnitOfWork.CandidateRepository.Remove(id);
            _electionUnitOfWork.Save();
        }
    }
}
