using vscode:

https://www.youtube.com/watch?v=fuBi4d7k1-M

# Build and Export

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
