# Test IT TMS API client for .NET
![Test IT](https://raw.githubusercontent.com/testit-tms/api-client-dotnet/master/images/banner.png)

# Getting Started

## Prerequisites
This library uses **.NET Standard 2.0**. For list of supported runtimes check out [official .NET Standard documentation](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

Supported platforms depend on .NET runtime.

## Installation

### NuGet CLI
```
Install-Package TestIt.ApiClient
```

### .NET CLI
```
dotnet package add TestIt.ApiClient
```

## Compatibility

| Test IT | API Client |
|---------|------------|
| 3.3     | 1.0        |
| 3.4     | 1.1        |
| 3.5     | 1.2        |

# Usage

## Configuration

To use client you need to provide configuration to `TestItApiClient`. There 4 ways to do it (sorted by priority ascending):

1. `TestItApiConfig` object
```cs
var config = new TestItApiConfig
{
    ServerAddress = "example.com",
    PrivateToken = "ExampleToken"
};

var client = new TestItApiClient(config);
```

2. JSON-file
```json
{
    "serverAddress": "example.com",
    "privateToken": "ExampleToken"
}
```
```cs
var client = new TestItApiClient("/path/to/file.json");
```

3. Path to JSON-file from `TESTIT_CONFIG_FILE` environment variable
4. Server address and private token from `TESTIT_SERVER_ADDRESS` and `TESTIT_PRIVATE_TOKEN` environment variables respectively

5. Path to JSON-file from CLI arguments
```bash
./yourapp --testit-config-file "path/to/file.json"
```

6. Server address and private token from CLI arguments
```bash
./yourapp --testit-server-address "example.com" --testit-private-token "ExampleToken"
```

After configuration is done you can access different clients from `TestItApiClient` object and then use methods to control Test IT.

## Examples

### Get project list
```cs
var client = new TestItApiClient();
var projects = await client.Projects.GetAllProjectsAsync();
```

### Create test-case
```cs
var client = new TestItApiClient();

var project = (await client.Projects.GetAllProjectsAsync()).First();
var rootSection = (await client.Projects.GetSectionsByProjectIdAsync(project.Id.ToString())).First();

var workItemModel = new WorkItemPostModel
{
    EntityTypeName = WorkItemEntityTypes.TestCases,
    State = WorkItemStates.Ready,
    Priority = WorkItemPriorityModel.Medium,
    Name = "Example test-case",
    ProjectId = project.Id!.Value,
    SectionId = rootSection.Id!.Value
};

var createdWorkItem = await client.WorkItems.CreateWorkItemAsync(workItemModel);
```

# Contributing

Most of the code in this repository was automatically generated with [NSwag](https://github.com/RicoSuter/NSwag).
Nevertheless you can help to develop the project. Any contributions are **greatly appreciated**.

* If you have suggestions for adding or removing projects, feel free to [open an issue](https://github.com/testit-tms/dotnet-rest-client/issues/new) to discuss it, or directly create a pull request after you edit the *README.md* file with necessary changes.
* Please make sure you check your spelling and grammar.
* Create individual PR for each suggestion.
* Please also read through the [Code Of Conduct](https://github.com/testit-tms/dotnet-rest-client/blob/master/CODE_OF_CONDUCT.md) before posting your first idea as well.

# License

Distributed under the Apache-2.0 License. See [LICENSE](https://github.com/testit-tms/dotnet-rest-client/blob/master/LICENSE.md) for more information.

