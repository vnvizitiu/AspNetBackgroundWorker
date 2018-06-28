namespace AspNetBackgroundWorker
{
    using Microsoft.Extensions.Logging;

    public class BackgroundWorker
    {
        private readonly ILogger<BackgroundWorker> _logger;

        private int _counter;

        public BackgroundWorker(ILogger<BackgroundWorker> logger)
        {
            _counter = 0;
            _logger = logger;
        }

        public void Execute()
        {
            _logger.LogDebug(_counter.ToString());
            _counter++;
        }
    }
}