using src2.defold.types;

namespace src2.defold
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public static class Defold
	{
		/// <summary>
		/// @CSharpLua.Template = "hash({0})"
		/// </summary>
		public static extern Hash hash(string s);

		/// <summary>
		/// @CSharpLua.Template = "hash_to_hex({0})"
		/// </summary>
		public static extern string hash_to_hex(Hash h);
	
		/// <summary>
		/// @CSharpLua.Template = "pprint({0})"
		/// </summary>
		public static extern void pprint(object v);
	}
}