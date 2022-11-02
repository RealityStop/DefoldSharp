using System;
using support;
using types;

/// <summary>
/// Lua math standard library
/// 
/// </summary>
public static class Math
{
	#region Defold API
	/// <summary>
	/// This function is an interface to the simple
	/// pseudo-random generator function rand provided by ANSI C.
	/// (No guarantees can be given for its statistical properties.)
	/// When called without arguments,
	/// returns a uniform pseudo-random real number
	/// in the range [0,1).
	/// When called with an integer number m,
	/// math.random returns
	/// a uniform pseudo-random integer in the range [1, m].
	/// When called with two integer numbers m and n,
	/// math.random returns a uniform pseudo-random
	/// integer in the range [m, n].
	/// 
	/// @CSharpLua.Template = "math.random()"
	/// </summary>
	public static extern float random();

	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0})"
	/// </summary>
	public static extern float random(double m);

	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0}, {1})"
	/// </summary>
	public static extern float random(double m, double n);
	
	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0})"
	/// </summary>
	public static extern int random(int m);

	
	/// <summary>
	/// @CSharpLua.Template = "math.random({0}, {1})"
	/// </summary>
	public static extern int random(int m, int n);
	
	#endregion Defold API
	
	
	
}
