using asclepio.infra.DecisionComponent.Models;
using asclepio.infra.Repositories;
using asclepio.infra.DecisionComponent;

namespace asclepio.api.Services
{
    public class DecisionService : IDecisionService
    {
        private readonly IDecision _decision;
        private readonly IPatientRepository _patientRepository; 

        public DecisionService(IDecision decision, IPatientRepository patientRepository)
        {
            _decision = decision;
            _patientRepository = patientRepository;
        }

        public Patient GetAnalyzedPatient(string id)
        {
            var patient = _patientRepository.GetPatient(id);
            var analyzedPatient = _decision.Analyze(patient);
            if (analyzedPatient.IsDizzy && analyzedPatient.AngleTilted == 0)
            {
                analyzedPatient.ShouldCallEmergency = true;
            }
            return analyzedPatient;
        }
    }
}
