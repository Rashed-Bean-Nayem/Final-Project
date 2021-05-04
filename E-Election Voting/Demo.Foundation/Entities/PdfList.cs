using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Entities
{
    public class PdfList
    {
        public int Id { get; set; }
        public int ElectionCandidateId { get; set; } 
        public string Name { get; set; }
        public string URL { get; set; }
        public ElectionCandidate ElectionCandidate { get; set; } 
    }
}
