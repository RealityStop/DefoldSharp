using System;
using support;
using types;

/// <summary>
/// Factory API documentation
/// 
/// </summary>
public static class Factory
{
	#region Defold API
	/// <summary>
	/// This returns status of the factory.
	/// Calling this function when the factory is not marked as dynamic loading always returns
	/// factory.STATUS_LOADED.
	/// 
	/// @CSharpLua.Template = "factory.get_status()"
	/// </summary>
	public static extern FactoryStatus get_status();
	
	
	/// <summary>
	/// This returns status of the factory.
	/// Calling this function when the factory is not marked as dynamic loading always returns
	/// factory.STATUS_LOADED.
	/// 
	/// @CSharpLua.Template = "factory.get_status({0})"
	/// </summary>
	public static extern FactoryStatus get_status(string url_p1);
	
	
	/// <summary>
	/// This returns status of the factory.
	/// Calling this function when the factory is not marked as dynamic loading always returns
	/// factory.STATUS_LOADED.
	/// 
	/// @CSharpLua.Template = "factory.get_status({0})"
	/// </summary>
	public static extern FactoryStatus get_status(Hash url_p1);
	
	
	/// <summary>
	/// This returns status of the factory.
	/// Calling this function when the factory is not marked as dynamic loading always returns
	/// factory.STATUS_LOADED.
	/// 
	/// @CSharpLua.Template = "factory.get_status({0})"
	/// </summary>
	public static extern FactoryStatus get_status(Url url_p1);
	
	
	/// <summary>
	/// This decreases the reference count for each resource loaded with factory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.unload()"
	/// </summary>
	public static extern void unload();
	
	
	/// <summary>
	/// This decreases the reference count for each resource loaded with factory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.unload({0})"
	/// </summary>
	public static extern void unload(string url_p1);
	
	
	/// <summary>
	/// This decreases the reference count for each resource loaded with factory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.unload({0})"
	/// </summary>
	public static extern void unload(Hash url_p1);
	
	
	/// <summary>
	/// This decreases the reference count for each resource loaded with factory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.unload({0})"
	/// </summary>
	public static extern void unload(Url url_p1);
	
	
	/// <summary>
	/// Resources are referenced by the factory component until the existing (parent) collection is destroyed or factory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.load()"
	/// </summary>
	public static extern void load();
	
	
	/// <summary>
	/// Resources are referenced by the factory component until the existing (parent) collection is destroyed or factory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.load({0})"
	/// </summary>
	public static extern void load(string url_p1);
	
	
	/// <summary>
	/// Resources are referenced by the factory component until the existing (parent) collection is destroyed or factory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.load({0}, {1})"
	/// </summary>
	public static extern void load(string url_p1, Action<object,Url,bool> complete_function_p2);
	
	
	/// <summary>
	/// Resources are referenced by the factory component until the existing (parent) collection is destroyed or factory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.load({0})"
	/// </summary>
	public static extern void load(Hash url_p1);
	
	
	/// <summary>
	/// Resources are referenced by the factory component until the existing (parent) collection is destroyed or factory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.load({0}, {1})"
	/// </summary>
	public static extern void load(Hash url_p1, Action<object,Url,bool> complete_function_p2);
	
	
	/// <summary>
	/// Resources are referenced by the factory component until the existing (parent) collection is destroyed or factory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.load({0})"
	/// </summary>
	public static extern void load(Url url_p1);
	
	
	/// <summary>
	/// Resources are referenced by the factory component until the existing (parent) collection is destroyed or factory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "factory.load({0}, {1})"
	/// </summary>
	public static extern void load(Url url_p1, Action<object,Url,bool> complete_function_p2);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0})"
	/// </summary>
	public static extern Hash create(string url_p1);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, Vector3 scale_p5);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0})"
	/// </summary>
	public static extern Hash create(Hash url_p1);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, Vector3 scale_p5);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0})"
	/// </summary>
	public static extern Hash create(Url url_p1);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
	
	
	/// <summary>
	/// The URL identifies which factory should create the game object.
	/// If the game object is created inside of the frame (e.g. from an update callback), the game object will be created instantly, but none of its component will be updated in the same frame.
	/// Properties defined in scripts in the created game object can be overridden through the properties-parameter below.
	/// See go.property for more information on script properties.
	/// <span class="icon-attention"></span> Calling <a href="/ref/factory#factory.create">factory.create</a> on a factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/factory#factory.load">factory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "factory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern Hash create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, Vector3 scale_p5);
	
	
	#endregion Defold API
}
