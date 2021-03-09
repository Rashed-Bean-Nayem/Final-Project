using Demo.Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Foundation.Contexts
{
    public interface IRegistrationContext
    {
        DbSet<ElectionCandidate> ElectionCandidates { get; set; }
        DbSet<ElectionVoter> ElectionVoters { get; set; }
        DbSet<ElectionRegistration> ElectionRegistrations { get; set; }
    }
}