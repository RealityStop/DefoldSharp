using types;

namespace support
{
	public class NonCachingComponentReference : ComponentReference, INonCacheableComponentReference
	{
		public void AssignLocator(Url locator)
		{
			AssignLocatorInternal(locator);
		}
	}
}