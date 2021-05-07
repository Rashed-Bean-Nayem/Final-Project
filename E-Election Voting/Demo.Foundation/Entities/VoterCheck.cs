using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Entities
{
    public class VoterCheck : IEntity<int>
    {
        public int Id { get; set; } 
        public int Eid { get; set; }
        public string UserId { get; set; }
    }
}
