using Autofac;
using Demo.Foundation.BusinessObjects;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Models
{
    public class ViewData : BaseModel
    {
        public int EId { get; set; }
        public string CandName { get; set; }
        public string ElectionName { get; set; }
        public DateTime? ElectionDate { get; set; } 
        public IList<NewGetElectionDataBO> MixedClass{ get; set; }
        public IList<ViewResultDataBO> ViewResults { get; set; }
        public IList<MakeElection> MakeElections { get; set; }
        public MakeElection MakeSingleElection { get; set; }
        public ElectionVoter ElectionVoter { get; set; }
        public ElectionCandidate ElectionCandidate { get; set; }
        private const string IMAGE_PATH = "temp";

        private readonly IGetService _getService;
        private readonly RegistrationContext _registrationContext; 
        public ViewData(IGetService getService, RegistrationContext registrationContext)
        {
            _getService = getService;
            _registrationContext = registrationContext;
        }
        public ViewData()
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
            _registrationContext = Startup.AutofacContainer.Resolve<RegistrationContext>();
        }
        public void LoadSingleVoter(string userId)
        {
            ElectionVoter = ConvertToVoter(_getService.GetVoter(userId));
        }
        public ElectionVoter ConvertToVoter(IList<ElectionVoter> electionVoter)
        {
            var electionVoterObj = new ElectionVoter();
            foreach (var item in electionVoter)
            {
                electionVoterObj.Name = item.Name;
                electionVoterObj.NID = item.NID;
                electionVoterObj.Mobile = item.Mobile;
                electionVoterObj.DateOfBirth = item.DateOfBirth;
                electionVoterObj.Address = item.Address;
                electionVoterObj.CoverPhotoUrl = FormatFileUrl(item.CoverPhotoUrl);
            }
            return electionVoterObj;
        }

        public void LoadElections()
        {
            MakeElections = ConvertToElectionList(_getService.GetMakeElectionList());
        }
        private IList<MakeElection> ConvertToElectionList(IList<MakeElection> makeElections)
        {
            IList<MakeElection> electionList = new List<MakeElection>();

            foreach (var electionItem in makeElections)
            {
                electionList.Add(new MakeElection()
                {
                    Id = electionItem.Id,
                    ElectionName = electionItem.ElectionName,
                    ElectionDate = electionItem.ElectionDate,
                    CDName1 = electionItem.CDName1,
                    CDName2 = electionItem.CDName2,
                    CID1 = electionItem.CID1,
                    CID2 = electionItem.CID2
                });
            }
            return electionList;
        }




  

        //public void LoadSingleMakeElection(int id)
        //{
        //    MakeSingleElection = ConvertToSingleMakeElection(_getService.GetSingleMakeElection(id));
        //}
        //public MakeElection ConvertToSingleMakeElection(MakeElection makeElection)
        //{
        //    var makeElectionObj = new MakeElection();
        //    makeElectionObj.Id = makeElection.Id;
        //    makeElectionObj.ElectionName = makeElection.ElectionName;
        //    makeElectionObj.ElectionDate = makeElection.ElectionDate;
        //    makeElectionObj.CDName1 = makeElection.CDName1;
        //    makeElectionObj.CDName2 = makeElection.CDName2;
        //    makeElectionObj.CID1 = makeElection.CID1;
        //    makeElectionObj.CID2 = makeElection.CID2;

        //    return makeElectionObj;
        //}
        public void LoadSingleMakeElection(int id)
        {
            MixedClass = ConvertToSingleMakeElection(_getService.GetSingleMakeElection(id));
        }
        public IList<NewGetElectionDataBO>  ConvertToSingleMakeElection(MakeElection makeElection)
        {
            ElectionName = makeElection.ElectionName;
            ElectionDate = makeElection.ElectionDate;
            var electionCandidateOBJ1 = ConvertToCandidate(makeElection.CID1);
            var electionCandidateOBJ2 = ConvertToCandidate(makeElection.CID2);

            var newGetElectionDataBO = new List<NewGetElectionDataBO> ();

            newGetElectionDataBO.Add(new NewGetElectionDataBO { 
            
            EId= makeElection.Id,
            ElectionName=makeElection.ElectionName,
            ElectionDate=makeElection.ElectionDate,
            CandidateId=makeElection.CID1,
            ImageUrl= electionCandidateOBJ1.ImageUrl,
            LogoImageUrl= electionCandidateOBJ1.LogoImageUrl,
            Motto= electionCandidateOBJ1.Motto,
            CandidateName= electionCandidateOBJ1.Name

            });

            newGetElectionDataBO.Add(new NewGetElectionDataBO
            {
                EId = makeElection.Id,
                ElectionName = makeElection.ElectionName,
                ElectionDate = makeElection.ElectionDate,
                CandidateId = makeElection.CID2,
                ImageUrl = electionCandidateOBJ2.ImageUrl,
                LogoImageUrl = electionCandidateOBJ2.LogoImageUrl,
                Motto = electionCandidateOBJ2.Motto,
                CandidateName = electionCandidateOBJ2.Name

            });

            return newGetElectionDataBO;
        }

        public void LoadSingleCandidate(int id)
        {            
            ElectionCandidate = ConvertToCandidate(id);
        }
        public ElectionCandidate ConvertToCandidate(int? id)
        {
            var electionCandidateObj = new ElectionCandidate();
            electionCandidateObj = _registrationContext.ElectionCandidates.Where(x => x.Id == id).Select(item => new ElectionCandidate()
            {
                
                Id = item.Id,
                Name = item.Name,
                Address = item.Address,
                Description = item.Description,
                Mobile = item.Mobile,
                NID = item.NID,
                ImageUrl= FormatFileUrl(item.ImageUrl),
                Motto=item.Motto,
                LogoImageUrl= FormatFileUrl(item.LogoImageUrl),
                PdfListUrl = item.PdfListUrl.Select(g => new PdfList()
                {
                    Id = g.Id,
                    Name = g.Name,
                    URL = FormatFileUrl(g.URL)
                }).ToList()
            }).FirstOrDefault();

            return electionCandidateObj;
        }
        public void LoadResults()
        {
            ViewResults = ConvertToViewResultList(_getService.GetMakeElectionList());
        }
        private IList<ViewResultDataBO> ConvertToViewResultList(IList<MakeElection> makeElections)
        {
            var results = new List<ViewResultDataBO>();

            foreach (var electionItem in makeElections)
            {
                results.Add(new ViewResultDataBO()
                {
                    Id = electionItem.Id,
                    ElectionName = electionItem.ElectionName,
                    ElectionDate = electionItem.ElectionDate,
                    CDName1 = electionItem.CDName1,
                    CDName2 = electionItem.CDName2,
                    CID1 = electionItem.CID1,
                    CID2 = electionItem.CID2,
                    Winner = (electionItem.Count1 >= electionItem.Count2) ? electionItem.CDName1 : electionItem.CDName2,
                    WinnerVote = (electionItem.Count1 >= electionItem.Count2) ? electionItem.Count1 : electionItem.Count2,
                    WinnerID = (electionItem.Count1 >= electionItem.Count2) ? electionItem.CID1 : electionItem.CID2
                });
            }
            return results;
        }
        private static string FormatFileUrl(string filePath)
        {
            return $"/{IMAGE_PATH}/{Path.GetFileName(filePath)}";
        }
    }
}