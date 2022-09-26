using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Built-ins API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class builtins
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "builtins.pprint({0})"
		/// </summary>
		public static extern void pprint(LuaType v_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "builtins.hash({0})"
		/// </summary>
		public static extern Hash hash(string s_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "builtins.hash_to_hex({0})"
		/// </summary>
		public static extern string hash_to_hex(Hash h_p1);
		
		
	}
}
