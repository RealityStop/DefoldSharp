namespace DefoldSharp
{
	/// <summary>
	/// Image API documentation
	/// 
	/// </summary>
	public static class Image
	{
		#region Defold API
		/// <summary>
		/// Load image (PNG or JPEG) from buffer.
		/// 
		/// @CSharpLua.Template = "image.load({0})"
		/// </summary>
		public static extern LuaTable load(string buffer_p1);


		/// <summary>
		/// Load image (PNG or JPEG) from buffer.
		/// 
		/// @CSharpLua.Template = "image.load({0}, {1})"
		/// </summary>
		public static extern LuaTable load(string buffer_p1, bool premult_p2);


		#endregion Defold API
	}
}
