using types;

namespace support
{
	public interface IBuiltInComponent : IComponent
	{
		void AssignLocator(Locator locator);
	}
}