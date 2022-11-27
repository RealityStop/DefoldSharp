using types;

namespace support.ComponentReferences
{
	public class BuiltInComponentBase : IBuiltInComponent
	{
		public Url LocatorUrl { get; private set; }
		public void AssignLocator(Locator locator)
		{
			LocatorUrl = locator.FetchUrl();
		}

		public static implicit operator Url(BuiltInComponentBase self)
		{
			return self.LocatorUrl;
		}
	}
}