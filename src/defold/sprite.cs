using System;
using support;
using types;

/// <summary>
/// Sprite API documentation
/// 
/// </summary>
public static class Sprite
{
	#region Defold API
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
	
	
	#endregion Defold API
	
	
	//Cacheables
	private bool _cachedFlipHorizontal;
	private bool _cachedFlipVertical;
	
	
	public bool FlipHorizontal
	{
	   get
	   {
	      if (IsCachingEnabled)
	         return _cachedFlipHorizontal;
	
	      throw new NotImplementedException("defold API does not provide for querying a sprite's flip state");
	   }
	   set
	   {
	      if (IsCachingEnabled)
	         _cachedFlipHorizontal = value;
	
	      Set_hflip(this, value);
	   }
	}
	
	
	public bool FlipVertical
	{
	   get
	   {
	      if (IsCachingEnabled)
	         return _cachedFlipVertical;
	
	      throw new NotImplementedException("defold API does not provide for querying a sprite's flip state");
	   }
	   set
	   {
	      if (IsCachingEnabled)
	         _cachedFlipVertical = value;
	
	      Set_vflip(this, value);
	   }
	}
	
	
	
	public Vector2 Size => (dynamic)Go.Get(this, "size");
	
	public Vector2 Scale
	{
	   get => (dynamic)Go.Get(this, "scale");
	   set => Go.Set(this, "scale", (LuaType) value);
	}
	
	public Hash Image
	{
	   get => (dynamic)Go.Get(this, "image");
	   set => Go.Set(this, "image", value);
	}
	
	public Hash Material
	{
	   get => (dynamic)Go.Get(this, "material");
	   set => Go.Set(this, "material", value);
	}
	   
	public double Cursor
	{
	   get => (dynamic)Go.Get(this, "cursor");
	   set => Go.Set(this, "cursor", value);
	}
	         
	public double PlaybackRate
	{
	   get => (dynamic)Go.Get(this, "playback_rate");
	   set => Go.Set(this, "playback_rate", value);
	}
	
	public Hash Animation => (dynamic)Go.Get(this, "animation");
	
	
	public void PlayFlipbook(Hash animation, Action<Sprite, Hash, ILuaTable, Url> onComplete = null,
	   ILuaTable playProperties = null)
	{
	   void callback(object target, Hash hash, ILuaTable table, Url url)
	   {
	      onComplete(this, hash, table, url);
	   }
	      
	   Play_flipbook(this, animation, callback, playProperties);
	}
}
