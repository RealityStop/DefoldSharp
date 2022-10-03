using System;
using types;

/// <summary>
/// Label API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class label
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "label.set_text({0}, {1})"
	/// </summary>
	public static extern void set_text(string url_p1, string text_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "label.set_text({0}, {1})"
	/// </summary>
	public static extern void set_text(Hash url_p1, string text_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "label.set_text({0}, {1})"
	/// </summary>
	public static extern void set_text(Url url_p1, string text_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "label.get_text({0})"
	/// </summary>
	public static extern string get_text(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "label.get_text({0})"
	/// </summary>
	public static extern string get_text(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "label.get_text({0})"
	/// </summary>
	public static extern string get_text(Url url_p1);
		
		
}