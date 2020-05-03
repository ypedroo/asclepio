using asclepio.infra.DecisionComponent.Models;

namespace asclepio.infra.Repositories
{
    public interface IPatientRepository
    {
        public Patient GetPatient(string idPatient);
    }
}
