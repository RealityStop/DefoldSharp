using System;
using types;

/// <summary>
/// Window API documentation
/// 
/// </summary>
public static class Window
{
	/// <summary>
	/// Sets a window event listener.
	/// 
	/// @CSharpLua.Template = "window.set_listener({0})"
	/// </summary>
	public static extern void Set_listener(Action<object,WindowEvent,ILuaTable> callback_p1);
	
	
	/// <summary>
	/// <span class="icon-ios"></span> <span class="icon-android"></span> Sets the dimming mode on a mobile device.
	/// The dimming mode specifies whether or not a mobile device should dim the screen after a period without user interaction. The dimming mode will only affect the mobile device while the game is in focus on the device, but not when the game is running in the background.
	/// This function has no effect on platforms that does not support dimming.
	/// 
	/// @CSharpLua.Template = "window.set_dim_mode({0})"
	/// </summary>
	public static extern void Set_dim_mode(WindowDimming mode_p1);
	
	
	/// <summary>
	/// <span class="icon-ios"></span> <span class="icon-android"></span> Returns the current dimming mode set on a mobile device.
	/// The dimming mode specifies whether or not a mobile device should dim the screen after a period without user interaction.
	/// On platforms that does not support dimming, <code>window.DIMMING_UNKNOWN</code> is always returned.
	/// 
	/// @CSharpLua.Template = "window.get_dim_mode()"
	/// </summary>
	public static extern WindowDimming Get_dim_mode();
	
	
	/// <summary>
	/// This returns the current window size (width and height).
	/// 
	/// @CSharpLua.Template = "window.get_size()"
	/// </summary>
	public static extern double Get_size(out double height_o1);
	
	
}
