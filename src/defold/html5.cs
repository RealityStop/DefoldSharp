using System;
using types;

/// <summary>
/// HTML5 API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class html5
{
	/// <summary>
	/// Executes the supplied string as JavaScript inside the browser.
	/// A call to this function is blocking, the result is returned as-is, as a string.
	/// (Internally this will execute the string using the <code>eval()</code> JavaScript function.)
	/// 
	/// @CSharpLua.Template = "html5.run({0})"
	/// </summary>
	public static extern string run(string code_p1);
	
	
}
