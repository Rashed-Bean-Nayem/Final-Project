using Autofac;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Demo.Web.Models
{
    public class RegistrationData
    {
        [Required(ErrorMessage = "Please enter the Election Name")]
        [Display(Name = "Election Name")]
        public string ElectionName { get; set; }
        [Required(ErrorMessage = "Please select the Election Date")]
        [Display(Name = "Election Date")]
        [DataType(DataType.Date)]
        public DateTime? ElectionDate { get; set; }
        [Required(ErrorMessage = "Please select the Candidate")]
        public int? CID1 { get; set; }
        [Required(ErrorMessage = "Please select the Candidate")]
        public int? CID2 { get; set; }
        public IList<ElectionVoter> ElectionVoters { get; set; }
        public IList<ElectionCandidate> ElectionCandidates { get; set; }

        private readonly IGetService _getService;
        public RegistrationData(IGetService getService)
        {
            _getService = getService;
        }
        public RegistrationData()
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
        }
        public void LoadCandidates()
        {
            ElectionCandidates = _getService.GetCandidateList();
        }
    }
}
