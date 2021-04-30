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
        [Required(ErrorMessage = "Please enter the Name")]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }
       
        [Required(ErrorMessage = "Please enter the Mobile Number")]
        public string Mobile { get; set; }
       
        [Required(ErrorMessage = "Please enter the NID Number")]
        public string NID { get; set; }
       
        [Required(ErrorMessage = "Please select the DOB")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please select the cover photo ")]
        [Display(Name = "Cover Photo")]
        public IFormFile CoverPhoto { get; set; }
    }
}
