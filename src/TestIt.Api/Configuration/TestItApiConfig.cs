using System;

using CommandLine;

namespace TestIt.Api.Configuration
{
    [Serializable]
    public class TestItApiConfig
    {
        [Option("testit-server-address", Required = false)]
        public string? ServerAddress { get; set; }

        [Option("testit-private-token", Required = false)]
        public string? PrivateToken { get; set; }

        [Option("testit-config-file", Required = false)]
        public string? ConfigFile { get; set; }
    }
}
