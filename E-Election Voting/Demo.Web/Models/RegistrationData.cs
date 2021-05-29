using Autofac;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Demo.Foundation.Contexts;
using System.IO;

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


        public IList<PdfList> PdfListUrl { get; set; }











        [Required(ErrorMessage = "Please select the Candidate")]
        public int? CID1 { get; set; }
        [Required(ErrorMessage = "Please select the Candidate")]
        public int? CID2 { get; set; }
        public IList<ElectionCandidate> ElectionCandidates { get; set; }
        private const string IMAGE_PATH = "temp";
        private readonly IGetService _getService;
        private readonly RegistrationContext _registrationContext;
        public RegistrationData(IGetService getService, RegistrationContext registrationContext)
        {
            _getService = getService;
            _registrationContext = registrationContext;
        }
        public RegistrationData()
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
            _registrationContext = Startup.AutofacContainer.Resolve<RegistrationContext>();
        }
        public void LoadCandidates()
        {
            ElectionCandidates = ConvertToCandidates( _getService.GetCandidateList());
        }
        public List<ElectionCandidate>  ConvertToCandidates(IList<ElectionCandidate> electionCandidates)
        {
            var electionCandidateObj = new List<ElectionCandidate>();
          
            foreach (var itemS in electionCandidates)
            {
                electionCandidateObj.Add(
                    _registrationContext.ElectionCandidates.Where(x => x.Id == itemS.Id).Select(item => new ElectionCandidate()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Address = item.Address,
                        Description = item.Description,
                        Mobile = item.Mobile,
                        NID = item.NID,
                        ImageUrl = FormatFileUrl(item.ImageUrl),
                        Motto = item.Motto,
                        LogoImageUrl = FormatFileUrl(item.LogoImageUrl),
                        DateOfBirth=item.DateOfBirth,
                        PdfListUrl = item.PdfListUrl.Select(g => new PdfList()
                        {
                            Id = g.Id,
                            Name = g.Name,
                            URL = FormatFileUrl(g.URL)
                        }).ToList()
                    }).FirstOrDefault()                 
                    );
            }
            return electionCandidateObj;
        }
        private static string FormatFileUrl(string filePath)
        {
            return $"/{IMAGE_PATH}/{Path.GetFileName(filePath)}";
        }
    }
}
