﻿using Demo.Foundation.Entities;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class GetService : IGetService
    {
        private readonly IRegistrationUnitOfWork _registrationUnitOfWork;

        public GetService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }

        public IList<ElectionVoter> GetVoterList()  
        {
            return _registrationUnitOfWork.VoterRepository.GetAll();
        }
        public IList<ElectionCandidate> GetCandidateList()  
        {
            return _registrationUnitOfWork.CandidateRepository.GetAll();
        }        
        public void RemoveAllData(ElectionRegistration studentRegistration)
        {
            _registrationUnitOfWork.RegistrationRepository.Remove(studentRegistration);
        }
        public IList<ElectionVoter> GetVoter(string userId)
        {
            return _registrationUnitOfWork.VoterRepository.Get(option => option.UserId == userId);
        }

        public ElectionCandidate GetElectionCandidate(int id) 
        { 
            return _registrationUnitOfWork.CandidateRepository.GetById(id); 
        }
        public IList<MakeElection> GetMakeElectionList() 
        {
            return _registrationUnitOfWork.MakeElectionRepository.GetAll(); 
        }
        public MakeElection GetSingleMakeElection(int id)
        {
            return _registrationUnitOfWork.MakeElectionRepository.GetById(id);
        }

        public ElectionCandidate GetSingleElectionCandidate(int id)
        {
            return _registrationUnitOfWork.CandidateRepository.GetById(id);
        }
    }
}
