# DefoldSharp

Current generated API for Defold 1.3.6

Along with [DefoldCSharpCompiler](https://github.com/RealityStop/DefoldCSharpCompiler), this repository is the core of the DefoldSharp.  It contains a C# implementation of the C# core (using System; and other common subsets), as well as the C# version of the Defold API  (go.get_position, etc).  The intent is it offer two flavors of API:  the 1-1 defold API that should allow nearly direct conversion of any lua code (`vmath.vector3()`), and the more OOP approach (`new Vector3()`).

> NOTE:  This project is still in alpha.  Substantial issues still exist, and it is not possible to generate use for a full game yet, largely due to (https://github.com/RealityStop/DefoldSharp/issues/1)!
