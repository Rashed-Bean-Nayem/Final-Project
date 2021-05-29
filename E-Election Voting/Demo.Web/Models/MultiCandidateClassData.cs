using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Models
{
    public class MultiCandidateClassData
    {
        public int Id { get; set; }
        public int RegistrationDataId { get; set; }
        public bool CheckBox { get; set; }
        public RegistrationData RegistrationData { get; set; } 
    }
}
