using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IGetService
    {
        IList<ElectionVoter> GetVoterList();
        IList<ElectionCandidate> GetCandidateList();
        void RemoveAllData(ElectionRegistration electionRegistration);
    }
}
