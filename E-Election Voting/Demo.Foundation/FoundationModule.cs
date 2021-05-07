using Autofac;
using Demo.Foundation.Repositories;
using Demo.Foundation.Contexts;
using Demo.Foundation.Services;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation
{
    public class FoundationModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FoundationModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegistrationContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            
            builder.RegisterType<RegistrationUnitOfWork>().As<IRegistrationUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ElectionUnitOfWork>().As<IElectionUnitOfWork>()
               .InstancePerLifetimeScope();
            builder.RegisterType<AddingService>().As<IAddingService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<GetService>().As<IGetService>()
               .InstancePerLifetimeScope();
            builder.RegisterType<RegistrationRepository>().As<IRegistrationRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<VoterRepository>().As<IVoterRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CandidateRepository>().As<ICandidateRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<MakeElectionRepository>().As<IMakeElectionRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<VoterCheckRepository>().As<IVoterCheckRepository>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
