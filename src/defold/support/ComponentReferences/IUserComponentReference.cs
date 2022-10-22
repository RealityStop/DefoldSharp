using types;

namespace support
{
	public interface IUserComponentReference : IComponentReference
	{
		void AssignLocator(Url locator);
	}
}