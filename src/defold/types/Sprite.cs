using System;
using support;

namespace types
{
	public class __SpriteData : ICachedData
	{
		public bool FlipHorizontal;
		public bool FlipVertical;
	}	
	
	public class Sprite : CachingComponentReference<__SpriteData>
	{
		public bool FlipHorizontal
		{
			get
			{
				if (TryGetCacheData(out var data))
					return data.FlipVertical;

				throw new NotImplementedException("defold API does not provide for querying a sprite's flip state");
			}
			set
			{
				if (TryGetCacheData(out var data))
					data.FlipVertical = value;

				sprite.set_hflip(this, value);
			}
		}
		
		public bool FlipVertical
		{
			get
			{
				if (TryGetCacheData(out var data))
					return data.FlipHorizontal;

				throw new NotImplementedException("defold API does not provide for querying a sprite's flip state");
			}
			set
			{
				if (TryGetCacheData(out var data))
					data.FlipHorizontal = value;

				sprite.set_vflip(this, value);
			}
		}


		public Vector2 Size => (dynamic)go.get(this, "size");

		public Vector2 Scale
		{
			get => (dynamic)go.get(this, "scale");
			set => go.set(this, "scale", (LuaType) value);
		}

		public Hash Image
		{
			get => (dynamic)go.get(this, "image");
			set => go.set(this, "image", value);
		}

		public Hash Material
		{
			get => (dynamic)go.get(this, "material");
			set => go.set(this, "material", value);
		}
		
		public double Cursor
		{
			get => (dynamic)go.get(this, "cursor");
			set => go.set(this, "cursor", value);
		}
				
		public double PlaybackRate
		{
			get => (dynamic)go.get(this, "playback_rate");
			set => go.set(this, "playback_rate", value);
		}

		public Hash Animation => (dynamic)go.get(this, "animation");


		public void PlayFlipbook(Hash animation, Action<Sprite, Hash, ILuaTable, Url> onComplete = null,
			ILuaTable playProperties = null)
		{
			void callback(object target, Hash hash, ILuaTable table, Url url)
			{
				onComplete(this, hash, table, url);
			}
			
			sprite.play_flipbook(this, animation, callback, playProperties);
		}
	}
}