namespace types
{
	/// <summary>
	/// </summary>
	public class Url
	{
		public Hash fragment;
		public Hash path;
		public int socket;


		/// <summary>
		///     @CSharpLua.Template = "msg.url()"
		/// </summary>
		public Url()
		{
		}


		/// <summary>
		///     @CSharpLua.Template = "msg.url({0})"
		/// </summary>
		public Url(string url)
		{
		}
	}
}