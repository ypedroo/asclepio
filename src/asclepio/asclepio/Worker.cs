using asclepio.infra.DecisionComponent.Models;
using asclepio_infra.DecisionComponent;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace asclepio
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IDecision _decisionTool;

        public Worker(ILogger<Worker> logger, IDecision decisionTool)
        {
            _logger = logger;
            _decisionTool = decisionTool;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {                
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);                
                await Task.Delay(1000, stoppingToken);
            }
        }
        public Patient AnalyzePatient(Patient patient)
        {
            var analyzedPatient = _decisionTool.Analyze(patient);
            return analyzedPatient;
        }

    }
}
