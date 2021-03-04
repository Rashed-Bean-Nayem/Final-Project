using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IElectionService 
    {
        IList<ElectionCandidate> GetCandidates(); 
        void AddCandidate(ElectionCandidate electionCandidate);
        IList<ElectionVoter> GetVoters(); 
        void AddVoter(ElectionVoter electionVoter); 
    }
}
