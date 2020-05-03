using asclepio.api.Services;
using asclepio.infra.DecisionComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace asclepio.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IDecisionService _decisionService;
        public PatientController(IDecisionService decisionService)
        {
            _decisionService = decisionService;
        }

        [HttpGet("{id}")]
        public Patient Get(string id)
        {
           return _decisionService.GetAnalyzedPatient(id);
        }
    }
}
