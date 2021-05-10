using Autofac;
using Demo.Foundation.BusinessObjects;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Web.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
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

            builder.RegisterType<AdditionModel>().AsSelf();
            builder.RegisterType<DeleteModel>().AsSelf();
            builder.RegisterType<RegistrationData>().AsSelf();
            builder.RegisterType<ViewModel>().AsSelf();
            builder.RegisterType<MakeElection>().AsSelf();
            builder.RegisterType<NewGetElectionDataBO>().AsSelf(); 

            base.Load(builder);
        }
    }
}
