namespace BackgroundServices
{
    public class BackgroundServiceDemo : BackgroundService
    {
        private readonly ILogger<BackgroundServiceDemo> _logger;

        public BackgroundServiceDemo(ILogger<BackgroundServiceDemo> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var period = new PeriodicTimer(TimeSpan.FromSeconds(15));

            while (await period.WaitForNextTickAsync(stoppingToken))
            {
                _logger.LogInformation("Bu Background Service har 15 sekunda shu xabarni qayta qayta yozib turadi");

            } ;
        }
    }
}

