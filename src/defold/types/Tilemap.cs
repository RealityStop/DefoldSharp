using support;

namespace types
{
	public class TilemapData : ICachedData
	{
		public Rect Bounds { get; set; }
	}
	
	
	public class Tilemap : CachingComponentReference<TilemapData>
	{
		/// <summary>
		/// Gets the bounds for the tilemap.  
		/// </summary>
		/// <returns></returns>
		public Rect Bounds
		{
			get
			{
				if (TryGetCacheData(out var cachedData))
					if (cachedData.Bounds != null)
						return cachedData.Bounds;


				var x = tilemap.get_bounds(this, out var y, out var w, out var h);
				var returnVal = new Rect(x, y, w, h);

				if (IsCachingInternals)
					cachedData.Bounds = returnVal;

				return returnVal;
			}
		}


		public int GetTile(int x, int y, string layer)
		{
			return (int)tilemap.get_tile(this, layer, x, y);
		}
		
		public int GetTile(int x, int y, Hash layer)
		{
			return (int)tilemap.get_tile(this, layer, x, y);
		}


		public void SetTile(int x, int y, int tile, string layer)
		{
			ValidateCachedBounds(x, y);
			tilemap.set_tile(this, layer, x, y, tile);
		}
		public void SetTile(int x, int y, int tile, string layer, TilemapTransforms transformBitmask)
		{
			ValidateCachedBounds(x, y);
			tilemap.set_tile(this, layer, x, y, tile, (int)transformBitmask);
		}
		
		public void SetTile(int x, int y, int tile, Hash layer)
		{
			ValidateCachedBounds(x, y);
			tilemap.set_tile(this, layer, x, y, tile);
		}
		public void SetTile(int x, int y, int tile, Hash layer, TilemapTransforms transformBitmask)
		{
			ValidateCachedBounds(x, y);
			tilemap.set_tile(this, layer, x, y, tile, (int)transformBitmask);
		}
		

		private void ValidateCachedBounds(int x, int y)
		{
			if (TryGetCacheData(out var cachedData))
				if (cachedData.Bounds != null)
				{
					//If we're setting a tile outside the cached boundaries,
					//clear the cache so the next request will re-fetch.
					if (!cachedData.Bounds.InRect(x, y))
						cachedData.Bounds = null;
				}
		}
		
		
		

		public void SetLayerVisible(string layer, bool visible = true)
		{
			tilemap.set_visible(this, layer, visible);
		}
		
		public void SetLayerVisible(Hash layer, bool visible = true)
		{
			tilemap.set_visible(this, layer, visible);
		}
	}
}