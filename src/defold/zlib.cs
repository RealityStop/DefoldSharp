using System;
using types;

/// <summary>
/// Zlib compression API documentation
/// 
/// </summary>
public static class Zlib
{
	/// <summary>
	/// A lua error is raised is on error
	/// 
	/// @CSharpLua.Template = "zlib.inflate({0})"
	/// </summary>
	public static extern string Inflate(string buf_p1);
	
	
	/// <summary>
	/// A lua error is raised is on error
	/// 
	/// @CSharpLua.Template = "zlib.deflate({0})"
	/// </summary>
	public static extern string Deflate(string buf_p1);
	
	
}
