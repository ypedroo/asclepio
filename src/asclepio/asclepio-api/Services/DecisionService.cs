using asclepio.infra.DecisionComponent.Models;
using asclepio_infra.DecisionComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asclepio_api.Services
{
    public class DecisionService
    {
        private readonly IDecision _decision;

        public DecisionService(IDecision decision)
        {
            _decision = decision;
        }

        public Patient AnalyzePatient(Patient patient)
        {
            var analyzedPatient = _decision.Analyze(patient);
            return analyzedPatient;
        }
    }
}
