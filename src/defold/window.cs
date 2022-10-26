using System;
using support;
using types;

/// <summary>
/// Window API documentation
/// 
/// </summary>
public static class Window
{
	#region Defold API
	/// <summary>
	/// Sets a window event listener.
	/// 
	/// @CSharpLua.Template = "window.set_listener({0})"
	/// </summary>
	public static extern void set_listener(Action<> callback_p1);
	
	
	/// <summary>
	/// This returns the current window size (width and height).
	/// 
	/// @CSharpLua.Template = "window.get_size()"
	/// </summary>
	public static extern double get_size(out double height_o1);
	
	
	#endregion Defold API
}
