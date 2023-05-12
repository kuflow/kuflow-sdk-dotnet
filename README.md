using vscode:

https://www.youtube.com/watch?v=fuBi4d7k1-M

## Build and Export

# build the project

dotnet build

# create an exportable .dll (if needed)

dotnet publish --configuration Release --self-contained

# create a Nuget Package

dotnet pack --configuration Release
