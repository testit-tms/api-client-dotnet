# Test IT .NET RESTful API client
![Test IT](/images/banner.png)

# Getting Started

## Prerequisites
This library uses **.NET Standard 2.0**. For list of supported runtimes check out [official .NET Standard documentation](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

Supported platforms depend on .NET runtime.

## Installation

### NuGet CLI
```
Install-Package TestIt.Api
```

### .NET CLI
```
dotnet package add TestIt.Api
```

# Usage

## Configuration

To use client you need to provide configuration to `TestItClientManager`. There 4 ways to do it (sorted by priority ascending):

1. `TestItApiConfig` object
```cs
var config = new TestItApiConfig
{
    Host = "example.com",
    PrivateToken = "ExampleToken"
};

var clientsManager = new TestItClientsManager(config);
```

2. JSON-file
```json
{
    "host": "example.com",
    "privateToken": "ExampleToken"
}
```
```cs
var clientsManager = new TestItClientsManager("/path/to/file.json");
```

3. Path to JSON-file from `TESTIT_CONFIG_FILE` environment variable
4. Host address and private token from `TESTIT_HOST` and `TESTIT_PRIVATE_TOKEN` environment variables respectively

5. Path to JSON-file from CLI arguments
```bash
./yourapp --testit-config-file "path/to/file.json"
```

6. Host address and private token from CLI arguments
```bash
./yourapp --testit-host "example.com" --testit-private-token "ExampleToken"
```

After configuration is done you can access different clients from clients manager and then use methods to control Test IT.

## Examples

### Get project list
```cs
var clientsManager = new TestItClientsManager();
var projects = await clientsManager.ProjectsClient.GetAllProjectsAsync();
```

### Create test-case
```cs
var clientsManager = new TestItClientsManager();

var project = (await clientsManager.ProjectsClient.GetAllProjectsAsync()).First();
var rootSection = (await clientsManager.ProjectsClient.GetSectionsByProjectIdAsync(project.Id.ToString())).First();

var workItemModel = new WorkItemPostModel
{
    EntityTypeName = WorkItemEntityTypes.TestCases,
    State = WorkItemStates.Ready,
    Priority = WorkItemPriorityModel.Medium,
    Name = "Example test-case",
    ProjectId = project.Id!.Value,
    SectionId = rootSection.Id!.Value
};

var createdWorkItem = await clientsManager.WorkItemsClient.CreateWorkItemAsync(workItemModel);
```

# Contributing

Most of the code in in this repository was automatically generated with [NSwag](https://github.com/RicoSuter/NSwag).
Nevertheless you can help to develop the project. Any contributions are **greatly appreciated**.

* If you have suggestions for adding or removing projects, feel free to [open an issue](https://github.com/testit-tms/dotnet-rest-client/issues/new) to discuss it, or directly create a pull request after you edit the *README.md* file with necessary changes.
* Please make sure you check your spelling and grammar.
* Create individual PR for each suggestion.
* Please also read through the [Code Of Conduct](https://github.com/testit-tms/dotnet-rest-client/blob/master/CODE_OF_CONDUCT.md) before posting your first idea as well.

# License

Distributed under the Apache-2.0 License. See [LICENSE](https://github.com/testit-tms/dotnet-rest-client/blob/master/LICENSE.md) for more information.

