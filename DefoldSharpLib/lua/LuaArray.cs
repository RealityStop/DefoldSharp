using System;

namespace DefoldSharp
{
	public abstract class LuaArrayBase : ILuaType
	{
		
	}
	
	
	/// <summary>
	/// An array of a particular type.
	/// </summary>
	/// <typeparam name="TValue"></typeparam>
	public class LuaArrayOf<TValue> : LuaArrayBase
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>
		public LuaArrayOf()
		{
		}
	}
	
	
	/// <summary>
	/// </summary>
	public class LuaArray : LuaArrayOf<LuaType>
	{
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>
		public LuaArray()
		{
		}
		
		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>
		public static extern LuaArray Create();


		/// <summary>
		/// @CSharpLua.Template = "{}"
		/// </summary>
		public static extern LuaArrayOf<TValue> Create<TValue>();




		/// <summary>
		/// @CSharpLua.Template = "#{0}"
		/// </summary>
		public static LuaArrayOf<TValue> Create<TValue>(params TValue[] initialValues)
		{
			var newArray = Create<TValue>();

			foreach (var initialValue in initialValues)
			{
				newArray.Add(initialValue);
			}

			return newArray;
		}



		/// <summary>
		/// @CSharpLua.Template = "{{0}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1);



		/// <summary>
		/// @CSharpLua.Template = "{{0}, {1}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1, TValue value2);


		/// <summary>
		/// @CSharpLua.Template = "{{0},{1},{2}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1, TValue value2, TValue value3);


		/// <summary>
		/// @CSharpLua.Template = "{{0},{1},{2},{3}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1, TValue value2, TValue value3,
			TValue value4);


		/// <summary>
		/// @CSharpLua.Template = "{{0},{1},{2},{3},{4}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1, TValue value2, TValue value3,
			TValue value4, TValue value5);


		/// <summary>
		/// @CSharpLua.Template = "{{0},{1},{2},{3},{4},{5}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1, TValue value2, TValue value3,
			TValue value4, TValue value5, TValue value6);


		/// <summary>
		/// @CSharpLua.Template = "{{0},{1},{2},{3},{4},{5},{6}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1, TValue value2, TValue value3,
			TValue value4, TValue value5, TValue value6, TValue value7);


		/// <summary>
		/// @CSharpLua.Template = "{{0},{1},{2},{3},{4},{5},{6},{7}}"
		/// </summary> 
		public extern static LuaArrayOf<TValue> Create<TValue>(TValue value1, TValue value2, TValue value3,
			TValue value4, TValue value5, TValue value6, TValue value7, TValue value8);
	}
	
	
	
	public static class __LuaArrayExt
	{
		/// <summary>
		/// @CSharpLua.Template = "#{0}"
		/// </summary> 
		public static extern int Count(this LuaArrayBase arr);
		
		
		/// <summary>
		/// Adds the value to the end of the array.
		/// 
		/// @CSharpLua.Template = "table.insert({0}, {1})"
		/// </summary>
		/// <param name="value">value to insert</param>
		public static extern void Add<TValue>(this LuaArrayOf<TValue> arr, TValue value);
		
		
		
		/// <summary>
		/// Inserts a value into the array at the specified position
		/// 
		/// @CSharpLua.Template = "table.insert({0}, {1} + 1, {2})" 
		/// </summary>
		/// <param name="index">index to insert at</param>
		/// <param name="value">value to insert</param>
		public static extern void Insert<TValue>(this LuaArrayOf<TValue> arr, int index, TValue value);
		
		
		/// <summary>
		/// Removes the element at the passed index
		/// 
		/// @CSharpLua.Template = "table.remove({0}, {1} + 1)"
		/// </summary>
		/// <param name="index">index to remove</param>
		/// <returns></returns>
		public static extern TValue Remove<TValue>(this LuaArrayOf<TValue> arr, int index);
		
		
		/// <summary>
		/// Removes the element at the passed index
		/// 
		/// @CSharpLua.Template = "table.remove({0})"
		/// </summary>
		/// <param name="index">index to remove</param>
		/// <returns></returns>
		public static extern TValue RemoveLast<TValue>(this LuaArrayOf<TValue> arr);
		

		/// <summary>
		/// Sorts table elements in a given order, in-place, from table[1] to table[n], where n is the length of the table.
		/// the standard Lua operator 'less than' is used instead. The sort algorithm is not stable; that is, elements considered equal by the given order may have their relative positions changed by the sort.
		///
		/// @CSharpLua.Template = "table.sort({0})"
		/// </summary>
		public static extern void Sort(this LuaArrayBase arr);


		/// <summary>
		/// Sorts table elements in a given order, in-place, from table[1] to table[n], where n is the length of the table.
		/// the standard Lua operator 'less than' is used instead. The sort algorithm is not stable; that is, elements considered equal by the given order may have their relative positions changed by the sort.
		///
		/// @CSharpLua.Template = "table.sort({0}, {1})"
		/// </summary>
		public static extern void Sort<TValue>(this LuaArrayOf<TValue> arr, Func<LuaType, LuaType, bool> a);
		
		
		
		/// <summary>
		/// Given an array where all elements are strings or numbers, concatenates all of them together.
		///
		/// @CSharpLua.Template = "table.concat({0})"
		/// <param name="table">The table to concatenate values</param>
		/// </summary>
		public static extern string concat(this LuaArrayBase arr);


		/// <summary>
		/// Given an array where all elements are strings or numbers, concatenates all of them together, separated by sep.
		///
		/// @CSharpLua.Template = "table.concat({0}, {1})"
		/// <param name="table">The table to concatenate values</param>
		/// <param name="separator">The separator to insert between elements.</param>
		/// </summary>
		public static extern string concat(this LuaArrayBase arr, string separator);


		/// <summary>
		/// Given an array where all elements are strings or numbers, concatenates all of them together, separated by sep, starting with startOffset.
		///
		/// @CSharpLua.Template = "table.concat({0}, {1}, {2} + 1)"
		/// <param name="table">The table to concatenate values</param>
		/// <param name="separator">The separator to insert between elements.</param>
		/// <param name="startOffset">The starting offset for the concatenation.  Zero-based.  ( + 1 in lua )</param>
		/// </summary>
		public static extern string concat(this LuaArrayBase arr, string separator, int startOffset);


		/// <summary>
		/// Given an array where all elements are strings or numbers, concatenates all of them together, separated by sep, starting with startOffset and ending at endOffset.
		///
		/// @CSharpLua.Template = "table.concat({0}, {1}, {2} + 1, {3} + 1)"
		/// </summary>
		/// <param name="table">The table to concatenate values</param>
		/// <param name="separator">The separator to insert between elements.</param>
		/// <param name="startOffset">The starting offset for the concatenation.  Zero-based.  ( + 1 in lua )</param>
		/// <param name="endOffset">The ending offset for the concatenation.  Defaults to the length of the table.  Zero-based. ( + 1 in lua )</param>
		/// <returns></returns>
		public static extern string concat(this LuaArrayBase arr, string separator, int startOffset, int endOffset);
	}
}