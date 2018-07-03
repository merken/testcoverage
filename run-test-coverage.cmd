dotnet test calculation.tests/calculation.tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
dotnet build-server shutdown
dotnet sonarscanner begin /k:"calculation" /d:sonar.host.url=http://localhost:9000 /d:sonar.cs.opencover.reportsPaths="calculation.tests\coverage.opencover.xml" /d:sonar.coverage.exclusions="**Tests*.cs"
dotnet build
dotnet sonarscanner end