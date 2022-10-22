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
	/// Sets horizontal flipping of the provided sprite's animations.
	/// The sprite is identified by its URL.
	/// If the currently playing animation is flipped by default, flipping it again will make it appear like the original texture.
	/// 
	/// @CSharpLua.Template = "sprite.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(string url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Sets horizontal flipping of the provided sprite's animations.
	/// The sprite is identified by its URL.
	/// If the currently playing animation is flipped by default, flipping it again will make it appear like the original texture.
	/// 
	/// @CSharpLua.Template = "sprite.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Hash url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Sets horizontal flipping of the provided sprite's animations.
	/// The sprite is identified by its URL.
	/// If the currently playing animation is flipped by default, flipping it again will make it appear like the original texture.
	/// 
	/// @CSharpLua.Template = "sprite.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Url url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Sets vertical flipping of the provided sprite's animations.
	/// The sprite is identified by its URL.
	/// If the currently playing animation is flipped by default, flipping it again will make it appear like the original texture.
	/// 
	/// @CSharpLua.Template = "sprite.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(string url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Sets vertical flipping of the provided sprite's animations.
	/// The sprite is identified by its URL.
	/// If the currently playing animation is flipped by default, flipping it again will make it appear like the original texture.
	/// 
	/// @CSharpLua.Template = "sprite.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Hash url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Sets vertical flipping of the provided sprite's animations.
	/// The sprite is identified by its URL.
	/// If the currently playing animation is flipped by default, flipping it again will make it appear like the original texture.
	/// 
	/// @CSharpLua.Template = "sprite.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Url url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1})"
	/// </summary>
	public static extern void play_flipbook(string url_p1, Hash id_p2);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1}, {2})"
	/// </summary>
	public static extern void play_flipbook(string url_p1, Hash id_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void play_flipbook(string url_p1, Hash id_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3, ILuaTable play_properties_p4);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1})"
	/// </summary>
	public static extern void play_flipbook(Hash url_p1, Hash id_p2);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1}, {2})"
	/// </summary>
	public static extern void play_flipbook(Hash url_p1, Hash id_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void play_flipbook(Hash url_p1, Hash id_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3, ILuaTable play_properties_p4);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1})"
	/// </summary>
	public static extern void play_flipbook(Url url_p1, Hash id_p2);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1}, {2})"
	/// </summary>
	public static extern void play_flipbook(Url url_p1, Hash id_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
	
	
	/// <summary>
	/// Play an animation on a sprite component from its tile set
	/// An optional completion callback function can be provided that will be called when
	/// the animation has completed playing. If no function is provided,
	/// a <a href="#animation_done">animation_done</a> message is sent to the script that started the animation.
	/// 
	/// @CSharpLua.Template = "sprite.play_flipbook({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void play_flipbook(Url url_p1, Hash id_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3, ILuaTable play_properties_p4);
	
	
}
