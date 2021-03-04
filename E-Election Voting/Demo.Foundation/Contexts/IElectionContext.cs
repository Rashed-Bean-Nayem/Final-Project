using Demo.Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Foundation.Contexts
{
    public interface IElectionContext
    {
        DbSet<ElectionCandidate> Category { get; set; }
        DbSet<ElectionVoter> Customers { get; set; }
    }
}