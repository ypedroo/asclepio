using asclepio.infra.DecisionComponent.Models;

namespace asclepio.api.Services
{
    public interface IDecisionService
    {
        public Patient GetAnalyzedPatient(Patient patient); 
    }
}
