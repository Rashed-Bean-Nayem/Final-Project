using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Demo.Web.Areas.Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class IndexModel
    {
        private readonly IAddingService _addingService;
        private readonly IGetService _getService;
        
        public IndexModel(IAddingService addingService,
            IGetService getService)
        {
            _addingService = addingService;
            _getService = getService;
        }

        public void AddModelCandidate(ElectionCandidateData electionCandidateData)
        {
            _addingService.AddCandidate(new ElectionCandidate
            {
                 Name= electionCandidateData.Name,
                 Address=electionCandidateData.Address,
                 Description=electionCandidateData.Description,
                 Mobile= electionCandidateData.Mobile,
                 NID= electionCandidateData.NID,
                 ImageUrl=electionCandidateData.ImageUrl
            });
        }
        public void AddModelVoter(ElectionVoterData electionVoterData) 
        {
            _addingService.AddVoter(new ElectionVoter
            {
                 Name=electionVoterData.Name,
                 Address=electionVoterData.Address,
                 Mobile=electionVoterData.Mobile,
                 NID=electionVoterData.NID,
                 DateOfBirth=electionVoterData.DateOfBirth
            });
        }

        public void AddModelRegistration(RegistrationData registrationData)
        {
            _addingService.AddRegistration(new ElectionRegistration
            {

                VoterId = registrationData.VoterId,
                CandidateId = registrationData.CandidateId,
                EnrollDate = registrationData.EnrollDate,
                IsPaymentComplete = registrationData.IsPaymentComplete
            });
        }

        public void DeleteAllData(ElectionRegistration studentRegistration)
        {
            _getService.RemoveAllData(studentRegistration);
        }
    }
}
