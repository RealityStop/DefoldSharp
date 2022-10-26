using System;
using support;
using types;

/// <summary>
/// Collection factory API documentation
/// 
/// </summary>
public static class Collectionfactory
{
	#region Defold API
	/// <summary>
	/// This decreases the reference count for each resource loaded with collectionfactory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.unload()"
	/// </summary>
	public static extern void unload();
	
	
	/// <summary>
	/// This decreases the reference count for each resource loaded with collectionfactory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.unload({0})"
	/// </summary>
	public static extern void unload(string url_p1);
	
	
	/// <summary>
	/// This decreases the reference count for each resource loaded with collectionfactory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.unload({0})"
	/// </summary>
	public static extern void unload(Hash url_p1);
	
	
	/// <summary>
	/// This decreases the reference count for each resource loaded with collectionfactory.load. If reference is zero, the resource is destroyed.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.unload({0})"
	/// </summary>
	public static extern void unload(Url url_p1);
	
	
	/// <summary>
	/// Resources loaded are referenced by the collection factory component until the existing (parent) collection is destroyed or collectionfactory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.load()"
	/// </summary>
	public static extern void load();
	
	
	/// <summary>
	/// Resources loaded are referenced by the collection factory component until the existing (parent) collection is destroyed or collectionfactory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.load({0})"
	/// </summary>
	public static extern void load(string url_p1);
	
	
	/// <summary>
	/// Resources loaded are referenced by the collection factory component until the existing (parent) collection is destroyed or collectionfactory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.load({0}, {1})"
	/// </summary>
	public static extern void load(string url_p1, Action<> complete_function_p2);
	
	
	/// <summary>
	/// Resources loaded are referenced by the collection factory component until the existing (parent) collection is destroyed or collectionfactory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.load({0})"
	/// </summary>
	public static extern void load(Hash url_p1);
	
	
	/// <summary>
	/// Resources loaded are referenced by the collection factory component until the existing (parent) collection is destroyed or collectionfactory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.load({0}, {1})"
	/// </summary>
	public static extern void load(Hash url_p1, Action<> complete_function_p2);
	
	
	/// <summary>
	/// Resources loaded are referenced by the collection factory component until the existing (parent) collection is destroyed or collectionfactory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.load({0})"
	/// </summary>
	public static extern void load(Url url_p1);
	
	
	/// <summary>
	/// Resources loaded are referenced by the collection factory component until the existing (parent) collection is destroyed or collectionfactory.unload is called.
	/// Calling this function when the factory is not marked as dynamic loading does nothing.
	/// 
	/// @CSharpLua.Template = "collectionfactory.load({0}, {1})"
	/// </summary>
	public static extern void load(Url url_p1, Action<> complete_function_p2);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0})"
	/// </summary>
	public static extern ILuaTable create(string url_p1);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1})"
	/// </summary>
	public static extern ILuaTable create(string url_p1, Vector3 position_p2);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2})"
	/// </summary>
	public static extern ILuaTable create(string url_p1, Vector3 position_p2, Quaternion rotation_p3);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern ILuaTable create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern ILuaTable create(string url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0})"
	/// </summary>
	public static extern ILuaTable create(Hash url_p1);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1})"
	/// </summary>
	public static extern ILuaTable create(Hash url_p1, Vector3 position_p2);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2})"
	/// </summary>
	public static extern ILuaTable create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern ILuaTable create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern ILuaTable create(Hash url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0})"
	/// </summary>
	public static extern ILuaTable create(Url url_p1);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1})"
	/// </summary>
	public static extern ILuaTable create(Url url_p1, Vector3 position_p2);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2})"
	/// </summary>
	public static extern ILuaTable create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern ILuaTable create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4);
	
	
	/// <summary>
	/// The URL identifies the collectionfactory component that should do the spawning.
	/// Spawning is instant, but spawned game objects get their first update calls the following frame. The supplied parameters for position, rotation and scale
	/// will be applied to the whole collection when spawned.
	/// Script properties in the created game objects can be overridden through
	/// a properties-parameter table. The table should contain game object ids
	/// (hash) as keys and property tables as values to be used when initiating each
	/// spawned game object.
	/// See go.property for more information on script properties.
	/// The function returns a table that contains a key for each game object
	/// id (hash), as addressed if the collection file was top level, and the
	/// corresponding spawned instance id (hash) as value with a unique path
	/// prefix added to each instance.
	/// <span class="icon-attention"></span> Calling <a href="/ref/collectionfactory#collectionfactory.create">collectionfactory.create</a> create on a collection factory that is marked as dynamic without having loaded resources
	/// using <a href="/ref/collectionfactory#collectionfactory.load">collectionfactory.load</a> will synchronously load and create resources which may affect application performance.
	/// 
	/// @CSharpLua.Template = "collectionfactory.create({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern ILuaTable create(Url url_p1, Vector3 position_p2, Quaternion rotation_p3, ILuaTable properties_p4, double scale_p5);
	
	
	#endregion Defold API
	
	
	
	
	public readonly struct CollectionFactoryCreateResult
	{
	   public readonly Hash RelativeHash;
	   public readonly Hash UniqueHash;
	
	
	   public CollectionFactoryCreateResult(Hash relativeHash, Hash uniqueHash)
	   {
	      RelativeHash = relativeHash;
	      UniqueHash = uniqueHash;
	   }
	}
	
	public FactoryStatus Status => Get_status(this);
	
	
	public LuaTableOf<Hash, Hash> Create()
	{
	   return (dynamic)Create(this);
	}
	   
	public LuaTableOf<Hash, Hash> Create(Vector3 position)
	{
	   return (dynamic)Create(this, position);
	}
	   
	public LuaTableOf<Hash, Hash> Create(Vector3 position, Quaternion rotation)
	{
	   return (dynamic)Create(this, position, rotation);
	}
	   
	public LuaTableOf<Hash, Hash> Create(Vector3 position, Quaternion rotation, ILuaTable properties)
	{
	   return (dynamic)Create(this, position, rotation, properties);
	}
}
