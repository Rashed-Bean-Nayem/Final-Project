﻿using System;
using System.Collections.Generic;
using System.Text;
using Demo.DataAccessLayer;

namespace Demo.Foundation.Entities
{
    public class ElectionCandidate:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string NID { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IList<PdfList> PdfListUrl { get; set; }
        public string Motto { get; set; }
        public string LogoImageUrl { get; set; }
        public string DateOfBirth { get; set; }

    }
}
