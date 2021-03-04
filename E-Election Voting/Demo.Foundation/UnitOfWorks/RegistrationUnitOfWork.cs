using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.UnitOfworks
{
    public class RegistrationUnitOfWork : UnitOfWork, IRegistrationUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }
        public IRegistrationRepository RegistrationRepository { get; set; }

      

        public RegistrationUnitOfWork(RegistrationContext context, 
            IStudentRepository studentRepository,
            ICourseRepository courseRepository, IRegistrationRepository registrationRepository)
            : base(context)
        {
            StudentRepository = studentRepository;
            CourseRepository = courseRepository;
            RegistrationRepository = registrationRepository;
        }
    }
}
