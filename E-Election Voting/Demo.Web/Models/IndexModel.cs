using Demo.Foundation.BusinessObjects;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Demo.Web.Areas.Admin.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class IndexModel:BaseModel
    {
        private readonly IAddingService _addingService;
        private readonly IGetService _getService;
        
        public IndexModel(IAddingService addingService,
            IGetService getService)
        {
            _addingService = addingService;
            _getService = getService;
        }

        public void AddModelCandidate(ElectionCandidateDataBO electionCandidateData)
        {
            _addingService.AddCandidate(new ElectionCandidate
            {
                Name = electionCandidateData.Name,
                Address = electionCandidateData.Address,
                Description = electionCandidateData.Description,
                Mobile = electionCandidateData.Mobile,
                NID = electionCandidateData.NID,
                ImageUrl= ImagePath(electionCandidateData.ImageFile)
            });            
        }

        private string ImagePath(IFormFile ImageFile)
        {
            var imageInfo = StoreFile(ImageFile);
            var Location = imageInfo.filePath;
            return Location;
        }

        public void AddModelVoter(ElectionVoterDataBO electionVoterData) 
        {
            _addingService.AddVoter(new ElectionVoter
            {
                 UserId=electionVoterData.UserId,
                 Name=electionVoterData.Name,
                 Address=electionVoterData.Address,
                 Mobile=electionVoterData.Mobile,
                 NID=electionVoterData.NID,
                 DateOfBirth=electionVoterData.DateOfBirth,
                 CoverPhotoUrl= ImagePath(electionVoterData.CoverPhoto)
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
