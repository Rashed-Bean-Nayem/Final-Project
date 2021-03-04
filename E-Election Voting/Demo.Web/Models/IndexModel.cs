using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Demo.Web.Areas.Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web
{
    public class IndexModel
    {
        //public void Add()
        //{
        //    _purchaseService.AddProduct(new Product
        //    {
        //        Name = Name,
        //        Price = 203
        //    });
        //}
        public int Id { get; set; }
        public string Name { get; set; }


        private readonly IAddingService _addingService;
        private readonly IGetService _getService;
        private readonly IElectionService _purchaseService;


        public IndexModel(IAddingService addingService,
            IGetService getService,
            IElectionService purchaseService)
        {

            _addingService = addingService;
            _getService = getService;
            _purchaseService = purchaseService;

        }
        public void AddModelStudent(StudentData studentData)
        {
            _addingService.AddStudent(new Student
            {

                Name = studentData.Name,
                DateOfBirth = studentData.DateOfBirth

            });
        }
        public void AddModelCourse(CourseData courseData)
        {
            _addingService.AddCourse(new Course
            {

                Title = courseData.Title,
                SeatCount = courseData.SeatCount,
                Fee = courseData.Fee

            });
        }

        public void AddModelRegistration(RegistrationData registrationData)
        {
            _addingService.AddRegistration(new StudentRegistration
            {

                StudentId = registrationData.StudentId,
                CourseId = registrationData.CourseId,
                EnrollDate = registrationData.EnrollDate,
                IsPaymentComplete = registrationData.IsPaymentComplete

            });
        }

        //public IList<Student> GetModelStudentsList() 
        //{


        //    return _getService.GetstudentList(); 
        //}

        public void DeleteAllData(StudentRegistration studentRegistration)
        {
            _getService.RemoveAllData(studentRegistration);
        }
    }
}
