using types;

namespace support
{
	public class BuiltInComponentBase : IBuiltInComponent
	{
		public Url Locator { get; private set; }
		public void AssignLocator(ComponentLocator locator)
		{
			Locator = locator.FetchUrl();
		}

		public static implicit operator Url(BuiltInComponentBase self)
		{
			return self.Locator;
		}
	}
}