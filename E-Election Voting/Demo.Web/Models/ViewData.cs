using Autofac;
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
        public IList<MakeElection> MakeElections { get; set; }
        public MakeElection MakeSingleElection { get; set; }
        public ElectionVoter ElectionVoter { get; set; }
        public ElectionCandidate ElectionCandidate { get; set; }

        private readonly IGetService _getService;       
        public ViewData(IGetService getService) 
        {
            _getService = getService;
        }
        public ViewData()
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
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
                    Id=electionItem.Id,
                    ElectionName= electionItem.ElectionName,
                    ElectionDate=electionItem.ElectionDate,
                    CDName1=electionItem.CDName1,
                    CDName2=electionItem.CDName2,
                    CID1=electionItem.CID1,
                    CID2=electionItem.CID2
                });
            }
            return electionList;
        }

        public void LoadSingleMakeElection(int id) 
        {
            MakeSingleElection = ConvertToSingleMakeElection(_getService.GetSingleMakeElection(id));
        }
        public MakeElection ConvertToSingleMakeElection(MakeElection makeElection)
        {
            var makeElectionObj = new MakeElection();
            makeElectionObj.Id = makeElection.Id;
            makeElectionObj.ElectionName = makeElection.ElectionName;
            makeElectionObj.ElectionDate = makeElection.ElectionDate;
            makeElectionObj.CDName1 = makeElection.CDName1;
            makeElectionObj.CDName2 = makeElection.CDName2;
            makeElectionObj.CID1 = makeElection.CID1;
            makeElectionObj.CID2 = makeElection.CID2;

            return makeElectionObj;

        }

        public void LoadSingleCandidate(int id)
        {
            ElectionCandidate = ConvertToCandidate(_getService.GetSingleElectionCandidate(id)); 
        }
        public ElectionCandidate ConvertToCandidate(ElectionCandidate electionCandidate)
        {
            var electionCandidateObj = new ElectionCandidate();

            electionCandidateObj.Id = electionCandidate.Id;
            electionCandidateObj.Name = electionCandidate.Name;
            electionCandidateObj.NID = electionCandidate.NID;
            electionCandidateObj.Mobile = electionCandidate.Mobile;
            electionCandidateObj.Description = electionCandidate.Description;
            electionCandidateObj.Address = electionCandidate.Address;
            electionCandidateObj.ImageUrl = FormatFileUrl(electionCandidate.ImageUrl);

            return electionCandidateObj;           
        }

    }
}