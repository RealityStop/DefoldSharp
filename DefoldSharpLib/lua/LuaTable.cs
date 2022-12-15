namespace DefoldSharp
{
	public class LuaTableBase : ILuaType
	{
		
	}
	
	public class LuaTableOf<TKey, TValue> : LuaTableBase
	{
		
	}
	
	/// <summary>
	/// </summary>
	public class LuaTable : LuaTableOf<LuaType, LuaType>
	{
		/// <summary>
		/// Use one of the create methods instead.
		/// </summary>
		private LuaTable()
		{
			
		}
		
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary> 
		public static extern LuaTable Create();


		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary> 
		public static extern LuaTableOf<TKey, TValue> Create<TKey, TValue>();
	}
	
	
	
	public static class __LuaTableExt
	{
		/// <summary>
		/// @CSharpLua.Template = "{0}[{1}] = {2}"
		/// </summary>
		public static extern void Add<TKey, TValue>(this LuaTableOf<TKey, TValue> tbl, TKey key, TValue value);
		
		
		
		/// <summary>
		/// @CSharpLua.Template = "{0}[{1}] = nil"
		/// </summary>
		public static extern void Remove<TKey, TValue>(this LuaTableOf<TKey, TValue> tbl, TKey key);


		/// <summary>
		/// @CSharpLua.Template = for k in next, {0} do rawset({0}, k, nil) end
		/// </summary>
		public static extern void Clear(this LuaTableBase tbl);
		

		/// <summary>
		/// @CSharpLua.Template = "{0}[{1}]"
		/// </summary>
		public static extern bool ContainsKey<TKey, TValue>(this LuaTableOf<TKey, TValue> tbl,  TKey key);


		/// <summary>
		/// @CSharpLua.Template = "{0}[{1}]"
		/// </summary>
		public static extern TValue Get<TKey, TValue>(this LuaTableOf<TKey, TValue> tbl, TKey key);

		
		/// <summary>
		/// @CSharpLua.Template = "{0}[{1}] = {2}"
		/// </summary>
		public static extern void Set<TKey, TValue>(this LuaTableOf<TKey, TValue> tbl, TKey key, TValue value);
	}
}
