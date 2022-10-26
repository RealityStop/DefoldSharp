using System;
using support;
using types;

/// <summary>
/// JSON API documentation
/// 
/// </summary>
public static class Json
{
	#region Defold API
	/// <summary>
	/// Decode a string of JSON data into a Lua table.
	/// A Lua error is raised for syntax errors.
	/// 
	/// @CSharpLua.Template = "json.decode({0})"
	/// </summary>
	public static extern ILuaTable decode(string json_p1);
	
	
	#endregion Defold API
}
