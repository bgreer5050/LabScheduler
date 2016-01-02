﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabScheduler2.Domain
{
    public class Qualification
    {
        public int Id { get; set; }
        public Employee employee { get; set; }
        public Bench bench { get; set; }
        public QualificationStatus Status { get; set; }
    }

    public enum QualificationStatus
    {
    NonePlanned,
    Planned,
    InTraining,
    Qualified,
    Disqualified
    }
}
