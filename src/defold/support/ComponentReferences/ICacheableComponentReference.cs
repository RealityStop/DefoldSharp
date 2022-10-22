using types;

namespace support
{
	public interface ICacheableComponentReference : IBuiltInComponentReference
	{
		void AssignLocator(Url locator, bool enableCaching);
	}
}