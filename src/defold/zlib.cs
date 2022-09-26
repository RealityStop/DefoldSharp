using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Zlib compression API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class zlib
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "zlib.inflate({0})"
		/// </summary>
		public static extern string inflate(string buf_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "zlib.deflate({0})"
		/// </summary>
		public static extern string deflate(string buf_p1);
		
		
	}
}
