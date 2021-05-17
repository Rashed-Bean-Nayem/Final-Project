using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace Demo.Foundation.BusinessObjects
{
    public class ApiClassDataBO
    {
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 10)]
        [Required(ErrorMessage = "Please enter the NID")]
        [Display(Name = "Api NID")]
        public string ApiNid { get; set; }
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the Name")]
        [Display(Name = "Api Name")]
        public string ApiName { get; set; }
        [Required(ErrorMessage = "Please select the DOB")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime? ApiDateOfBirth { get; set; }
    }
}
