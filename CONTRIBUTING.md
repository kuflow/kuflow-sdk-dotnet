# Developing kuflow-sdk-dotnet

This doc is intended for contributors to `kuflow-sdk-dotnet` repository. See also the contribution guide for each module in this repository.

## Development Environment

Main tools:

- .Net Core: 6.0.408
- NodeJs: 18

Optionally you can use a version management tool like [ASDF](https://github.com/asdf-vm/asdf). In that case, the project is distributed with the appropriate `.tool-versions` file.

To keep things as simple as possible, these instructions cover managing your project using the .net CLI. However, you can use any IDE like Visual Studio. Or for lightweight cross-platform development, you can use Visual Studio Code. These instructions may help you:

Using .Net in Visual Studio Code

- https://www.youtube.com/watch?v=fuBi4d7k1-M

## Develop

### Code generation for the rest client

The Azure AutoRest tool is used for the generation of client code for the KuFlow Rest Api. This tool requires NodeJs for its execution. If you want to update the OpenApi definition, the client must be recreated:

```bash
cd kuflow-rest/etc/openapi

# Install dependencies
npm ci

npm run generate
```

Some manual adjustments may be necessary, such as extending the generated code or modifying it.

### Build

To build a package:

```bash
## Build the project
dotnet build

## Create an exportable .dll (if needed)

### Debug
dotnet publish --configuration Debug --self-contained

## Release
dotnet publish --configuration Release --self-contained

### Create a Nuget Package

## Debug
dotnet pack --configuration Debug

### Release
dotnet pack --configuration Release

### Publish to Nuget
dotnet nuget push kuflow-rest/bin/Release/KuFlow.Rest.X.X.X.nupkg --api-key YOUR_API_KEY --source https://api.nuget.org/v3/index.jso

```

Some other examples of .Net commands:

```bash
# Create a new solution
dotnet new sln --name kuflow-sdk-dotnet

# List available templates
dotnet new list

# Use template
dotnet new gitignore

# Create a console project
dotnet new console -f net6.0 --name "TestConsole"

# Create a lib project
dotnet new classlib -f net6.0 --name "Kuflow.Rest"

# Add project to solution
dotnet sln kuflow-sdk-dotnet add kuflow-rest/Kuflow.Rest

# Add references between projects
dotnet add TestConsole/TestConsole.csprok reference kuflow-rest/Kuflow.Rest.csproj

# Add a NuGet package
cd kuflow-rest
dotnet add package Azure.Core
```
