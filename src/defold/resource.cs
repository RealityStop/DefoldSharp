using System;
using types;

/// <summary>
/// Resource API documentation
/// 
/// </summary>
public static class Resource
{
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.material()"
	/// </summary>
	public static extern Hash Material();
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.material({0})"
	/// </summary>
	public static extern Hash Material(string path_p1);
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.font()"
	/// </summary>
	public static extern Hash Font();
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.font({0})"
	/// </summary>
	public static extern Hash Font(string path_p1);
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.texture()"
	/// </summary>
	public static extern Hash Texture();
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.texture({0})"
	/// </summary>
	public static extern Hash Texture(string path_p1);
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.atlas()"
	/// </summary>
	public static extern Hash Atlas();
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.atlas({0})"
	/// </summary>
	public static extern Hash Atlas(string path_p1);
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.buffer()"
	/// </summary>
	public static extern Hash Buffer();
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.buffer({0})"
	/// </summary>
	public static extern Hash Buffer(string path_p1);
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.tile_source()"
	/// </summary>
	public static extern Hash Tile_source();
	
	
	/// <summary>
	/// Constructor-like function with two purposes:
	/// <ul>
	/// <li>Load the specified resource as part of loading the script</li>
	/// <li>Return a hash to the run-time version of the resource</li>
	/// </ul>
	/// <span class="icon-attention"></span> This function can only be called within <a href="/ref/go#go.property">go.property</a> function calls.
	/// 
	/// @CSharpLua.Template = "resource.tile_source({0})"
	/// </summary>
	public static extern Hash Tile_source(string path_p1);
	
	
	/// <summary>
	/// Sets the resource data for a specific resource
	/// 
	/// @CSharpLua.Template = "resource.set({0}, {1})"
	/// </summary>
	public static extern void Set(string path_p1, DataBuffer buffer_p2);
	
	
	/// <summary>
	/// Sets the resource data for a specific resource
	/// 
	/// @CSharpLua.Template = "resource.set({0}, {1})"
	/// </summary>
	public static extern void Set(Hash path_p1, DataBuffer buffer_p2);
	
	
	/// <summary>
	/// Loads the resource data for a specific resource.
	/// 
	/// @CSharpLua.Template = "resource.load({0})"
	/// </summary>
	public static extern DataBuffer Load(string path_p1);
	
	
	/// <summary>
	/// Sets the pixel data for a specific texture.
	/// 
	/// @CSharpLua.Template = "resource.set_texture({0}, {1}, {2})"
	/// </summary>
	public static extern void Set_texture(Hash path_p1, ILuaTable table_p2, DataBuffer buffer_p3);
	
	
	/// <summary>
	/// Sets the pixel data for a specific texture.
	/// 
	/// @CSharpLua.Template = "resource.set_texture({0}, {1}, {2})"
	/// </summary>
	public static extern void Set_texture(string path_p1, ILuaTable table_p2, DataBuffer buffer_p3);
	
	
	/// <summary>
	/// Update internal sound resource (wavc/oggc) with new data
	/// 
	/// @CSharpLua.Template = "resource.set_sound({0}, {1})"
	/// </summary>
	public static extern void Set_sound(Hash path_p1, string buffer_p2);
	
	
	/// <summary>
	/// Update internal sound resource (wavc/oggc) with new data
	/// 
	/// @CSharpLua.Template = "resource.set_sound({0}, {1})"
	/// </summary>
	public static extern void Set_sound(string path_p1, string buffer_p2);
	
	
	/// <summary>
	/// gets the buffer from a resource
	/// 
	/// @CSharpLua.Template = "resource.get_buffer({0})"
	/// </summary>
	public static extern DataBuffer Get_buffer(Hash path_p1);
	
	
	/// <summary>
	/// gets the buffer from a resource
	/// 
	/// @CSharpLua.Template = "resource.get_buffer({0})"
	/// </summary>
	public static extern DataBuffer Get_buffer(string path_p1);
	
	
	/// <summary>
	/// sets the buffer of a resource
	/// 
	/// @CSharpLua.Template = "resource.set_buffer({0}, {1})"
	/// </summary>
	public static extern void Set_buffer(Hash path_p1, DataBuffer buffer_p2);
	
	
	/// <summary>
	/// sets the buffer of a resource
	/// 
	/// @CSharpLua.Template = "resource.set_buffer({0}, {1})"
	/// </summary>
	public static extern void Set_buffer(string path_p1, DataBuffer buffer_p2);
	
	
	/// <summary>
	/// Gets the text metrics from a font
	/// 
	/// @CSharpLua.Template = "resource.get_text_metrics({0}, {1})"
	/// </summary>
	public static extern ILuaTable Get_text_metrics(Hash url_p1, string text_p2);
	
	
	/// <summary>
	/// Gets the text metrics from a font
	/// 
	/// @CSharpLua.Template = "resource.get_text_metrics({0}, {1}, {2})"
	/// </summary>
	public static extern ILuaTable Get_text_metrics(Hash url_p1, string text_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// Return a reference to the Manifest that is currently loaded.
	/// 
	/// @CSharpLua.Template = "resource.get_current_manifest()"
	/// </summary>
	public static extern double Get_current_manifest();
	
	
	/// <summary>
	/// add a resource to the data archive and runtime index. The resource will be verified
	/// internally before being added to the data archive.
	/// 
	/// @CSharpLua.Template = "resource.store_resource({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void Store_resource(double manifest_reference_p1, string data_p2, string hexdigest_p3, Action<object,string,bool> callback_p4);
	
	
	/// <summary>
	/// Create a new manifest from a buffer. The created manifest is verified
	/// by ensuring that the manifest was signed using the bundled public/private
	/// key-pair during the bundle process and that the manifest supports the current
	/// running engine version. Once the manifest is verified it is stored on device.
	/// The next time the engine starts (or is rebooted) it will look for the stored
	/// manifest before loading resources. Storing a new manifest allows the
	/// developer to update the game, modify existing resources, or add new
	/// resources to the game through LiveUpdate.
	/// 
	/// @CSharpLua.Template = "resource.store_manifest({0}, {1})"
	/// </summary>
	public static extern void Store_manifest(string manifest_buffer_p1, Action<object,ResourceLiveUpdate> callback_p2);
	
	
	/// <summary>
	/// Stores a zip file and uses it for live update content. The contents of the
	/// zip file will be verified against the manifest to ensure file integrity.
	/// It is possible to opt out of the resource verification using an option passed
	/// to this function.
	/// The path is stored in the (internal) live update location.
	/// 
	/// @CSharpLua.Template = "resource.store_archive({0}, {1})"
	/// </summary>
	public static extern void Store_archive(string path_p1, Action<object,ResourceLiveUpdate> callback_p2);
	
	
	/// <summary>
	/// Stores a zip file and uses it for live update content. The contents of the
	/// zip file will be verified against the manifest to ensure file integrity.
	/// It is possible to opt out of the resource verification using an option passed
	/// to this function.
	/// The path is stored in the (internal) live update location.
	/// 
	/// @CSharpLua.Template = "resource.store_archive({0}, {1}, {2})"
	/// </summary>
	public static extern void Store_archive(string path_p1, Action<object,ResourceLiveUpdate> callback_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// Is any liveupdate data mounted and currently in use?
	/// This can be used to determine if a new manifest or zip file should be downloaded.
	/// 
	/// @CSharpLua.Template = "resource.is_using_liveupdate_data()"
	/// </summary>
	public static extern bool Is_using_liveupdate_data();
	
	
}
