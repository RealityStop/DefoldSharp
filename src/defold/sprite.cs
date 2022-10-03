using System;
using types;

/// <summary>
/// Sprite API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class sprite
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sprite.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(string url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sprite.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Hash url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sprite.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Url url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sprite.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(string url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sprite.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Hash url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sprite.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Url url_p1, bool flip_p2);
		
		
}