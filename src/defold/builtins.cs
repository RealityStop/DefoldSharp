using System;
using support;
using lua;
using types;

/// <summary>
/// Built-ins API documentation
/// 
/// </summary>
public static class Builtins
{
	#region Defold API
	/// <summary>
	/// Pretty printing of Lua values. This function prints Lua values
	/// in a manner similar to +print()+, but will also recurse into tables
	/// and pretty print them. There is a limit to how deep the function
	/// will recurse.
	/// 
	/// @CSharpLua.Template = "builtins.pprint({0})"
	/// </summary>
	public static extern void pprint(LuaType v_p1);


	/// <summary>
	/// All ids in the engine are represented as hashes, so a string needs to be hashed
	/// before it can be compared with an id.
	/// 
	/// @CSharpLua.Template = "builtins.hash({0})"
	/// </summary>
	public static extern Hash hash(string s_p1);


	/// <summary>
	/// Returns a hexadecimal representation of a hash value.
	/// The returned string is always padded with leading zeros.
	/// 
	/// @CSharpLua.Template = "builtins.hash_to_hex({0})"
	/// </summary>
	public static extern string hash_to_hex(Hash h_p1);


	#endregion Defold API
}
