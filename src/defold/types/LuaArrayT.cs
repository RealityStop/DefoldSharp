using System;

namespace types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class LuaArray<TValue> : LuaTableOf<int, TValue>
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary> 
		public extern LuaArray();
		
		
		/// <summary>
		/// @CSharpLua.Template = "{this}[{0} + 1]"
		/// </summary>
		public override extern TValue Get(int key);


		/// <summary>
		/// @CSharpLua.Template = "{this}[{0} + 1] = {1}"
		/// </summary>
		public override extern void Set(int key, TValue value);
	}
}
