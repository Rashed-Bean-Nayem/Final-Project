using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Foundation.Entities
{
    public class MakeElection : IEntity<int>
    {
        public int Id { get; set; }
        public string ElectionName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ElectionDate { get; set; }
        public int? CID1 { get; set; }
        public string CDName1 { get; set; } 
        public int? CID2 { get; set; }
        public string CDName2 { get; set; } 
    }
}
