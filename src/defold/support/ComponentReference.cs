using types;

namespace support
{
	public abstract class ComponentReference
	{
		public Url Locator { get; }

		public ComponentReference(ComponentLocator locator)
		{
			Locator = locator.FetchUrl();
		}
		
		public static implicit operator Url(ComponentReference self)
		{
			return self.Locator;
		}
	}
}