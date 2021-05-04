using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IAddingService
    {
        void AddRegistration(ElectionRegistration studentRegistration);
        void AddCandidate(ElectionCandidate electionCandidate);
        void AddVoter(ElectionVoter electionVoter);
        void AddElection(MakeElection makeElection);
        void EditElection(MakeElection makeElection);
    }
}
