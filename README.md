# MSBuild Extension template for dotnet new

This template is functional, but the documentation is still a work-in-progress. 

## Demonstrates

* Custom MSBuild task.
    * Receiving items from MSBuild as task parameters.
    * Required (mandatory) task parameter.
    * Exposing an output task parameter to send data back to MSBuild.
* Custom `.props` / `.target` files.
    * `.targets` file uses custom task.
* Generating a NuGet package with everything in the `build` folder.
    * When installed into a project via `<PackageReference />`, the `.props` and `.targets` are automatically included in the project.

## Installing

`dotnet new -i "MSBuildExtensionTemplate::*"`

Create an issue if you have questions or would like to contribute :)
