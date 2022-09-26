using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// JSON API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class json
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "json.decode({0})"
		/// </summary>
		public static extern ILuaTable decode(string json_p1);
		
		
	}
}
