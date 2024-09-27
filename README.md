# Multi target Fable project

This repositories shows how a Fable library requiring different dependencies for different targets can be built.

It uses specialized NuGet packages for each target, allowing to re-use the same source code if needed.

Intellisense and code completion work as expected thanks to the `fsproj` files having their `DefineConstants`
to restrict the compilation to the desired target.

This repository use different solution files to help some IDEs. For example, Rider doesn't need the
different solution files, because it can infer from which project you are navigating.

But others like VSCode, needs you to choose which solution file to open, like that only the projects for
that target will be loaded.

## Compiling for JavaScript

```bash
dotnet fable src/MyApp.JavaScript.fsproj --outDir fableBuild --runScript
```

## Compiling for Python

```bash
dotnet fable src/MyApp.Python.fsproj --outDir fableBuild --lang python --runScript
```

When running Python generated code I get an error at runtime, and I am not sure why. However, the code demonstrated should still be valid.

```text
ImportError: attempted relative import with no known parent package
```
