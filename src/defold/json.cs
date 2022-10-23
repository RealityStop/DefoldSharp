using System;
using types;

/// <summary>
/// JSON API documentation
/// 
/// </summary>
public static class Json
{
	/// <summary>
	/// Decode a string of JSON data into a Lua table.
	/// A Lua error is raised for syntax errors.
	/// 
	/// @CSharpLua.Template = "json.decode({0})"
	/// </summary>
	public static extern ILuaTable Decode(string json_p1);
	
	
}
