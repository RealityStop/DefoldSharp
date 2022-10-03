namespace support
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public static class InputHelpers
	{
		/// <summary>
		/// @CSharpLua.Template = "msg.post('.', 'acquire_input_focus')"
		/// </summary>
		public static extern void RequestInput();
		
		/// <summary>
		/// @CSharpLua.Template = "msg.post('.', 'release_input_focus')"
		/// </summary>
		public static extern void ReleaseInput();
	}
}