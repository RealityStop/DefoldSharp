using System;
using types;

/// <summary>
/// HTTP API documentation
/// 
/// </summary>
public static class Http
{
	/// <summary>
	/// Perform a HTTP/HTTPS request.
	/// <span class="icon-attention"></span> If no timeout value is passed, the configuration value "network.http_timeout" is used. If that is not set, the timeout value is <code>0</code> (which blocks indefinitely).
	/// 
	/// @CSharpLua.Template = "http.request({0}, {1}, {2})"
	/// </summary>
	public static extern void Request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3);
	
	
	/// <summary>
	/// Perform a HTTP/HTTPS request.
	/// <span class="icon-attention"></span> If no timeout value is passed, the configuration value "network.http_timeout" is used. If that is not set, the timeout value is <code>0</code> (which blocks indefinitely).
	/// 
	/// @CSharpLua.Template = "http.request({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void Request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3, ILuaTable headers_p4);
	
	
	/// <summary>
	/// Perform a HTTP/HTTPS request.
	/// <span class="icon-attention"></span> If no timeout value is passed, the configuration value "network.http_timeout" is used. If that is not set, the timeout value is <code>0</code> (which blocks indefinitely).
	/// 
	/// @CSharpLua.Template = "http.request({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern void Request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3, ILuaTable headers_p4, string post_data_p5);
	
	
	/// <summary>
	/// Perform a HTTP/HTTPS request.
	/// <span class="icon-attention"></span> If no timeout value is passed, the configuration value "network.http_timeout" is used. If that is not set, the timeout value is <code>0</code> (which blocks indefinitely).
	/// 
	/// @CSharpLua.Template = "http.request({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void Request(string url_p1, string method_p2, Action<object,Hash,ILuaTable> callback_p3, ILuaTable headers_p4, string post_data_p5, ILuaTable options_p6);
	
	
}
