using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Collection factory API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class collectionfactory
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.get_status({0})"
		/// </summary>
		public static extern FactoryStatus get_status(string url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.get_status({0})"
		/// </summary>
		public static extern FactoryStatus get_status(Hash url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.get_status({0})"
		/// </summary>
		public static extern FactoryStatus get_status(Url url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.unload({0})"
		/// </summary>
		public static extern void unload(string url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.unload({0})"
		/// </summary>
		public static extern void unload(Hash url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.unload({0})"
		/// </summary>
		public static extern void unload(Url url_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.load({0}, {1})"
		/// </summary>
		public static extern void load(string url_p1, Action<object,Url,bool> complete_function_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.load({0}, {1})"
		/// </summary>
		public static extern void load(Hash url_p1, Action<object,Url,bool> complete_function_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.load({0}, {1})"
		/// </summary>
		public static extern void load(Url url_p1, Action<object,Url,bool> complete_function_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3}, {4})"
		/// </summary>
		public static extern ILuaTable create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3}, {4})"
		/// </summary>
		public static extern ILuaTable create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3}, {4})"
		/// </summary>
		public static extern ILuaTable create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
		
		
	}
}
