using Autofac;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Areas.Admin.Data
{
    public class RegistrationData
    {
        public int CandidateId { get; set; }
        public ElectionCandidate ElectionCandidate { get; set; }
        public int VoterId { get; set; }
        public ElectionVoter ElectionVoter { get; set; }
        public DateTime EnrollDate { get; set; }
        public bool IsPaymentComplete { get; set; }
        public int Id { get; set; }
        public IList<ElectionVoter> ElectionVoters { get; set; }
        public IList<ElectionCandidate> ElectionCandidates { get; set; }

        private readonly IGetService _getService;


        public RegistrationData(IGetService getService)
        {

            _getService = getService;

        }
        public RegistrationData()
        {

            _getService = Startup.AutofacContainer.Resolve<IGetService>();

        }

        public void LoadVoters()
        {
            ElectionVoters = _getService.GetVoterList();
        }

        public void LoadCandidates()
        {
            ElectionCandidates = _getService.GetCandidateList();
        }
    }
}
