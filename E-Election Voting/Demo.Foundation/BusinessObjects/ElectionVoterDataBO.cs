using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Demo.Foundation.BusinessObjects
{
    public class ElectionVoterDataBO:IEntity<int>
    {
        public int Id { get; set; }        
        public string UserId { get; set; }
        [StringLength(100, MinimumLength = 2)]
        
        [Display(Name = "First Name")]
        public string Name { get; set; }
        //[StringLength(100, MinimumLength = 2)]
        //[Required(ErrorMessage = "Please enter the Last Name")]
        //[Display(Name = "Last Name")]
        //public string LastName { get; set; } 
        [StringLength(100, MinimumLength = 2)]
       
        public string Address { get; set; }  
      
        public string Mobile { get; set; }
     
        public string NID { get; set; }
       
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public string DateOfBirth { get; set; }
     
        [Display(Name = "Profile Photo")]
        public string CoverPhotoUrl { get; set; } 
    }
}
