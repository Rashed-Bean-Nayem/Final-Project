using Demo.Foundation.Contexts;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Demo.Foundation.Entities;

namespace Demo.Web.Models
{
    public class DeleteModel
    {
        private readonly IDeleteService _deleteService; 
        private readonly RegistrationContext _registrationContext;
        private readonly IGetService _getService;
        public IList<MakeElection> MakeElections1 { get; set; }
        public IList<MakeElection> MakeElections2 { get; set; } 
        public DeleteModel(IGetService getService, IDeleteService deleteService, RegistrationContext registrationContext)
        {
            _getService = getService;
            _deleteService = deleteService;
            _registrationContext = registrationContext;
        }
        public DeleteModel() 
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
            _deleteService = Startup.AutofacContainer.Resolve<IDeleteService>();
            _registrationContext = Startup.AutofacContainer.Resolve<RegistrationContext>();
        }

        public void DeleteElection(int id)
        {
            _deleteService.DeleteSingleElection(id); 
        }
        
        public void DeleteCandidate(int id) 
        {
            MakeElections1 = _getService.GetElectionList1(id);
            MakeElections2 = _getService.GetElectionList2(id);

            if (MakeElections1.Count==0 && MakeElections2.Count == 0)
            {
                _deleteService.DeleteSingleCandidate(id);
            }
        }    
    }
}
