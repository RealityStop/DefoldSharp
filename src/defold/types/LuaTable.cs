using System;

namespace types
{
	/// <summary>
	/// </summary>
	public class LuaTable : LuaTableOf<LuaType, LuaType>, ILuaType
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary> 
		public extern LuaTable();
	}
}
