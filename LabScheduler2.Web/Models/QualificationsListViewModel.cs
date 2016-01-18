using LabScheduler2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabScheduler2.Web.Models
{
    public class QualificationsListViewModel
    {
        public Bench bench { get; set; }
        public List<Qualification> qualifications { get; set; }
    }
}

// LabScheduler2.Web.Models.QualificationsListViewModel