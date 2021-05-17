using Demo.Foundation.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Foundation.Contexts
{
    public class RegistrationContext : DbContext, IRegistrationContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public RegistrationContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<ElectionCandidate> ElectionCandidates { get; set; }
        public DbSet<ElectionVoter> ElectionVoters { get; set; }
        public DbSet<MakeElection> MakeElections { get; set; }
        public DbSet<PdfList> PdfLists { get; set; }
        public DbSet<VoterCheck> VoterChecks { get; set; }
        public DbSet<ApiClass> ApiClasses { get; set; }
    }
}
