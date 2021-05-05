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
        //public int? CID1 { get; set; }
        //public string CDName1 { get; set; }
        //public int? CID2 { get; set; }
        //public string CDName2 { get; set; }
        //public int Count1 { get; set; }
        //public int Count2 { get; set; }



        public int? CandidateId { get; set; } 
        public string CandidateName { get; set; }
        //public string Address { get; set; }
        //public string Mobile { get; set; }
        //public string NID { get; set; }
        //public string Description { get; set; }
        public string ImageUrl { get; set; }
        //public IList<PdfList> PdfListUrl { get; set; }
        public string Motto { get; set; }
        public string LogoImageUrl { get; set; }
    }
}
