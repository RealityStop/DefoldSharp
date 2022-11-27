using System;
using support;
using lua;
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
	public static extern LuaTable decode(string json_p1);


	/// <summary>
	/// Encode a lua table to a JSON string.
	/// A Lua error is raised for syntax errors.
	/// 
	/// @CSharpLua.Template = "json.encode({0})"
	/// </summary>
	public static extern string encode(LuaTableBase tbl_p1);


	#endregion Defold API
}
