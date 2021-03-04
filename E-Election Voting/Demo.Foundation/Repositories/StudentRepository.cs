using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;

namespace Demo.Foundation.Repositories
{
    public class StudentRepository : Repository<Student, int, RegistrationContext>, IStudentRepository
    {
        public StudentRepository(RegistrationContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Student> GetLatestStudents() 
        {
            throw new NotImplementedException();
        }
    }
}
