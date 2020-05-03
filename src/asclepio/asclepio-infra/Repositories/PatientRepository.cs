using asclepio.infra.DecisionComponent.Models;
using MongoDB.Driver;

namespace asclepio.infra.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Patient> _patientCollection;

        public PatientRepository()
        {
            _client = new MongoClient("mongodb://localhost:17017");
            _database = _client.GetDatabase("local");
            _patientCollection = _database.GetCollection<Patient>("patients");
        }
        public Patient GetPatient(string idPatient)
        {
            //fix query
            var filter = Builders<Patient>.Filter.Eq("firstname", idPatient);
            var result = _patientCollection.Find(filter).FirstOrDefault();
            return result;
        }
    }
}
