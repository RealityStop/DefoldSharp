using lua;

namespace types
{
	public interface ILuaType
	{
		
	}
	
	/// <summary>
	/// </summary>
	public class LuaType : ILuaType
	{
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(Url v)
		{
		   return default;
		}

		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(Hash v)
		{
		   return default;
		}

		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(string v)
		{
		   return default;
		}

		      
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(int v)
		{
		   return default;
		}

		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(float v)
		{
		   return default;
		}
		      
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(long v)
		{
		   return default;
		}

		            
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(double v)
		{
		   return default;
		}

		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(vector2 v)
		{
		   return default;
		}

		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(vector3 v)
		{
		   return default;
		}


		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(vector4 v)
		{
		   return default;
		}

		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(bool v)
		{
		   return default;
		}
		
		
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(LuaArrayBase v)
		{
			return default;
		}
		
		
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator LuaType(LuaTableBase v)
		{
			return default;
		}
	}


	public static class __LuaTypeExt
	{
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>		
		public static extern LuaType AsLuaType(this ILuaType input);
	}
}
