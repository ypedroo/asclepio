using asclepio.infra.DecisionComponent.Models;

namespace asclepio_api.Services
{
    public interface IDecisionService
    {
        public Patient GetAnalyzedPatient(Patient patient); 
    }
}
