using System;
using types;

/// <summary>
/// Window API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class window
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "window.set_listener({0})"
	/// </summary>
	public static extern void set_listener(Action<object,WindowEvent,ILuaTable> callback_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "window.set_dim_mode({0})"
	/// </summary>
	public static extern void set_dim_mode(WindowDimming mode_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "window.get_dim_mode()"
	/// </summary>
	public static extern WindowDimming get_dim_mode();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "window.get_size()"
	/// </summary>
	public static extern double get_size(out double height_o1);
		
		
}