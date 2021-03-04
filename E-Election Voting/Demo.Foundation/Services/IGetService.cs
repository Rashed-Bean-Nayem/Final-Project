using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IGetService
    {
        IList<Student> GetstudentList(); 
        IList<Course> GetcourseList();
        void RemoveAllData(StudentRegistration studentRegistration);
    }
}
