using System;

using CommandLine;

namespace TestIt.Api.Configuration
{
    [Serializable]
    public class Config
    {
        [Option('h', "host", Required = false)]
        public string? Host { get; set; }

        [Option('t', "private-token", Required = false)]
        public string? PrivateToken { get; set; }

        [Option('s', "settings-file", Required = false)]
        public string? ConfigFile { get; set; }
    }
}
