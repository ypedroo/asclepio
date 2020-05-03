using asclepio.infra.DecisionComponent.Models;
using asclepio_infra.DecisionComponent;

namespace asclepio.api.Services
{
    public class DecisionService : IDecisionService
    {
        private readonly IDecision _decision;

        public DecisionService(IDecision decision)
        {
            _decision = decision;
        }

        public Patient GetAnalyzedPatient(Patient patient)
        {
            var analyzedPatient = _decision.Analyze(patient);
            if (analyzedPatient.IsDizzy && analyzedPatient.AngleTilted == 0)
            {
                analyzedPatient.ShouldCallEmergency = true;
            }
            return analyzedPatient;
        }
    }
}
