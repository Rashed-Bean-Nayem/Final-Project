using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IAddingService
    {
        void AddStudent(Student student); 
        void AddCourse(Course course); 
        void AddRegistration(StudentRegistration studentRegistration); 

    }
}
