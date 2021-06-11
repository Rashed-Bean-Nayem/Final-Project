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
        IList<ElectionVoter> GetVoter(string userId);
        IList<VoterCheck> GetVoterCheck(string userId);
        ElectionCandidate GetElectionCandidate(int id);
        IList<MakeElection> GetMakeElectionList();
        IList<MakeElection> GetElectionList1(int canId);
        IList<MakeElection> GetElectionList2(int canId);
        MakeElection GetSingleMakeElection(int id);
        ElectionCandidate GetSingleElectionCandidate(int id);
        IList<ApiClass> GetSingleApiRecord(string apiNid);
        IList<ElectionVoter> GetApiDetails1(string apiNid);
        IList<ElectionCandidate> GetApiDetails2(string apiNid);
    }
}
