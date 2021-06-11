using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IDeleteService
    {
        void DeleteSingleElection(int id);
        void DeleteSingleCandidate(int id);
    }
}
