using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public class RegistrationRepository: Repository<StudentRegistration, int, RegistrationContext>, IRegistrationRepository
    {
        public RegistrationRepository(RegistrationContext dbContext) 
            : base(dbContext)
        {

        }

        public IList<StudentRegistration> GetLatestRegistraion()
        {
            throw new NotImplementedException();
        }
        
    }
}
