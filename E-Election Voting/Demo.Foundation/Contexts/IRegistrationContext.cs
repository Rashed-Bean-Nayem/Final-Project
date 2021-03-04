using Demo.Foundation.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Foundation.Contexts
{
    public interface IRegistrationContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<StudentRegistration> StuReg { get; set; }
    }
}