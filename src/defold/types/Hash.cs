namespace src2.defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class Hash
	{
		/// <summary>
		/// @CSharpLua.Template = "hash({0})"
		/// </summary>
		public static implicit operator Hash(string v)
		{
			//Doesn't actually get called.  Instead the template is injected.  But we can't extern operators.
			return Defold.hash(v);
		}
	}
}