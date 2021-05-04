using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Demo.Foundation.BusinessObjects
{
    public class ViewResultDataBO
    {
        public int Id { get; set; }
        public string ElectionName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ElectionDate { get; set; }
        public int? CID1 { get; set; }
        public string CDName1 { get; set; }
        public int? CID2 { get; set; }
        public string CDName2 { get; set; }
        public int Count1 { get; set; }
        public int Count2 { get; set; }
        public string Winner { get; set; }
        public int WinnerVote { get; set; }
        public int? WinnerID { get; set; } 
    }
}
