using types;

namespace support
{
	public class ComponentLocator
	{
		public Hash AbsoluteGOHash { get; }
		public string ComponentName { get; }


		public Url FetchUrl()
		{
			var url = Msg.Url();
			url.path = AbsoluteGOHash;
			url.fragment = ComponentName;
			return url;
		}


		/// <summary>
		/// Resolves the component relative to the current game object.
		/// </summary>
		/// <param name="componentName"></param>
		public ComponentLocator(string componentName)
		{
			AbsoluteGOHash = Go.Get_id();
			ComponentName = componentName;
		}


		/// <summary>
		/// Resolves the component relative to the specified game object
		/// </summary>
		/// <param name="gameobjectPath"></param>
		/// <param name="componentName"></param>
		public ComponentLocator(string gameobjectPath, string componentName)
		{
			AbsoluteGOHash = Go.Get_id(gameobjectPath);
			ComponentName = componentName;
		}
	}
}