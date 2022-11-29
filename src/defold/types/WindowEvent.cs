using System;
using lua;

namespace types
{
	/// <summary>
	/// </summary>
	public enum WindowEvent
	{
		WINDOW_EVENT_FOCUS_LOST = 0,
		WINDOW_EVENT_FOCUS_GAINED = 1,
		WINDOW_EVENT_RESIZED = 2,
		WINDOW_EVENT_ICONIFIED = 3,
		WINDOW_EVENT_DEICONIFIED = 4,
	}
}
