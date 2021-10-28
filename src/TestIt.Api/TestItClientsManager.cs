using System;
using System.IO;
using System.Net.Http;

using CommandLine;

using Newtonsoft.Json;

using TestIt.Api.Configuration;

namespace TestIt.Api
{
    public class TestItClientsManager : IDisposable
    {
        private const string HostEnv = "TESTIT_HOST";
        private const string PrivateTokenEnv = "TESTIT_PRIVATE_TOKEN";
        private const string ConfigFileEnv = "TESTIT_CONFIG_FILE";

        private readonly HttpClient _httpClient;

        public TestItClientsManager() : this(default(Config)) { }

        public TestItClientsManager(string configFile) :
            this(new Config { ConfigFile = configFile }) { }

        public TestItClientsManager(Config? config)
        {
            config ??= new Config();
            EnrichFromFile(config, config.ConfigFile);
            EnrichFromEnv(config);
            EnrichFromCli(config);

            if (string.IsNullOrWhiteSpace(config.Host))
                throw new ConfigurationException(nameof(config.Host));

            if (string.IsNullOrWhiteSpace(config.PrivateToken))
                throw new ConfigurationException(nameof(config.PrivateToken));

            _httpClient = InitializeHttpClient(config);

            AttachmentsClient = new AttachmentsClient(_httpClient);
            AutoTestsClient = new AutoTestsClient(_httpClient);
            ConfigurationsClient = new ConfigurationsClient(_httpClient);
            ParametersClient = new ParametersClient(_httpClient);
            ProjectsClient = new ProjectsClient(_httpClient);
            SectionsClient = new SectionsClient(_httpClient);
            TestPlansClient = new TestPlansClient(_httpClient);
            TestResultsClient = new TestResultsClient(_httpClient);
            TestRunsClient = new TestRunsClient(_httpClient);
            TestSuitesClient = new TestSuitesClient(_httpClient);
            WorkItemsClient = new WorkItemsClient(_httpClient);
        }

        public AttachmentsClient AttachmentsClient { get; }
        public AutoTestsClient AutoTestsClient { get; }
        public ConfigurationsClient ConfigurationsClient { get; }
        public ParametersClient ParametersClient { get; }
        public ProjectsClient ProjectsClient { get; }
        public SectionsClient SectionsClient { get; }
        public TestPlansClient TestPlansClient { get; }
        public TestResultsClient TestResultsClient { get; }
        public TestRunsClient TestRunsClient { get; }
        public TestSuitesClient TestSuitesClient { get; }
        public WorkItemsClient WorkItemsClient { get; }

        public void Dispose()
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
        }

        private static HttpClient InitializeHttpClient(Config config)
        {
            var apiUri = new UriBuilder(Uri.UriSchemeHttp, config.Host!, 80).Uri;

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

        private static void MergeConfigurations(Config target, Config additional)
        {
            target.Host = additional.Host ?? target.Host;
            target.PrivateToken = additional.PrivateToken ?? target.PrivateToken;
        }

        private static void EnrichFromFile(Config config, string? file)
        {
            if (file is null)
                return;

            if (!File.Exists(file))
                return;

            var configFileData = File.ReadAllText(file);

            Config parsedConfig;

            try
            {
                parsedConfig = JsonConvert.DeserializeObject<Config>(configFileData)
                    ?? throw new JsonSerializationException();
            }
            catch (JsonSerializationException)
            {
                return;
            }

            MergeConfigurations(config, parsedConfig);
        }

        private static void EnrichFromEnv(Config config)
        {
            var host = Environment.GetEnvironmentVariable(HostEnv);
            var privateToken = Environment.GetEnvironmentVariable(PrivateTokenEnv);
            var configFile = Environment.GetEnvironmentVariable(ConfigFileEnv);

            var parsedConfig = new Config
            {
                Host = host,
                PrivateToken = privateToken,
                ConfigFile = configFile
            };

            EnrichFromFile(config, parsedConfig.ConfigFile);
            MergeConfigurations(config, parsedConfig);
        }

        private static void EnrichFromCli(Config config)
        {
            var parsedConfig = new Config();

            Parser.Default
               .ParseArguments<Config>(Environment.GetCommandLineArgs())
               .WithParsed(s => parsedConfig = s);

            EnrichFromFile(config, parsedConfig.ConfigFile);
            MergeConfigurations(config, parsedConfig);
        }
    }
}
