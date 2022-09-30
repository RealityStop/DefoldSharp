
# DefoldSharp

C# support for the Defold game engine.  This is implemented as a transpiler that will convert valid C# to valid lua with Defold game integrations provided.

> ⚠️ This project is still in Alpha.  See #roadmap for the current issues and features planned before this should be considered for production use.

During Alpha, only the current Defold version has integrations generated.  This is currently Defold 1.3.6.

## Overview

Along with [DefoldCSharpCompiler](https://github.com/RealityStop/DefoldCSharpCompiler), this repository is the core of the DefoldSharp.  It contains a C# implementation of the C# core (`using System;` and other common subsets), as well as the C# version of the Defold API  (`go.get_position`, etc).  The intent is to offer two flavors of API:  the 1-1 Defold API that should allow nearly direct conversion of any lua code (`vmath.vector3()`), and the more OOP approach (`new Vector3()`).

Additionally, during the compilation process, DefoldSharp needs to create `.script` files for component scripts.

### Defold 1-1 API
DefoldSharp includes a 1-1 api, with static classes for each lua namespace.  By adding `using defold;` you can access the C# version just as you would in lua.  For example, `go.get_position()`, `vmath.matrix4_frustum(...)`.

### Defold OOP API
DefoldSharp also provides a convenience OOP API, such as

> var newVector = new Vector3(0,1,0);
> newVector *= speed * dt;
> newVector = newVector.Normalize();



### C# core
DefoldSharp includes a custom version of CSharp.lua's CoreSystem.lua, which includes lua implementations of 

> Interfaces
Exception
Math
Number
Char
String
Boolean
Delegate
Enum
TimeSpan
DateTime
Collections.EqualityComparer
Array
Type
Collections.List
Collections.Dictionary
Collections.Queue
Collections.Stack
Collections.HashSet
Collections.LinkedList
Collections.SortedSet
Collections.SortedList
Collections.SortedDictionary
Collections.PriorityQueue
Collections.Linq
Convert
Random
Text.StringBuilder
Console
IO.File
Reflection.Assembly
Threading.Timer
Threading.Thread
Threading.Task
Utilities
Globalization.Globalization
Numerics.HashCodeHelper
Numerics.Complex
Numerics.Matrix3x2
Numerics.Matrix4x4
Numerics.Plane
Numerics.Quaternion
Numerics.Vector2
Numerics.Vector3
Numerics.Vector4
