using System;
using support;
using lua;
using types;

/// <summary>
/// Zlib compression API documentation
/// 
/// </summary>
public static class Zlib
{
	#region Defold API
	/// <summary>
	/// A lua error is raised is on error
	/// 
	/// @CSharpLua.Template = "zlib.inflate({0})"
	/// </summary>
	public static extern string inflate(string buf_p1);


	/// <summary>
	/// A lua error is raised is on error
	/// 
	/// @CSharpLua.Template = "zlib.deflate({0})"
	/// </summary>
	public static extern string deflate(string buf_p1);


	#endregion Defold API
}
