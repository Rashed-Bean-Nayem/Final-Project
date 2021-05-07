using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.UnitOfworks
{
    public interface IElectionUnitOfWork : IUnitOfWork
    {
        IVoterRepository VoterRepository { get; set; }
        ICandidateRepository CandidateRepository { get; set; }
        IRegistrationRepository RegistrationRepository { get; set; }
        IMakeElectionRepository MakeElectionRepository { get; set; }
        IVoterCheckRepository VoterCheckRepository { get; set; }
    }
}
