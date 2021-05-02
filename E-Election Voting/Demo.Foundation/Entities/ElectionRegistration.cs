using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.Foundation.Entities
{
    public class ElectionRegistration: IEntity<int> 
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnrollDate { get; set; } 
        public ElectionCandidate ElectionCandidate { get; set; }
        
    }
}
