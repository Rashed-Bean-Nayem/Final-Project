using Demo.Foundation.BusinessObjects;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Demo.Web.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class IndexModel : BaseModel
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
                ImageUrl = ImagePath(electionCandidateData.ImageFile)
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
                UserId = electionVoterData.UserId,
                Name = electionVoterData.Name,
                Address = electionVoterData.Address,
                Mobile = electionVoterData.Mobile,
                NID = electionVoterData.NID,
                DateOfBirth = electionVoterData.DateOfBirth,
                CoverPhotoUrl = ImagePath(electionVoterData.CoverPhoto)
            });
        }
        public void AddModelRElection(RegistrationData registrationData)
        {
            var getVoterObj1 = new ElectionCandidate();
            var getVoterObj2 = new ElectionCandidate();
            getVoterObj1 = _getService.GetElectionCandidate((int)registrationData.CID1);
            getVoterObj2 = _getService.GetElectionCandidate((int)registrationData.CID2);
            _addingService.AddElection(new MakeElection
            {
                CID1 = registrationData.CID1,
                CDName1 = getVoterObj1.Name,
                CID2 = registrationData.CID2,
                CDName2 = getVoterObj2.Name,
                ElectionName = registrationData.ElectionName,
                ElectionDate = registrationData.ElectionDate,
                Count1 = 0,
                Count2 = 0
            });

        }
        public void AddModelElectionPOST(ViewData viewData)
        {
            var getElectionObj1 = new MakeElection();

            getElectionObj1 = _getService.GetSingleMakeElection(viewData.EId);

            if (viewData.Count1 == "firstCand")
            {
                _addingService.EditElection(new MakeElection
                {
                    Id = viewData.EId,
                    Count1 = getElectionObj1.Count1 + 1,
                    Count2 = getElectionObj1.Count2 + 0,
                });
            }
            else
            {
                _addingService.EditElection(new MakeElection
                {
                    Id = viewData.EId,
                    Count1 = getElectionObj1.Count1 + 0,
                    Count2 = getElectionObj1.Count2 + 1,
                });
            }
        }

        //public void DeleteAllData(ElectionRegistration studentRegistration)
        //{
        //    _getService.RemoveAllData(studentRegistration);
        //}
    }
}
