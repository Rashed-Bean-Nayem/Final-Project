using System;
using System.Collections.Generic;
using System.Text;
using Demo.DataAccessLayer;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Demo.Foundation.BusinessObjects
{
    public class ElectionCandidateDataBO:IEntity<int>
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the Name")]
        public string FirstName { get; set; }
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the Name")]
        public string LastName { get; set; }  
        [StringLength(100, MinimumLength = 2)] 
        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter the Mobile Number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please enter the NID")]
        public string NID { get; set; }
        [Required(ErrorMessage = "Please enter the Description")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Please enter the Image")]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "Please select the Document Files ")]
        [Display(Name = "Documents")]
        public IFormFileCollection PdfListBOfiles { get; set; } 
    }
}
