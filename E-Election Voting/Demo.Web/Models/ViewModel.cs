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
    public class ViewModel : BaseModel
    {
        public int EId { get; set; }
        public string CandName { get; set; }
        public string ElectionName { get; set; }
        public string UserId { get; set; }
        public DateTime? ElectionDate { get; set; } 
        public IList<NewGetElectionDataBO> MixedClass{ get; set; }
        public IList<ViewResultDataBO> ViewResults { get; set; }
        public IList<MakeElection> MakeElections { get; set; }
        public IList<MakeElection> ElectionsDataTable { get; set; }
        public IList<MakeElection> UpcomingElections { get; set; }   
        public ElectionVoterDataBO ElectionVoter { get; set; }
        public VoterCheck VoterCheck { get; set; }
        public ElectionCandidate ElectionCandidate { get; set; }
        public IList<ElectionCandidate> ElectionCandidates { get; set; }
        public IList<ElectionVoter> ElectionVoters { get; set; }
        public int TotalElectionsCount { get; set; }
        public int RunningElectionCount { get; set; }
        public int UpcomingElectionCount { get; set; } 
        public int ConcretedElectionCount { get; set; }
        public int TotalCandidateCount { get; set; }
        public int TotalVoterCount { get; set; }

        private const string IMAGE_PATH = "temp";
        private readonly IGetService _getService;
        private readonly RegistrationContext _registrationContext; 
        public ViewModel(IGetService getService, RegistrationContext registrationContext)
        {
            _getService = getService;
            _registrationContext = registrationContext;
        }
        public ViewModel()
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
            _registrationContext = Startup.AutofacContainer.Resolve<RegistrationContext>();
        }
        public void LoadSingleVoter(string userId)
        {
            ElectionVoter = ConvertToVoter(_getService.GetVoter(userId));
        }
        public ElectionVoterDataBO ConvertToVoter(IList<ElectionVoter> electionVoter)
        {
            var electionVoterObj = new ElectionVoterDataBO();
            foreach (var item in electionVoter)
            {
                electionVoterObj.Id = item.Id;
                electionVoterObj.Name = item.Name;
                electionVoterObj.NID = item.NID;
                electionVoterObj.Mobile = item.Mobile;
                electionVoterObj.DateOfBirth = Convert.ToDateTime(item.DateOfBirth).Date.ToString("d");
                electionVoterObj.Address = item.Address;
                electionVoterObj.CoverPhotoUrl = FormatFileUrl(item.CoverPhotoUrl);
            }
            return electionVoterObj;
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
                ImageUrl = FormatFileUrl(item.ImageUrl),
                Motto = item.Motto,
                LogoImageUrl = FormatFileUrl(item.LogoImageUrl),
                DateOfBirth=item.DateOfBirth,
                PdfListUrl = item.PdfListUrl.Select(g => new PdfList()
                {
                    Id = g.Id,
                    Name = g.Name,
                    URL = FormatFileUrl(g.URL)
                }).ToList()
            }).FirstOrDefault();

            return electionCandidateObj;
        }

        public void LoadElections()
        {
            MakeElections = ConvertToElectionList(_getService.GetMakeElectionList());
        }
        private IList<MakeElection> ConvertToElectionList(IList<MakeElection> makeElections)
        {
            TotalElectionsCount = 0;
            RunningElectionCount = 0;
            int result;
            IList<MakeElection> electionList = new List<MakeElection>();

            foreach (var electionItem in makeElections)
            {
                result = DateTime.Compare((DateTime)electionItem.ElectionDate, DateTime.Now.Date);
                if (result == 0)
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
                    RunningElectionCount++;
                }
                TotalElectionsCount++;
            }
            return electionList;
        }
        public void LoadUpcomingElections() 
        {
            UpcomingElections = ConvertToUpcomingElections(_getService.GetMakeElectionList());
        }
        private IList<MakeElection> ConvertToUpcomingElections(IList<MakeElection> makeElections)
        {
            UpcomingElectionCount = 0;
            int result;
            IList<MakeElection> electionList = new List<MakeElection>();

            foreach (var electionItem in makeElections)
            {
                result = DateTime.Compare((DateTime)electionItem.ElectionDate, DateTime.Now.Date);
                if (result == 1)
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
                    UpcomingElectionCount++;
                }
            }
            return electionList;
        }
        public void LoadElectionsDataTable() 
        {
            ElectionsDataTable = ConvertToElectionListDataTable(_getService.GetMakeElectionList()); 
        }
        private IList<MakeElection> ConvertToElectionListDataTable(IList<MakeElection> makeElections)
        {
            int result;
            IList<MakeElection> electionList = new List<MakeElection>();
           
            foreach (var electionItem in makeElections)
            {
                result = DateTime.Compare((DateTime)electionItem.ElectionDate, DateTime.Now.Date);
                if (result==0)
                {
                    electionList.Add(new MakeElection()
                    {
                        Id = electionItem.Id,
                        ElectionName = electionItem.ElectionName,
                        ElectionDate = electionItem.ElectionDate,
                        CDName1 = "Running",
                    });
                }
                else if(result<0)
                {
                    electionList.Add(new MakeElection()
                    {
                        Id = electionItem.Id,
                        ElectionName = electionItem.ElectionName,
                        ElectionDate = electionItem.ElectionDate,
                        CDName1 = "Completed",
                    });
                }
                else
                {
                    electionList.Add(new MakeElection()
                    {
                        Id = electionItem.Id,
                        ElectionName = electionItem.ElectionName,
                        ElectionDate = electionItem.ElectionDate,
                        CDName1 = "Upcoming",
                    });
                }                       
            }
            return electionList;
        }
        public void LoadVoterCheck(int eId, string userId)
        {
            VoterCheck = ConvertToVoterCheck(_getService.GetVoterCheck(userId), eId);
        }
        public VoterCheck ConvertToVoterCheck(IList<VoterCheck> voterChecks, int eId)
        {
            var voterCheckObj = new VoterCheck();
            foreach (var item in voterChecks)
            {
                if (item.Eid == eId)
                {
                    voterCheckObj.Eid = item.Eid;
                    voterCheckObj.UserId = item.UserId;
                }
            }
            return voterCheckObj;
        }
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
        public void LoadResults()
        {
            ViewResults = ConvertToViewResultList(_getService.GetMakeElectionList());
        }
        private IList<ViewResultDataBO> ConvertToViewResultList(IList<MakeElection> makeElections)
        {
            ConcretedElectionCount = 0;
            int resultCheck;
            var results = new List<ViewResultDataBO>();
           
            foreach (var electionItem in makeElections)
            {
                resultCheck = DateTime.Compare((DateTime)electionItem.ElectionDate, DateTime.Now.Date);

                if (resultCheck<0)
                {
                    if (electionItem.Count1 != 0 || electionItem.Count2 != 0)
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
                    else
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
                            Winner = "Not Elected Yet",
                            WinnerVote = 0,
                            WinnerID = 0
                        });
                    }
                    ConcretedElectionCount++;
                }                            
            }
            return results;
        }
        public void LoadCandidatesCount() 
        {
            ElectionCandidates = _getService.GetCandidateList();
            TotalCandidateCount = ElectionCandidates.Count;
        }
        public void LoadVotersCount()  
        {
            ElectionVoters = _getService.GetVoterList();
            TotalVoterCount = ElectionVoters.Count;
        }
        private static string FormatFileUrl(string filePath)
        {
            return $"/{IMAGE_PATH}/{Path.GetFileName(filePath)}";
        }
    }
}