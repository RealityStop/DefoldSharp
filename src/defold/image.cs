using System;
using types;

/// <summary>
/// Image API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class image
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "image.load({0})"
	/// </summary>
	public static extern ILuaTable load(string buffer_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "image.load({0}, {1})"
	/// </summary>
	public static extern ILuaTable load(string buffer_p1, bool premult_p2);
		
		
}