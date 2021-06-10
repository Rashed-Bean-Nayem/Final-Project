using Demo.Foundation.BusinessObjects;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Demo.Web.Areas.Admin.Models;
using Demo.Web.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class AdditionModel : BaseModel
    {
        private readonly IAddingService _addingService;
        private readonly IGetService _getService;
        public ElectionVoter ElectionVoter { get; set; }
        public ElectionCandidate ElectionCandidate { get; set; }
        public AdditionModel(IAddingService addingService,
            IGetService getService)
        {
            _addingService = addingService;
            _getService = getService;
        }
        public void AddModelApiClass(ApiClassDataBO apiClassDataBO) 
        {
            _addingService.AddApiClass(new ApiClass
            {
                ApiName = apiClassDataBO.ApiName,
                ApiNid= apiClassDataBO.ApiNid,
                ApiDateOfBirth= Convert.ToDateTime(apiClassDataBO.ApiDateOfBirth).Date.ToString("d")
            });
        }
        public void AddModelCandidate(ApiRecordForCandidateData electionCandidateData)
        {
            var list = new List<PdfList>();
            foreach (var item in electionCandidateData.PdfListBOfiles)
            {
                list.Add(new PdfList
                {
                    Name = item.FileName,
                    URL = FilePath(item)
                });
            }
            _addingService.AddCandidate(new ElectionCandidate
            {
                Name = electionCandidateData.FirstName,
                Address = electionCandidateData.Address,
                Description = electionCandidateData.Description,
                Mobile = electionCandidateData.Mobile,
                NID = electionCandidateData.NID,
                ImageUrl = FilePath(electionCandidateData.ImageFile),
                PdfListUrl=list,
                Motto=electionCandidateData.Motto,
                LogoImageUrl= FilePath(electionCandidateData.LogoImageFile),
                DateOfBirth=Convert.ToDateTime(electionCandidateData.DateOfBirth).Date.ToString("d")
            });
        }
        public void AddModelVoter(ApiRecordFormData apiRecordFormData)
        {
            _addingService.AddVoter(new ElectionVoter
            {
                UserId = apiRecordFormData.UserId,
                Name = apiRecordFormData.FirstName,
                NID = apiRecordFormData.NID,
                DateOfBirth = apiRecordFormData.DateOfBirth,
                
            });
        }
        public void AddModelVoterUpdate(ApiRecordFormData apiRecordFormData) 
        {           
            ElectionVoter = ConvertToVoter( _getService.GetVoter(apiRecordFormData.UserId));
            _addingService.EditVoter(new ElectionVoter
            {
                Id = ElectionVoter.Id,
                Mobile= apiRecordFormData.Mobile,
                Address= apiRecordFormData.Address,
                CoverPhotoUrl= FilePath(apiRecordFormData.CoverPhoto),
            });
        }
        public ElectionVoter ConvertToVoter(IList<ElectionVoter> electionVoter)
        {
            var electionVoterObj = new ElectionVoter();
            foreach (var item in electionVoter)
            {
                electionVoterObj.Id = item.Id;
                electionVoterObj.Name = item.Name;
                electionVoterObj.NID = item.NID;
                electionVoterObj.Mobile = item.Mobile;
                electionVoterObj.DateOfBirth = item.DateOfBirth;
                electionVoterObj.Address = item.Address;
                electionVoterObj.CoverPhotoUrl = FormatFileUrl(item.CoverPhotoUrl);
            }
            return electionVoterObj;
        }
        public void AddModelCandidateUpdate(ElectionCandidateDataBO electionCandidateDataBO) 
        {
            _addingService.EditCandidate(new ElectionCandidate
            {
                Id = electionCandidateDataBO.Id,
                Mobile = electionCandidateDataBO.Mobile,
                Address = electionCandidateDataBO.Address,
                Description = electionCandidateDataBO.Description,
                Motto = electionCandidateDataBO.Motto,
                ImageUrl = FilePath(electionCandidateDataBO.ImageFile),
                LogoImageUrl= FilePath(electionCandidateDataBO.LogoImageFile)
            });
        }
        public void AddModelElection(RegistrationData registrationData)
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
        public void AddModelElectionPOST(ViewModel viewData)
        {
            _addingService.AddVoterCheck(new VoterCheck()
            {
                Eid = viewData.EId,
                UserId = viewData.UserId

            });

            var getElectionObj1 = new MakeElection();

            getElectionObj1 = _getService.GetSingleMakeElection(viewData.EId);

            if (viewData.CandName == getElectionObj1.CDName1)
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
