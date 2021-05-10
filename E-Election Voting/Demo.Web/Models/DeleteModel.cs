using Demo.Foundation.Contexts;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
namespace Demo.Web.Models
{
    public class DeleteModel
    {
        private readonly IDeleteService _deleteService; 
        private readonly RegistrationContext _registrationContext;
        public DeleteModel(IDeleteService deleteService, RegistrationContext registrationContext)
        {
            _deleteService = deleteService;
            _registrationContext = registrationContext;
        }
        public DeleteModel() 
        {
            _deleteService = Startup.AutofacContainer.Resolve<IDeleteService>();
            _registrationContext = Startup.AutofacContainer.Resolve<RegistrationContext>();
        }

        public void DeleteElection(int id)
        {
            _deleteService.DeleteSingleElection(id); 
        }
    }
}
