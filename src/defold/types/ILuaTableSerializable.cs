using System;

namespace types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public interface ILuaTableSerializable
	{
		ILuaTable ToTable();
	}
}
