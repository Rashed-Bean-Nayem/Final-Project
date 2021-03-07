using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Entities
{
    public class ElectionRegistration: IEntity<int> 
    {
        public int VoterId { get; set; } 
        public ElectionVoter ElectionVoter { get; set; } 
        public int CandidateId { get; set; } 
        public ElectionCandidate ElectionCandidate { get; set; } 
        public DateTime EnrollDate { get; set; } 
        public bool IsPaymentComplete { get; set; }
        public int Id { get ; set ; }
    }
}
