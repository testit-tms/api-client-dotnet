using System;

namespace TestIt.Api.Configuration
{
    public class ConfigurationException : Exception
    {
        public ConfigurationException(string propertyName) : base($"Settings option \"{propertyName}\" is missing") { }
    }
}
