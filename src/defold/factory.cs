using System;
using types;

/// <summary>
/// Factory API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class factory
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.get_status()"
	/// </summary>
	public static extern FactoryStatus get_status();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.get_status({0})"
	/// </summary>
	public static extern FactoryStatus get_status(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.get_status({0})"
	/// </summary>
	public static extern FactoryStatus get_status(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.get_status({0})"
	/// </summary>
	public static extern FactoryStatus get_status(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.unload()"
	/// </summary>
	public static extern void unload();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.unload({0})"
	/// </summary>
	public static extern void unload(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.unload({0})"
	/// </summary>
	public static extern void unload(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.unload({0})"
	/// </summary>
	public static extern void unload(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.load()"
	/// </summary>
	public static extern void load();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.load({0})"
	/// </summary>
	public static extern void load(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.load({0}, {1})"
	/// </summary>
	public static extern void load(string url_p1, Action<object,Url,bool> complete_function_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.load({0})"
	/// </summary>
	public static extern void load(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.load({0}, {1})"
	/// </summary>
	public static extern void load(Hash url_p1, Action<object,Url,bool> complete_function_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.load({0})"
	/// </summary>
	public static extern void load(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.load({0}, {1})"
	/// </summary>
	public static extern void load(Url url_p1, Action<object,Url,bool> complete_function_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0})"
	/// </summary>
	public static extern Hash create(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, Vector3 scale_p5);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0})"
	/// </summary>
	public static extern Hash create(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, Vector3 scale_p5);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0})"
	/// </summary>
	public static extern Hash create(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, Vector3 scale_p5);
		
		
}