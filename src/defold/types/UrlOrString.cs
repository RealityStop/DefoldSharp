using System.Net.Sockets;

namespace src2.defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class UrlOrString
	{
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator UrlOrString(Url v)
		{
			return default;
		}
		
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator UrlOrString(string v)
		{
			return default;
		}
	}
}