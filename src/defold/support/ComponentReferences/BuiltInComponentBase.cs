using types;

namespace support
{
	public class BuiltInComponentBase : IBuiltInComponent
	{
		public bool IsCachingEnabled { get; private set; }
		public Url Locator { get; private set; }
		public void AssignLocator(ComponentLocator locator)
		{
			Locator = locator.FetchUrl();
		}


		public void EnableCaching()
		{
			IsCachingEnabled = false;
		}
		
		

		public static implicit operator Url(BuiltInComponentBase self)
		{
			return self.Locator;
		}
	}
}