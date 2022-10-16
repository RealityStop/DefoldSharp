using System;

namespace types
{
	public interface ILuaTableSerializable
	{
		ILuaTable ToTable();
	}
}
