using System.Collections.Generic;
using types;

namespace support
{
	public abstract class CachingComponentReference<TData> : ComponentReference, ICacheableComponentReference
		where TData : new()
	{
		private static readonly Dictionary<Url, TData> CachedDataByLocator = new Dictionary<Url, TData>();
		private TData _cachedData;


		public bool IsCachingInternals { get; private set; }


		public void AssignLocator(Url locator, bool enableCaching)
		{
			AssignLocatorInternal(locator);
			IsCachingInternals = enableCaching;

			if (IsCachingInternals)
			{
				if (!CachedDataByLocator.TryGetValue(Locator, out var data))
				{
					data = new TData();
					CachedDataByLocator.Add(Locator, data);
				}

				_cachedData = data;
			}
		}


		protected bool TryGetCacheData(out TData cachedData)
		{
			if (IsCachingInternals)
			{
				cachedData = _cachedData;
				return true;
			}

			cachedData = default;
			return false;
		}
	}
}