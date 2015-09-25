namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ApiaryProvider.DesignTime")>]
[<assembly: AssemblyProductAttribute("ApiaryProvider")>]
[<assembly: AssemblyDescriptionAttribute("Type provider for Apiary.io http://fsprojects.github.io/ApiaryProvider")>]
[<assembly: AssemblyVersionAttribute("1.0.2")>]
[<assembly: AssemblyFileVersionAttribute("1.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.2"
