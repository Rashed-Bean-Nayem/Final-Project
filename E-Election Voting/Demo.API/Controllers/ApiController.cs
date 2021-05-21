using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET: api/<ApiController>
        [HttpGet]
        public IEnumerable<string> GetNID() 
        {
            return new string[] { "1234123412", "1122113344", "3421674328", "8945623534",
                                  "3755062530", "9353615235", "8763426153", "9034517443",
                                  "4321672341", "8911225143", "7562318945", "3452178934",
                                  "2316893425", "6723194537", "2314678499", "8634183213",
                                  "9988137643", "8913665521", "1752331232", "1752331239"};
        }
        public IEnumerable<string> GetName()
        {
            return new string[] { "Zahid Akbar","Rabbi Ahmed","Jisan Akbar","Aminul Islam",
                          "Rashed Bean Nayem","Abdul Kader","Badrul Alam","Ashraful Islam", 
                    "Tamim Iqbal","Shakib Al Hasan","Mahmudullah Riyad","Mushfiqur Rahim", 
                  "Mashrafee Bin Mortaza", "Soumya Sarkar","Liton Das","Mustafizur Rahman", 
                       "Taskin Ahmed", "Mehidy Miraz","Mohammad Saifuddin","Rubel Hossain"};
        }
        public IEnumerable<string> GetDob()
        {
            return new string[] { "1/31/1995", "7/9/2001",  "2/3/1999",  "2/13/1998",
                                  "8/3/1999",  "7/14/1997", "6/20/1995", "12/26/1999",
                                  "5/19/1995", "3/2/2001",  "7/2/1994",  "8/9/1999",
                                  "2/12/1992", "8/7/1995",  "3/16/1995", "7/14/1996",
                                  "11/8/2000", "7/10/1984", "7/3/1990",  "7/13/1987",};
        }

        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
