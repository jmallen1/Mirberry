using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Mirberry.Services
{
    public class TestConsoleWriter
    {
        private readonly ILogger<TestConsoleWriter> _logger;

        public TestConsoleWriter(ILogger<TestConsoleWriter> logger)
        {
            _logger = logger;
        }

        public void SendMessage(string to, string subject, string body)
        {
            _logger.LogInformation("test");
        }
    }
}
