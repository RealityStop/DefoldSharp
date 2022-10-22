using System.Collections.Generic;
using types;

namespace support
{
	public abstract class CachingComponentReference<TData> : ComponentReference where TData : new()
	{
		private static Dictionary<Url, object> CachedDataByLocator = new Dictionary<Url, object>();
		
		
		public bool IsCachingInternals { get; }
		protected TData CachedData { get; }


		public CachingComponentReference(ComponentLocator locator, bool isCachingInternals) : base(locator)
		{
			IsCachingInternals = isCachingInternals;

			if (IsCachingInternals)
			{
				if (!CachedDataByLocator.TryGetValue(Locator, out var data))
				{
					data = new TData();
					CachedDataByLocator.Add(Locator, data);
				}

				CachedData = (TData)data;
			}
		}
	}
}