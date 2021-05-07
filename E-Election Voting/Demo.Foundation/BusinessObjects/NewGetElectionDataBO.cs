using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.BusinessObjects
{
    public class NewGetElectionDataBO
    {
        public int EId { get; set; } 
        public string ElectionName { get; set; }
        public DateTime? ElectionDate { get; set; }
        public int? CandidateId { get; set; } 
        public string CandidateName { get; set; }
        public string ImageUrl { get; set; }
        public string Motto { get; set; }
        public string LogoImageUrl { get; set; }
    }
}
