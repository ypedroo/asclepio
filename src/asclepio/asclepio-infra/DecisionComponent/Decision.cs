using asclepio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asclepio_infra.DecisionComponent
{
    public class Decision : IDecision
    {
        public Patient Analyze(Patient patient)
        {
            var dizziness = patient.AngleTilted != 180 ? true : false;
            patient.IsDizzy = dizziness;

            return patient;
        }
    }
}
