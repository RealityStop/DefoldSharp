using System;
using defold;

namespace defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class Hash
	{
		/// <summary>
/// @CSharpLua.Template = "hash({0})"
/// </summary>
public Hash(string v)
{
}

/// <summary>
/// @CSharpLua.Template = "hash({0})"
/// </summary>
public static implicit operator Hash(string v)
{
   //Doesn't actually get called.  Instead the template is injected.  But we can't extern operators.
   return Defold.hash(v);
}

/// <summary>
/// @CSharpLua.Template = "{0}"
/// </summary>
public static implicit operator string(Hash v)
{
   //Doesn't actually get called.  Instead the template is injected.  But we can't extern operators.
   return v.ToString();
}



/// <summary>
/// @CSharpLua.Template = "{this}"
/// </summary>
public extern override string ToString();
	}
}
