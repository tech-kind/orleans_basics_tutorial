using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansBasics
{
    public class HelloGain : Orleans.Grain, IHello
    {
        private readonly ILogger _logger;

        public HelloGain(ILogger<HelloGain> logger)
        {
            _logger = logger;
        }

        ValueTask<string> IHello.SayHello(string greeting)
        {
            _logger.LogInformation($"\n SayHello message received: greeting = '{greeting}'");
            return ValueTask.FromResult($"\n Client said: '{greeting}', so HelloGain says: Hello!");
        }
    }
}
