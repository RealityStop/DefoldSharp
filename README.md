

# DefoldSharp

Early C# support for the Defold game engine.  This is implemented as a transpiler that will convert valid C# to valid lua with Defold game integrations provided.

> ⚠️ This project is Deprecated.  The Defold game engine now has official first-party C# support, and no further development will occur on this project.

During Alpha, only the current Defold version has integrations generated.  This is currently Defold 1.4.0.

## Overview

Along with [DefoldCSharpCompiler](https://github.com/RealityStop/DefoldCSharpCompiler), this repository is the core of the DefoldSharp.  It contains a C# implementation of the C# core (`using System;` and other common subsets), as well as the C# version of the Defold API  (`go.get_position`, etc).  The intent is to offer two flavors of API:  the 1-1 Defold API that should allow nearly direct conversion of any lua code (`vmath.vector3()`), and the more OOP approach (`new Vector3()`).

Additionally, during the compilation process, DefoldSharp needs to create `.script` files for component scripts.

### Defold 1-1 API
DefoldSharp includes a 1-1 api, with static classes for each lua namespace.  You can access the C# version just as you would in lua.  For example, `go.get_position()`, `vmath.matrix4_frustum(...)`.

```C#
 var newVector = vmath.vector(0,1,0);
 newVector = newVector * speed * dt;
 newVector = vmath.normalize(newVector);
```

### Defold OOP API
DefoldSharp also provides a convenience OOP API, such as

```C#
 var newVector = new Vector3(0,1,0);
 newVector *= speed * dt;
 newVector = newVector.Normalize();
```


### C# core
DefoldSharp includes a custom version of CSharp.lua's CoreSystem.lua, which includes lua implementations of [System](https://github.com/RealityStop/DefoldSharp/wiki/CoreSystem-system-includes)

### Script generation
DefoldSharp's transpiler will detect and create .script and .gui_script files for classes that derive from `GameObjectScript` and `GUIScript` respectively.  For the alpha, these generated Defold scripts are passthrough stubs due to a limitation in the underlying transpiler.  See [Issue 2](https://github.com/RealityStop/DefoldSharp/issues/2) for the technical explanation and progress on working around it.


## Getting Started

Go to [releases](https://github.com/RealityStop/DefoldSharp/releases) and follow the instructions there.


# Alpha
The alpha has been released.  The goal for this Alpha is the "minimum viable product" of being able to take a project from C# to Defold.  As a benchmark, the War Battles tutorial was used to ensure that a wide variety of requirements were met (messages, properties, user interface, custom message passing).  You can follow the examples link below to see how that was accomplished.

## Alpha limitations

* Most of C# is supported.  For now, the included project file limits C# to C# 7 but, since it runs with Roslyn, in principle some of the newer features are supported.  I'm just not sure where those boundaries are.  Bump the version number up at your risk.
* Reflection is not supported.
* For now, single-assembly code is supported.  Importing directly from dlls/nuget will never be supported, as we aren't decompiling the 3rd party code to generate lua from.  However, 3rd-party assemblies that you have the code for should be able to be compiled such that they output a special lua export that can be imported into your DefoldSharp project.  How to do this will be expanded in the future, and the main Defold api will be moved out this way as well..  In Alpha 1, everything must be in the same project.
* All C# code is contained in the generated out.lua file, with simple stubs being generated for the `.script` and `.gui_script files`.  See [Issue 2](https://github.com/RealityStop/DefoldSharp/issues/2) for progress on moving the logic to the generated files.
* Hot Reload does NOT work.  This is because the logic is contained in secondary scripts (this is required to support inheritance), rather than in the actual .script.  I am unsure if this is something that can be worked around.


## Examples
Can be found [here](https://github.com/RealityStop/DefoldSharpExamples) 


# Roadmap

The future of DefoldSharp is planned to be an old school `several alphas -> several betas -> release` track.  During Alpha, the goal is to refine the API, tools and approaches used in solving the various challenges.  The API is not stable, and the tool should not be used on production projects (unless you're willing to rewrite).  Certain features may change wildly between Alphas as new approaches are found and explored.  Once the feature set seems like it could support a full project, we'll transition to the Beta track.  Once in Beta, the API should be fairly stable, with spot fixes to correct cases turned up by the community.  During this time several prototypes should be constructed as real world tests of the platform.  Once those appear to be producing solid results, we'll transition to Release.

Here's a short glimpse into the immediate future  (all are subject to change, and may include features not mentioned here:

## Upcoming Alphas:
### Alpha 5
 * Assembly support
