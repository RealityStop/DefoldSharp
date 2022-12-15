namespace DefoldSharp
{
	/// <summary>
	/// HTML5 API documentation
	/// 
	/// </summary>
	public static class Html5
	{
		#region Defold API
		/// <summary>
		/// Executes the supplied string as JavaScript inside the browser.
		/// A call to this function is blocking, the result is returned as-is, as a string.
		/// (Internally this will execute the string using the <code>eval()</code> JavaScript function.)
		/// 
		/// @CSharpLua.Template = "html5.run({0})"
		/// </summary>
		public static extern string run(string code_p1);


		/// <summary>
		/// Set a JavaScript interaction listener callaback from lua that will be
		/// invoked when a user interacts with the web page by clicking, touching or typing.
		/// The callback can then call DOM restricted actions like requesting a pointer lock,
		/// or start playing sounds the first time the callback is invoked.
		/// 
		/// @CSharpLua.Template = "html5.set_interaction_listener()"
		/// </summary>
		public static extern void set_interaction_listener();


		#endregion Defold API
	}
}
