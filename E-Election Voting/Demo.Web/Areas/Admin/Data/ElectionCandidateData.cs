using System;
using System.Collections.Generic;
using System.Text;
using Demo.DataAccessLayer;

namespace Demo.Web.Areas.Admin.Data
{
    public class ElectionCandidateData:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string NID { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } 
    }
}
