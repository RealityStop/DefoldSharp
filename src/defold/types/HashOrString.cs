namespace src2.defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class HashOrString
	{
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator HashOrString(Hash v)
		{
			return default;
		}
		
		/// <summary>
		/// @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator HashOrString(string v)
		{
			return default;
		}
	}
}