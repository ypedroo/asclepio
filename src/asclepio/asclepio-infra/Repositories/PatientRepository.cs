using asclepio.infra.DecisionComponent.Models;
using MongoDB.Driver;

namespace asclepio.infra.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Patient> _patientCollection;

        public PatientRepository(string connectionString)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("local");
            _patientCollection = _database.GetCollection<Patient>("patients");
        }
        public Patient GetPatient(string idPatient)
        {
            var filter = Builders<Patient>.Filter.Eq("_id", idPatient);
            var result = _patientCollection.Find(filter).FirstOrDefault();
            return result;
        }
    }
}
