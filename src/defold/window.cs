using System;
using support;
using lua;
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
	public static extern void set_listener(Action<object,WindowEvent,LuaTable> callback_p1);


	/// <summary>
	/// Set the locking state for current mouse cursor on a PC platform.
	/// This function locks or unlocks the mouse cursor to the center point of the window. While the cursor is locked,
	/// mouse position updates will still be sent to the scripts as usual.
	/// 
	/// @CSharpLua.Template = "window.set_mouse_lock({0})"
	/// </summary>
	public static extern void set_mouse_lock(bool flag_p1);


	/// <summary>
	/// <span class="icon-ios"></span> <span class="icon-android"></span> Sets the dimming mode on a mobile device.
	/// The dimming mode specifies whether or not a mobile device should dim the screen after a period without user interaction. The dimming mode will only affect the mobile device while the game is in focus on the device, but not when the game is running in the background.
	/// This function has no effect on platforms that does not support dimming.
	/// 
	/// @CSharpLua.Template = "window.set_dim_mode({0})"
	/// </summary>
	public static extern void set_dim_mode(WindowDimming mode_p1);


	/// <summary>
	/// <span class="icon-ios"></span> <span class="icon-android"></span> Returns the current dimming mode set on a mobile device.
	/// The dimming mode specifies whether or not a mobile device should dim the screen after a period without user interaction.
	/// On platforms that does not support dimming, <code>window.DIMMING_UNKNOWN</code> is always returned.
	/// 
	/// @CSharpLua.Template = "window.get_dim_mode()"
	/// </summary>
	public static extern WindowDimming get_dim_mode();


	/// <summary>
	/// This returns the current window size (width and height).
	/// 
	/// @CSharpLua.Template = "window.get_size()"
	/// </summary>
	public static extern double get_size(out double height_o1);


	/// <summary>
	/// This returns the current lock state of the mouse cursor
	/// 
	/// @CSharpLua.Template = "window.get_mouse_lock()"
	/// </summary>
	public static extern bool get_mouse_lock();


	#endregion Defold API
}
