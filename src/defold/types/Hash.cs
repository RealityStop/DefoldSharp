using System;
using lua;

namespace types
{
	/// <summary>
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



		/// <summary>
		/// //Used so we can fool the C# compiler into allowing us more overrides.  Hash is the actual implementation and should be
		/// used in methods where possible.
		/// </summary>
		public class __Hash2
		{
			/// <summary>
		   /// @CSharpLua.Ignore
		   /// </summary>
		   public static implicit operator __Hash2(Hash v)
		   {
		      //Doesn't actually get called.  Instead the template is injected.  But we can't extern operators.
		      return (dynamic)null;
		   }
		   

		   /// <summary>
		   /// @CSharpLua.Template = "hash({0})"
		   /// </summary>
		   public static implicit operator __Hash2(string v)
		   {
		      //Doesn't actually get called.  Instead the template is injected.  But we can't extern operators.
		      return Defold.hash(v);
		   }

		   /// <summary>
		   /// @CSharpLua.Template = "{this}"
		   /// </summary>
		   public Hash ToHash()
		   {
		      return (dynamic)null; //Not actually called.  
		   }
		}  


		/// <summary>
		/// //Used so we can fool the C# compiler into allowing us more overrides.  Hash is the actual implementation and should be
		/// used in methods where possible.
		/// </summary>
		public class __Hash3
		{
			/// <summary>
		   /// @CSharpLua.Ignore
		   /// </summary>
		   public static implicit operator __Hash3(Hash v)
		   {
		      //Doesn't actually get called.  Instead the template is injected.  But we can't extern operators.
		      return (dynamic)null;
		   }


		   /// <summary>
		   /// @CSharpLua.Template = "hash({0})"
		   /// </summary>
		   public static implicit operator __Hash3(string v)
		   {
		      //Doesn't actually get called.  Instead the template is injected.  But we can't extern operators.
		      return Defold.hash(v);
		   }

		   /// <summary>
		   /// @CSharpLua.Template = "{this}"
		   /// </summary>
		   public Hash ToHash()
		   {
		      return (dynamic)null; //Not actually called.  
		   }
	}
}
