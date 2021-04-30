using Demo.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Entities
{
    public class ElectionVoter:IEntity<int>
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string NID { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CoverPhotoUrl { get; set; }
    }
}
