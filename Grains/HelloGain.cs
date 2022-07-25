using Microsoft.Extensions.Logging;

namespace OrleansBasics
{
    public class HelloGain : Orleans.Grain, IHello
    {
        private readonly ILogger _logger;

        public HelloGain(ILogger<HelloGain> logger)
        {
            _logger = logger;
        }

        public ValueTask<string> SayHello(string greeting)
        {
            _logger.LogInformation($"\n SayHello message received: greeting = '{greeting}'");
            return ValueTask.FromResult($"\n Client said: '{greeting}', so HelloGain says: Hello!");
        }
    }
}
