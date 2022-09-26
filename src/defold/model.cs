using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Model API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class model
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.cancel({0})"
		/// </summary>
		public static extern void cancel(string url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.cancel({0})"
		/// </summary>
		public static extern void cancel(Hash url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.cancel({0})"
		/// </summary>
		public static extern void cancel(Url url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.get_go({0}, {1})"
		/// </summary>
		public static extern Hash get_go(string url_p1, string bone_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.get_go({0}, {1})"
		/// </summary>
		public static extern Hash get_go(string url_p1, Hash bone_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.get_go({0}, {1})"
		/// </summary>
		public static extern Hash get_go(Hash url_p1, string bone_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.get_go({0}, {1})"
		/// </summary>
		public static extern Hash get_go(Hash url_p1, Hash bone_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.get_go({0}, {1})"
		/// </summary>
		public static extern Hash get_go(Url url_p1, string bone_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "model.get_go({0}, {1})"
		/// </summary>
		public static extern Hash get_go(Url url_p1, Hash bone_id_p2);
		
		
	}
}
