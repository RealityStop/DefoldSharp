using types;

namespace support
{
	public interface INonCacheableComponentReference : IBuiltInComponentReference
	{
		void AssignLocator(Url locator);
	}
}