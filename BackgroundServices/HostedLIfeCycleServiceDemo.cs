namespace BackgroundServices
{
    public class HostedLIfeCycleServiceDemo : IHostedLifecycleService
    {
        private readonly ILogger<HostedLIfeCycleServiceDemo> _logger;

        public HostedLIfeCycleServiceDemo(ILogger<HostedLIfeCycleServiceDemo> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedLifecycleService StartAsync Methodi ishladi");
            return Task.CompletedTask;
        }

        public Task StartedAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedLifecycleService StartedAsync Methodi ishladi");
            return Task.CompletedTask;
        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedLifecycleService StartingAsync Methodi ishladi");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedLifecycleService StopAsync Methodi ishladi");
            return Task.CompletedTask;
        }

        public Task StoppedAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedLifecycleService StoppedAsync Methodi ishladi");
            return Task.CompletedTask;
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("IHostedLifecycleService StoppingAsync Methodi ishladi");
            return Task.CompletedTask;
        }
    }
}

