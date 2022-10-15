using System;
using types;

/// <summary>
/// Timer API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class timer
{
	/// <summary>
	/// Adds a timer and returns a unique handle
	/// You may create more timers from inside a timer callback.
	/// Using a delay of 0 will result in a timer that triggers at the next frame just before
	/// script update functions.
	/// If you want a timer that triggers on each frame, set delay to 0.0f and repeat to true.
	/// Timers created within a script will automatically die when the script is deleted.
	/// 
	/// @CSharpLua.Template = "timer.delay({0}, {1}, {2})"
	/// </summary>
	public static extern Hash delay(double delay_p1, bool repeat_p2, Action<object,Hash,double> callback_p3);
	
	
	/// <summary>
	/// You may cancel a timer from inside a timer callback.
	/// Cancelling a timer that is already executed or cancelled is safe.
	/// 
	/// @CSharpLua.Template = "timer.cancel({0})"
	/// </summary>
	public static extern bool cancel(Hash handle_p1);
	
	
	/// <summary>
	/// Manual triggering a callback for a timer.
	/// 
	/// @CSharpLua.Template = "timer.trigger({0})"
	/// </summary>
	public static extern bool trigger(Hash handle_p1);
	
	
}
