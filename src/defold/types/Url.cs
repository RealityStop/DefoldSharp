using System;

namespace types
{
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
	}
}
