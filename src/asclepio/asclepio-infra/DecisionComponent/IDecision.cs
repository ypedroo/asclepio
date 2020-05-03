using asclepio.infra.DecisionComponent.Models;

namespace asclepio.infra.DecisionComponent
{
    public interface IDecision
    {
        public Patient Analyze(Patient patient);
    }
}
