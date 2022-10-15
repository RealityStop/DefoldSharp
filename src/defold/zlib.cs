using System;
using types;

/// <summary>
/// Zlib compression API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class zlib
{
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
	
	
}
