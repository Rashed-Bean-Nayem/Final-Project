using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.DataAccessLayer;

namespace Demo.API
{
    public class ApiDataClass : IEntity<int>
    {
        public int Id { get; set; }
        public string ApiNid { get; set; }
        public string ApiName { get; set; }
        public DateTime? ApiDateOfBirth { get; set; }

    }
}
