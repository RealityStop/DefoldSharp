using types;

namespace support
{
	public abstract class ComponentReference
	{
		public Url Locator { get; private set; }

		protected void AssignLocatorInternal(Url locator)
		{
			Locator = Locator;
		}

		public static implicit operator Url(ComponentReference self)
		{
			return self.Locator;
		}
	}
}