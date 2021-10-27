using System;
using System.IO;
using System.Net.Http;

using CommandLine;

using Newtonsoft.Json;

using TestIt.Api.Configuration;

namespace TestIt.Api
{
    public class ClientsManager : IDisposable
    {
        private const string HostEnv = "TESTIT_HOST";
        private const string PrivateTokenEnv = "TESTIT_PRIVATE_TOKEN";
        private const string SettingsFileEnv = "TESTIT_API_SETTINGS_FILE";

        private readonly HttpClient _httpClient;

        public ClientsManager() : this(default(ApiSettings)) { }

        public ClientsManager(string settingsFilePath) :
            this(new ApiSettings { SettingsFilePath = settingsFilePath }) { }

        public ClientsManager(ApiSettings? settings)
        {
            settings ??= new ApiSettings();
            EnrichFromFile(settings, settings.SettingsFilePath);
            EnrichFromEnv(settings);
            EnrichFromCli(settings);

            if (string.IsNullOrWhiteSpace(settings.Host))
                throw new ConfigurationException(nameof(settings.Host));

            if (string.IsNullOrWhiteSpace(settings.PrivateToken))
                throw new ConfigurationException(nameof(settings.PrivateToken));

            _httpClient = InitializeHttpClient(settings);

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

        private static HttpClient InitializeHttpClient(ApiSettings settings)
        {
            var apiUri = new UriBuilder(Uri.UriSchemeHttp, settings.Host!, 80).Uri;

            var httpClient = new HttpClient
            {
                BaseAddress = apiUri,
                DefaultRequestHeaders =
                {
                    { "Authorization", $"PrivateToken {settings.PrivateToken!}" }
                }
            };

            return httpClient;
        }

        private static void MergeSettings(ApiSettings target, ApiSettings additional)
        {
            target.Host = additional.Host ?? target.Host;
            target.PrivateToken = additional.PrivateToken ?? target.PrivateToken;
        }

        private static void EnrichFromFile(ApiSettings settings, string? filePath)
        {
            if (filePath is null)
                return;

            if (!File.Exists(filePath))
                return;

            var settingsFileData = File.ReadAllText(filePath);

            ApiSettings parsedSettings;

            try
            {
                parsedSettings = JsonConvert.DeserializeObject<ApiSettings>(settingsFileData)
                    ?? throw new JsonSerializationException();
            }
            catch (JsonSerializationException)
            {
                return;
            }

            MergeSettings(settings, parsedSettings);
        }

        private static void EnrichFromEnv(ApiSettings settings)
        {
            var host = Environment.GetEnvironmentVariable(HostEnv);
            var privateToken = Environment.GetEnvironmentVariable(PrivateTokenEnv);
            var settingsFilePath = Environment.GetEnvironmentVariable(SettingsFileEnv);

            var parsedSettings = new ApiSettings
            {
                Host = host,
                PrivateToken = privateToken,
                SettingsFilePath = settingsFilePath
            };

            EnrichFromFile(settings, parsedSettings.SettingsFilePath);
            MergeSettings(settings, parsedSettings);
        }

        private static void EnrichFromCli(ApiSettings settings)
        {
            var parsedSettings = new ApiSettings();

            Parser.Default
               .ParseArguments<ApiSettings>(Environment.GetCommandLineArgs())
               .WithParsed(s => parsedSettings = s);

            EnrichFromFile(settings, parsedSettings.SettingsFilePath);
            MergeSettings(settings, parsedSettings);
        }
    }
}
