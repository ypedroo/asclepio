using asclepio.api.Services;
using asclepio.infra.DecisionComponent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        // GET: api/Patient/5
        [HttpGet("{id}", Name = "Get")]
        public Patient Get(string id)
        {
            _decisionService.GetAnalyzedPatient(id);
            return null;
        }
    }
}
