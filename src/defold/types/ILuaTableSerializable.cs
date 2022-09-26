using System;
using defold;

namespace defold.types
{

	public interface ILuaTableSerializable
	{
		ILuaTable ToTable();
	}
}
