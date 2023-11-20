namespace BackgroundServices
{
    public class HostedServiceDemo : IHostedService
    {
        private readonly ILogger<HostedServiceDemo> _logger;

        public HostedServiceDemo(ILogger<HostedServiceDemo> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedService interfacening StartAsync methodi ishga tushdi");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedService interfacening StopAsync methodi ishga tushdi");
            return Task.CompletedTask;
        }
    }
}

