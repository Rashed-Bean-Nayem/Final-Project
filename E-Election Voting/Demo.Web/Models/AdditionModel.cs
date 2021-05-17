﻿using Demo.Foundation.BusinessObjects;
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
    public class AdditionModel : BaseModel
    {
        private readonly IAddingService _addingService;
        private readonly IGetService _getService;
        public ElectionVoter ElectionVoter { get; set; }
        public ElectionVoter ElectionVoter2 { get; set; }
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
                ApiDateOfBirth=apiClassDataBO.ApiDateOfBirth
            });
        }
        public void AddModelCandidate(ElectionCandidateDataBO electionCandidateData)
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
                Name = electionCandidateData.FirstName+" "+electionCandidateData.LastName,
                Address = electionCandidateData.Address,
                Description = electionCandidateData.Description,
                Mobile = electionCandidateData.Mobile,
                NID = electionCandidateData.NID,
                ImageUrl = FilePath(electionCandidateData.ImageFile),
                PdfListUrl=list,
                Motto=electionCandidateData.Motto,
                LogoImageUrl= FilePath(electionCandidateData.LogoImageFile)
            });
        }
        public void AddModelVoter(ApiRecordFormData apiRecordFormData)
        {
            ElectionVoter2= LoadSingleVoterPrivate(apiRecordFormData.UserId);

            if (apiRecordFormData.NID==null)
            {
                _addingService.AddVoter(new ElectionVoter
                {
                    UserId = apiRecordFormData.UserId,
                    Name = ElectionVoter2.Name,
                    Address = apiRecordFormData.Address,
                    Mobile = apiRecordFormData.Mobile,
                    NID = ElectionVoter2.NID,
                    DateOfBirth=ElectionVoter2.DateOfBirth,
                    CoverPhotoUrl = FilePath(apiRecordFormData.CoverPhoto)
                });
            }
            else
            {
                _addingService.AddVoter(new ElectionVoter
                {
                    UserId = apiRecordFormData.UserId,
                    Name = apiRecordFormData.FirstName,
                    Address = apiRecordFormData.Address,
                    Mobile = apiRecordFormData.Mobile,
                    NID = apiRecordFormData.NID,
                    DateOfBirth = apiRecordFormData.DateOfBirth,
                    CoverPhotoUrl = FilePath(apiRecordFormData.CoverPhoto)
                });
            }
        }
        public ElectionVoter LoadSingleVoterPrivate(string userId) 
        {
           return ConvertToVoter(_getService.GetVoter(userId));
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
