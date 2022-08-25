namespace src2.defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class HashOrStringOrUrl
	{
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator HashOrStringOrUrl(Hash v)
		{
			return default;
		}
		
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator HashOrStringOrUrl(string v)
		{
			return default;
		}
		
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator HashOrStringOrUrl(Url v)
		{
			return default;
		}
	}
}