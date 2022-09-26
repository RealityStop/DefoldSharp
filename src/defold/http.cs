using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// HTTP API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class http
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "http.request({0}, {1}, {2})"
		/// </summary>
		public static extern void request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "http.request({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3, ILuaTable headers_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "http.request({0}, {1}, {2}, {3}, {4})"
		/// </summary>
		public static extern void request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3, ILuaTable headers_p4, string post_data_p5);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "http.request({0}, {1}, {2}, {3}, {4}, {5})"
		/// </summary>
		public static extern void request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3, ILuaTable headers_p4, string post_data_p5, ILuaTable options_p6);
		
		
	}
}
