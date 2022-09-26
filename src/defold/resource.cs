using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Resource API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class resource
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.material({0})"
		/// </summary>
		public static extern Hash material(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.font({0})"
		/// </summary>
		public static extern Hash font(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.texture({0})"
		/// </summary>
		public static extern Hash texture(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.atlas({0})"
		/// </summary>
		public static extern Hash atlas(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.buffer({0})"
		/// </summary>
		public static extern Hash buffer(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.tile_source({0})"
		/// </summary>
		public static extern Hash tile_source(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set({0}, {1})"
		/// </summary>
		public static extern void set(string path_p1, DataBuffer buffer_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set({0}, {1})"
		/// </summary>
		public static extern void set(Hash path_p1, DataBuffer buffer_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.load({0})"
		/// </summary>
		public static extern DataBuffer load(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set_texture({0}, {1}, {2})"
		/// </summary>
		public static extern void set_texture(Hash path_p1, ILuaTable table_p2, DataBuffer buffer_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set_texture({0}, {1}, {2})"
		/// </summary>
		public static extern void set_texture(string path_p1, ILuaTable table_p2, DataBuffer buffer_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set_sound({0}, {1})"
		/// </summary>
		public static extern void set_sound(Hash path_p1, string buffer_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set_sound({0}, {1})"
		/// </summary>
		public static extern void set_sound(string path_p1, string buffer_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.get_buffer({0})"
		/// </summary>
		public static extern DataBuffer get_buffer(Hash path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.get_buffer({0})"
		/// </summary>
		public static extern DataBuffer get_buffer(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set_buffer({0}, {1})"
		/// </summary>
		public static extern void set_buffer(Hash path_p1, DataBuffer buffer_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.set_buffer({0}, {1})"
		/// </summary>
		public static extern void set_buffer(string path_p1, DataBuffer buffer_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.get_text_metrics({0}, {1}, {2})"
		/// </summary>
		public static extern ILuaTable get_text_metrics(Hash url_p1, string text_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.get_current_manifest()"
		/// </summary>
		public static extern double get_current_manifest();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.store_resource({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void store_resource(double manifest_reference_p1, string data_p2, string hexdigest_p3, Action<object,string,bool> callback_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.store_manifest({0}, {1})"
		/// </summary>
		public static extern void store_manifest(string manifest_buffer_p1, Action<object,ResourceLiveUpdate> callback_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.store_archive({0}, {1}, {2})"
		/// </summary>
		public static extern void store_archive(string path_p1, Action<object,ResourceLiveUpdate> callback_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "resource.is_using_liveupdate_data()"
		/// </summary>
		public static extern bool is_using_liveupdate_data();
		
		
	}
}
