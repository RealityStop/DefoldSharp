using System;
using support;
using types;

/// <summary>
/// Sprite API documentation
/// 
/// </summary>
public class Sprite : BuiltInComponentBase
{
	#region Defold API
	#region Messages
	/// <summary>
	/// </summary>
	public class play_animation_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("play_animation");
		public override Hash FetchCode() => __CODE__;
		
		public Hash id;
	}
	
	
	/// <summary>
	/// </summary>
	public class animation_done_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("animation_done");
		public override Hash FetchCode() => __CODE__;
		
		public double current_tile;
		public Hash id;
	}
	
	
	#endregion Messages
	
	
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
	
	
	#endregion Defold API
	
	
	private bool _cachedFlipHorizontal;
	private bool _cachedFlipVertical;
	
	
	public bool FlipHorizontal
	{
	   get
	   {
	      return _cachedFlipHorizontal;
	   }
	   set
	   {
	      _cachedFlipHorizontal = value;
	      set_hflip(this, value);
	   }
	}
	
	
	public bool FlipVertical
	{
	   get
	   {
	      return _cachedFlipVertical;
	   }
	   set
	   {
	      _cachedFlipVertical = value;
	
	      set_vflip(this, value);
	   }
	}
	
	
	public Vector2 Size => (dynamic)Go.get(this, "size");
	
	public Vector2 Scale
	{
	   get => (dynamic)Go.get(this, "scale");
	   set => Go.set(this, "scale", value);
	}
	
	public Hash Image
	{
	   get => (dynamic)Go.get(this, "image");
	   set => Go.set(this, "image", value);
	}
	
	public Hash Material
	{
	   get => (dynamic)Go.get(this, "material");
	   set => Go.set(this, "material", value);
	}
	
	public double Cursor
	{
	   get => (dynamic)Go.get(this, "cursor");
	   set => Go.set(this, "cursor", value);
	}
	
	public double PlaybackRate
	{
	   get => (dynamic)Go.get(this, "playback_rate");
	   set => Go.set(this, "playback_rate", value);
	}
	
	public Hash Animation => (dynamic)Go.get(this, "animation");
	
	
	public void PlayFlipbook(Hash animation)
	{
	   play_flipbook(this, animation);
	}
	
	
	public void PlayFlipbook(Hash animation, Action<Sprite, Hash, ILuaTable, Url> onComplete)
	{
	   void callback(object target, Hash hash, ILuaTable table, Url url)
	   {
	      onComplete(this, hash, table, url);
	   }
	
	   play_flipbook(this, animation, callback);
	}
	
	
	public void PlayFlipbook(Hash animation, Action<Sprite, Hash, ILuaTable, Url> onComplete,
	   ILuaTable playProperties)
	{
	   void callback(object target, Hash hash, ILuaTable table, Url url)
	   {
	      onComplete(this, hash, table, url);
	   }
	
	   play_flipbook(this, animation, callback, playProperties);
	}
}
