using System;

namespace DefoldSharp
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public static class table
	{
		/// <summary>
		///
		/// @CSharpLua.Template = "#{0}"
		/// </summary> 
		public static extern int length(LuaArrayBase arr);
		
		
		/// <summary>
		/// Given an array where all elements are strings or numbers, concatenates all of them together.
		///
		/// @CSharpLua.Template = "table.concat({0})"
		/// <param name="table">The table to concatenate values</param>
		/// </summary>
		public static extern string concat(LuaArrayBase arr);


		/// <summary>
		/// Given an array where all elements are strings or numbers, concatenates all of them together, separated by sep.
		///
		/// @CSharpLua.Template = "table.concat({0}, {1})"
		/// <param name="table">The table to concatenate values</param>
		/// <param name="separator">The separator to insert between elements.</param>
		/// </summary>
		public static extern string concat(LuaArrayBase arr, string separator);


		/// <summary>
		/// Given an array where all elements are strings or numbers, concatenates all of them together, separated by sep, starting with startOffset.
		///
		/// @CSharpLua.Template = "table.concat({0}, {1}, {2} + 1)"
		/// <param name="table">The table to concatenate values</param>
		/// <param name="separator">The separator to insert between elements.</param>
		/// <param name="startOffset">The starting offset for the concatenation.  Zero-based.  ( + 1 in lua )</param>
		/// </summary>
		public static extern string concat(LuaArrayBase arr, string separator, int startOffset);


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
		public static extern string concat(LuaArrayBase arr, string separator, int startOffset, int endOffset);
		
		
		/// <summary>
		/// Inserts a value at the end of the table.
		///
		/// @CSharpLua.Template = "table.insert({0}, {1})"
		/// </summary>
		/// <param name="table">The table to insert values into</param>
		/// <param name="value">The value to insert</param>
		public static extern void insert<T>(LuaArrayBase arr, T value);

		
		/// <summary>
		/// Inserts a value at a position in the table, shifting up other elements to open space, if necessary.
		///
		/// @CSharpLua.Template = "table.insert({0}, {1} + 1, {2})" 
		/// </summary>
		/// <param name="table">The table to insert values into</param>
		/// <param name="pos">The position to insert at.  Zero-based</param>
		/// <param name="value">The value to insert</param>
		/// <typeparam name="T"></typeparam>
		public static extern void insert<T>(LuaArrayBase arr, int pos, T value);
		
		
		
		/// <summary>
		/// Returns the largest positive numerical index of the given table, or zero if the table has no positive numerical indices. (To do its job this function does a linear traversal of the whole table.)
		///
		/// @CSharpLua.Template = "table.maxn({0})"
		/// </summary>
		/// <param name="table">The table to scan</param>
		public static extern void maxn(LuaArrayBase arr);


		/// <summary>
		/// Removes the last element of the table.
		///
		/// @CSharpLua.Template = "table.remove({0})"
		/// </summary>
		/// <param name="table">The table to trim</param>
		public static extern dynamic remove(LuaArrayBase arr);


		/// <summary>
		/// Removes from table the element at position pos, shifting down other elements to close the space, if necessary. Returns the value of the removed element
		///
		/// @CSharpLua.Template = "table.remove({0}, {1} + 1)"
		/// </summary>
		/// <param name="pos">The position to remove.  Zero-based</param>
		/// <param name="table">The table to trim</param>
		public static extern dynamic remove(LuaArrayBase arr, int pos);


		/// <summary>
		/// Sorts table elements in a given order, in-place, from table[1] to table[n], where n is the length of the table.
		/// the standard Lua operator 'less than' is used instead. The sort algorithm is not stable; that is, elements considered equal by the given order may have their relative positions changed by the sort.
		///
		/// @CSharpLua.Template = "table.sort({0})"
		/// </summary>
		/// <param name="table">The table to sort</param>
		public static extern void sort(LuaArrayBase arr);


		/// <summary>
		/// Sorts table elements in a given order, in-place, from table[1] to table[n], where n is the length of the table.
		/// the standard Lua operator 'less than' is used instead. The sort algorithm is not stable; that is, elements considered equal by the given order may have their relative positions changed by the sort.
		///
		/// @CSharpLua.Template = "table.sort({0}, {1})"
		/// </summary>
		/// <param name="table">The table to sort</param>
		public static extern void sort(LuaArrayBase arr, Func<ILuaType, ILuaType, bool> comparator);
	}
}