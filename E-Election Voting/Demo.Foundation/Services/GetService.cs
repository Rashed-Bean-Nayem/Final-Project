using Demo.Foundation.Entities;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class GetService : IGetService
    {
        private readonly IRegistrationUnitOfWork _shopingUnitOfWork;


        public GetService(IRegistrationUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }


        public IList<Student> GetstudentList() 
        {
            return _shopingUnitOfWork.StudentRepository.GetAll();
        }
        public IList<Course> GetcourseList() 
        {
            return _shopingUnitOfWork.CourseRepository.GetAll();
        }

        
        public void RemoveAllData(StudentRegistration studentRegistration)
        {
            _shopingUnitOfWork.RegistrationRepository.Remove(studentRegistration);
        }

        
    }
}
