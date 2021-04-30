﻿using Autofac;
using Demo.Foundation.BusinessObjects;
using Demo.Foundation.Contexts;
using Demo.Web.Areas.Admin.Data;
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

            builder.RegisterType<IndexModel>().AsSelf();
            builder.RegisterType<RegistrationData>().AsSelf();
            builder.RegisterType<ViewData>().AsSelf();

            base.Load(builder);
        }
    }
}
