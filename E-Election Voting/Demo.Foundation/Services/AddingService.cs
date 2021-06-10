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
        public void EditCandidate(ElectionCandidate electionCandidate) 
        {
            var obj = _electionUnitOfWork.CandidateRepository.GetById(electionCandidate.Id);
            obj.Mobile = electionCandidate.Mobile;
            obj.Address = electionCandidate.Address;
            obj.Description = electionCandidate.Description;
            obj.Motto = electionCandidate.Motto;
            obj.ImageUrl = electionCandidate.ImageUrl;
            obj.LogoImageUrl = electionCandidate.LogoImageUrl;
            _electionUnitOfWork.CandidateRepository.Edit(obj);
            _electionUnitOfWork.Save();
        }
        public void AddVoter(ElectionVoter electionVoter)
        {
            _electionUnitOfWork.VoterRepository.Add(electionVoter);
            _electionUnitOfWork.Save();
        }
        public void EditVoter(ElectionVoter electionVoter)
        {
            var obj = _electionUnitOfWork.VoterRepository.GetById(electionVoter.Id);
            obj.Mobile = electionVoter.Mobile;
            obj.Address = electionVoter.Address;
            obj.CoverPhotoUrl = electionVoter.CoverPhotoUrl;
            _electionUnitOfWork.VoterRepository.Edit(obj);
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
        public void EditElection(MakeElection makeElection)
        {
            var obj = _electionUnitOfWork.MakeElectionRepository.GetById(makeElection.Id);
            obj.Count1 = makeElection.Count1;
            obj.Count2 = makeElection.Count2;
            _electionUnitOfWork.MakeElectionRepository.Edit(obj);
            _electionUnitOfWork.Save();
        }
        public void AddVoterCheck(VoterCheck voterCheck)
        {
            _electionUnitOfWork.VoterCheckRepository.Add(voterCheck);
            _electionUnitOfWork.Save();
        }
        public void AddApiClass(ApiClass apiClass)
        {
            _electionUnitOfWork.ApiEntityRepository.Add(apiClass);
            _electionUnitOfWork.Save();
        }                       
    }
}