using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.UnitOfworks
{
    public interface IRegistrationUnitOfWork : IUnitOfWork
    {
        ICandidateRepository CandidateRepository { get; set; }
        IVoterRepository VoterRepository { get; set; }
        IRegistrationRepository RegistrationRepository { get; set; }
        IMakeElectionRepository MakeElectionRepository { get; set; }
    }
}
