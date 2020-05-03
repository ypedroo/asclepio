using asclepio.Models;

namespace asclepio_infra.DecisionComponent
{
    public interface IDecision
    {
        public Patient Analyze(Patient patient);
    }
}
