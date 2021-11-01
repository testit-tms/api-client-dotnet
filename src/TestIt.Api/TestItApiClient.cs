using System;
using System.IO;
using System.Net.Http;

using CommandLine;

using Newtonsoft.Json;

using TestIt.Api.Configuration;

namespace TestIt.Api
{
    public class TestItApiClient : IDisposable
    {
        private const string ServerAddressEnv = "TESTIT_SERVER_ADDRESS";
        private const string PrivateTokenEnv = "TESTIT_PRIVATE_TOKEN";
        private const string ConfigFileEnv = "TESTIT_CONFIG_FILE";

        private readonly HttpClient _httpClient;

        public TestItApiClient() : this(default(TestItApiConfig)) { }

        public TestItApiClient(string configFile) :
            this(new TestItApiConfig { ConfigFile = configFile }) { }

        public TestItApiClient(TestItApiConfig? config)
        {
            config ??= new TestItApiConfig();
            EnrichFromFile(config, config.ConfigFile);
            EnrichFromEnv(config);
            EnrichFromCli(config);

            if (string.IsNullOrWhiteSpace(config.ServerAddress))
                throw new ConfigurationException(nameof(config.ServerAddress));

            if (string.IsNullOrWhiteSpace(config.PrivateToken))
                throw new ConfigurationException(nameof(config.PrivateToken));

            _httpClient = InitializeHttpClient(config);

            Attachments = new AttachmentsClient(_httpClient);
            AutoTests = new AutoTestsClient(_httpClient);
            Configurations = new ConfigurationsClient(_httpClient);
            Parameters = new ParametersClient(_httpClient);
            Projects = new ProjectsClient(_httpClient);
            Sections = new SectionsClient(_httpClient);
            TestPlans = new TestPlansClient(_httpClient);
            TestResults = new TestResultsClient(_httpClient);
            TestRuns = new TestRunsClient(_httpClient);
            TestSuites = new TestSuitesClient(_httpClient);
            WorkItems = new WorkItemsClient(_httpClient);
        }

        public AttachmentsClient Attachments { get; }
        public AutoTestsClient AutoTests { get; }
        public ConfigurationsClient Configurations { get; }
        public ParametersClient Parameters { get; }
        public ProjectsClient Projects { get; }
        public SectionsClient Sections { get; }
        public TestPlansClient TestPlans { get; }
        public TestResultsClient TestResults { get; }
        public TestRunsClient TestRuns { get; }
        public TestSuitesClient TestSuites { get; }
        public WorkItemsClient WorkItems { get; }

        public void Dispose()
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
        }

        private static HttpClient InitializeHttpClient(TestItApiConfig config)
        {
            var apiUri = new Uri(config.ServerAddress!);

            var httpClient = new HttpClient
            {
                BaseAddress = apiUri,
                DefaultRequestHeaders =
                {
                    { "Authorization", $"PrivateToken {config.PrivateToken!}" }
                }
            };

            return httpClient;
        }

        private static void MergeConfigurations(TestItApiConfig target, TestItApiConfig additional)
        {
            target.ServerAddress = additional.ServerAddress ?? target.ServerAddress;
            target.PrivateToken = additional.PrivateToken ?? target.PrivateToken;
        }

        private static void EnrichFromFile(TestItApiConfig config, string? file)
        {
            if (file is null)
                return;

            if (!File.Exists(file))
                return;

            var configFileData = File.ReadAllText(file);

            TestItApiConfig parsedConfig;

            try
            {
                parsedConfig = JsonConvert.DeserializeObject<TestItApiConfig>(configFileData)
                    ?? throw new JsonSerializationException();
            }
            catch (JsonSerializationException)
            {
                return;
            }

            MergeConfigurations(config, parsedConfig);
        }

        private static void EnrichFromEnv(TestItApiConfig config)
        {
            var host = Environment.GetEnvironmentVariable(ServerAddressEnv);
            var privateToken = Environment.GetEnvironmentVariable(PrivateTokenEnv);
            var configFile = Environment.GetEnvironmentVariable(ConfigFileEnv);

            var parsedConfig = new TestItApiConfig
            {
                ServerAddress = host,
                PrivateToken = privateToken,
                ConfigFile = configFile
            };

            EnrichFromFile(config, parsedConfig.ConfigFile);
            MergeConfigurations(config, parsedConfig);
        }

        private static void EnrichFromCli(TestItApiConfig config)
        {
            var parsedConfig = new TestItApiConfig();

            Parser.Default
               .ParseArguments<TestItApiConfig>(Environment.GetCommandLineArgs())
               .WithParsed(c => parsedConfig = c);

            EnrichFromFile(config, parsedConfig.ConfigFile);
            MergeConfigurations(config, parsedConfig);
        }
    }
}
