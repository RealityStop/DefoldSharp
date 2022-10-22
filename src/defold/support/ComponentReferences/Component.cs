namespace support
{
	public static class Component
	{
		public static TComponent At<TComponent>(string locator) where TComponent : INonCacheableComponentReference, new()
		{
			var result = new TComponent();
			result.AssignLocator(msg.url(locator));
			return result;

		}
		
		
		public static TComponent At<TComponent>(ComponentLocator locator, bool cacheInternals) where TComponent : ICacheableComponentReference, new()
		{
			var result = new TComponent();
			result.AssignLocator(locator.FetchUrl(), cacheInternals);
			return result;

		}
	}
}