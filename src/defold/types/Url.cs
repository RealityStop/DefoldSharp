using System.Net.Sockets;

namespace src2.defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class Url
	{
		public int socket;
		public Hash path;
		public Hash fragment;

		/// <summary>
		/// @CSharpLua.Template = "msg.url()"
		/// </summary>
		public Url()
		{
		}

		/// <summary>
		/// @CSharpLua.Template = "msg.url({0})"
		/// </summary>
		public Url(string url)
		{
		}
		
		
		/// <summary>
		/// @CSharpLua.Template = "msg.url({0},{1})"
		/// </summary>
		public Url(HashOrString socket, HashOrString path)
		{
		}
		
		/// <summary>
		/// @CSharpLua.Template = "msg.url({0},{1},{2})"
		/// </summary>
		public Url(HashOrString socket, HashOrString path, HashOrString fragment)
		{
		}
	}
}