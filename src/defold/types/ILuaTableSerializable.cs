using System;

namespace types
{
	/// <summary>
	/// </summary>
	public interface ILuaTableSerializable
	{
		ILuaTable ToTable();
	}
}
