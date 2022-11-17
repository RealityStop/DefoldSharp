using System;

namespace types
{
	/// <summary>
	/// </summary>
	public class LuaArray : LuaTableOf<int, LuaType>
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary> 
		public extern LuaArray();
	}
}
