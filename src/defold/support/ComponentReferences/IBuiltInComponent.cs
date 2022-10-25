using types;

namespace support
{
	public interface IBuiltInComponent : IComponent
	{
		void EnableCaching();
		
		void AssignLocator(ComponentLocator locator);
	}
}