using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public class ApiEntityRepository : Repository<ApiClass, int, RegistrationContext>, IApiEntityRepository
    {
        public ApiEntityRepository(RegistrationContext dbContext)
            : base(dbContext)
        {

        }
        public IList<ApiClass> GetLatestApiClass()
        {
            throw new NotImplementedException();
        }
    }
}
