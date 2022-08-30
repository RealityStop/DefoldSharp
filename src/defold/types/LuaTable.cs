using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;

namespace src2.defold.types
{
	//Stand-in for an actual LuaTable.
	public interface ILuaTable
	{

	}
	
	//Something that can be turned into a table.
	public interface ILuaTableSerializable
	{
		ILuaTable ToTable();
	}


	public static class ExpandoObjectExt
	{
		public static ILuaTable ToTable(this ExpandoObject obj)
		{
			/*
		   [[
		   local table = {}
		   ]]*/
			foreach (var keyValue in obj)
			{
				/*
		   [[
		   table[keyValue.Key] = keyValue.Value 
		   ]]*/
			}

			return ReturnTable();
		}


		/// <summary>
		/// @CSharpLua.Template = "table"
		/// </summary>					
		private static extern ILuaTable ReturnTable();
	}

	
	public abstract class LuaTableBase : ILuaTable
	{
		
	}
	

	public class LuaTableOf<TKey, TValue> : LuaTableBase
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>	
		public extern LuaTableOf();


		/// <summary>
		/// @CSharpLua.Template = "{this}[{0}] = {1}"
		/// </summary>	
		public extern void Add(TKey key, TValue value);


		/// <summary>
		/// @CSharpLua.Template = "{this}.{0} = nil"
		/// </summary>
		public extern bool Remove(TKey key);


		/// <summary>
		/// @CSharpLua.Template = for k in next, {this} do rawset({this}, k, nil) end
		/// </summary>
		public extern void Clear();


		/// <summary>
		/// @CSharpLua.Template = "{this}[{0}]"
		/// </summary>
		public extern bool ContainsKey(TKey key);
	
		/// <summary>
		/// @CSharpLua.Template = "{this}[{0}]"
		/// </summary>
		public extern LuaType Get(TKey key);
		
		
		/// <summary>
		/// @CSharpLua.Template = "{this}[{0}] = {1}"
		/// </summary>
		public extern void Set(TKey key, TValue value);
	}

	public class LuaTable : LuaTableOf<LuaType, LuaType>
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>	
		public extern LuaTable();
	}

	public class LuaArray : LuaTableOf<int, LuaType>
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>	
		public extern LuaArray();
	}	
	
	public class LuaArray<TValue> : LuaTableOf<int, TValue>
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>	
		public extern LuaArray();
	}	
}