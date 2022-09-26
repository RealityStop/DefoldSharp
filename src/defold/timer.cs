using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Timer API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class timer
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "timer.delay({0}, {1}, {2})"
		/// </summary>
		public static extern Hash delay(double delay_p1, bool repeat_p2, Action<object,Hash,double> callback_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "timer.cancel({0})"
		/// </summary>
		public static extern bool cancel(Hash handle_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "timer.trigger({0})"
		/// </summary>
		public static extern bool trigger(Hash handle_p1);
		
		
	}
}
