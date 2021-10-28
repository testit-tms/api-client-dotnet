using System;

using CommandLine;

namespace TestIt.Api.Configuration
{
    [Serializable]
    public class TestItApiConfig
    {
        [Option("testit-host", Required = false)]
        public string? Host { get; set; }

        [Option("testit-private-token", Required = false)]
        public string? PrivateToken { get; set; }

        [Option("testit-config-file", Required = false)]
        public string? ConfigFile { get; set; }
    }
}
