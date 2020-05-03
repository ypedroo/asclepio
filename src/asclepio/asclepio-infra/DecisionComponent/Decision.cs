using asclepio.infra.DecisionComponent.Models;

namespace asclepio.infra.DecisionComponent
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
