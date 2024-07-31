Source code for article
[Why developers should know how to build NuGet package(s)?](https://medium.com/@anton.baksheiev_61725/why-developers-should-know-how-to-build-nuget-package-s-545d237d581d)

Solution:

```
|   NugetDemo.ConsoleApp.sln
|   README.md
|
+---NugetDemo.ConsoleApp
|       NugetDemo.ConsoleApp.csproj
|       Program.cs
|
+---NugetDemo.PackageDemo
|       NugetDemo.PackageDemo.csproj
|       Utils.cs
|
\---nugets
    \---Debug
        |   NugetDemo.PackageDemo.1.0.1.nupkg
        |
        \---net8.0
```
