using System;

namespace attributes
{
	/// <summary>
	///     Flags a class as needing to be generated to .script file.  This is almost always done
	///     by deriving from the GameObjectScript class.
	///     @CSharpLua.Ignore
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class GenGOScriptAttribute : Attribute
	{
	}
}