using System;
using System.Collections.Generic;
using System.Text;
using Demo.DataAccessLayer;

namespace Demo.Foundation.Entities
{
    public class ApiClass : IEntity<int>
    {
        public int Id { get; set; }
        public string ApiNid { get; set; }
        public string ApiName { get; set; }
        public string ApiDateOfBirth { get; set; }

    }
}
