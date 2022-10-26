using System;
using support;
using types;

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
	
	
	#endregion Defold API
}
