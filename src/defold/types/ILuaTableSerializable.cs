using System;
using lua;

namespace types
{
	/// <summary>
	/// </summary>
	public interface ILuaTableSerializable
	{
		LuaTable ToTable();
	}
}
