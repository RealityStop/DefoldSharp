using types;

namespace support
{
	public class Locator
	{
		private readonly Url _url;


		private Locator(Url url)
		{
			_url = url;
		}



		public Url FetchUrl()
		{
			return _url;
		}





		public static Locator AtUrl(Url url)
		{
			return new Locator(url);
		}


		public static Locator AtComponent(string componentName)
		{
			var url = Msg.url();
			url.path = Go.get_id();
			;
			url.fragment = componentName;
			return new Locator(url);
		}


		public static Locator AtComponent(string gameobjectPath, string componentName)
		{
			var url = Msg.url();
			url.path = Go.get_id(gameobjectPath);
			;
			url.fragment = componentName;
			return new Locator(url);
		}
	}
}