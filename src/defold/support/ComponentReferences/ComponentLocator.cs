using types;

namespace support
{
	public class ComponentLocator
	{
		private readonly Url _url;


		public ComponentLocator(Url url)
		{
			_url = url;
		}
		

		/// <summary>
		///     Resolves the component relative to the current game object.
		/// </summary>
		/// <param name="componentName"></param>
		public ComponentLocator(string componentName)
		{
			var url = Msg.Url();
			url.path = Go.Get_id();;
			url.fragment = componentName;
			_url = url;
		}


		/// <summary>
		///     Resolves the component relative to the specified game object
		/// </summary>
		/// <param name="gameobjectPath"></param>
		/// <param name="componentName"></param>
		public ComponentLocator(string gameobjectPath, string componentName)
		{
			var url = Msg.Url();
			url.path = Go.Get_id(gameobjectPath);;
			url.fragment = componentName;
			_url = url;
		}


		public Url FetchUrl()
		{
			return _url;
		}
	}
}