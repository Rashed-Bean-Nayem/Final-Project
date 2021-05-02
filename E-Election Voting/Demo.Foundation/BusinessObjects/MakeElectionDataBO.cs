using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Foundation.BusinessObjects
{
    public class MakeElectionDataBO
    {
        public int Id { get; set; }
        public string ElectionName { get; set; }
        [DataType(DataType.Date)]
        public DateTime ElectionDate { get; set; }
        public int CID1 { get; set; }
        public int CID2 { get; set; }
    }
}
