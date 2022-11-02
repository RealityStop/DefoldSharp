namespace DefaultNamespace
{
	public static class Debug
	{
		/// <summary>
		///     @CSharpLua.Template = "sys.get_engine_info().is_debug"
		/// </summary>
		public extern static bool IsEditorDebug();


		static Debug()
		{
			if (IsEditorDebug())
			{
				_debuggingEnabled = true;
				
				_hook = _getHook(out _mask, out _count);
			}
		}


		/// <summary>
		///     @CSharpLua.Template = "debug.gethook()"
		/// </summary>
		private static extern object _getHook(out object mask, out object count);
		
		
		/// <summary>
		///     @CSharpLua.Template = "debug.sethook()"
		/// </summary>
		private static extern object _setHook();
		
		/// <summary>
		///     @CSharpLua.Template = "debug.sethook({0},{1},{2})"
		/// </summary>
		private static extern object _setHook(object hook, object mask, object count);
		

		private static object _hook;
		private static object _mask;
		private static object _count;
		private static bool _debuggingEnabled = true;


		public static void SetEditorDebug(bool shouldDebug = true)
		{
			if (!IsEditorDebug())
				return;
			
			if (shouldDebug)
			{
				_setHook(_hook, _mask, _count);
				_debuggingEnabled = true;
			}
			else
			{
				_setHook();
				_debuggingEnabled = false;
			}
		}
		
		public static bool ToggleEditorDebug()
		{
			if (!IsEditorDebug())
				return false;

			SetEditorDebug(!_debuggingEnabled);
			return _debuggingEnabled;
		}
	}
}