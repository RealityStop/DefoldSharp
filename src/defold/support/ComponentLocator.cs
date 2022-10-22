using types;

namespace support
{
	public class ComponentLocator
	{
		public Hash AbsoluteGOHash { get; }
		public string ComponentName { get; }


		public Url FetchUrl()
		{
			var url = msg.url();
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
			AbsoluteGOHash = go.get_id();
			ComponentName = componentName;
		}


		/// <summary>
		/// Resolves the component relative to the specified game object
		/// </summary>
		/// <param name="gameobjectPath"></param>
		/// <param name="componentName"></param>
		public ComponentLocator(string gameobjectPath, string componentName)
		{
			AbsoluteGOHash = go.get_id(gameobjectPath);
			ComponentName = componentName;
		}
	}
}