using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Game object API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class go
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
		/// </summary>
		public static extern LuaType get(string url_p1, string property_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
		/// </summary>
		public static extern LuaType get(string url_p1, Hash property_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
		/// </summary>
		public static extern LuaType get(Hash url_p1, string property_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
		/// </summary>
		public static extern LuaType get(Hash url_p1, Hash property_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
		/// </summary>
		public static extern LuaType get(Url url_p1, string property_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
		/// </summary>
		public static extern LuaType get(Url url_p1, Hash property_p2, ILuaTable options_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set(string url_p1, string property_p2, LuaType value_p3, ILuaTable options_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set(string url_p1, Hash property_p2, LuaType value_p3, ILuaTable options_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set(Hash url_p1, string property_p2, LuaType value_p3, ILuaTable options_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set(Hash url_p1, Hash property_p2, LuaType value_p3, ILuaTable options_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set(Url url_p1, string property_p2, LuaType value_p3, ILuaTable options_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set(Url url_p1, Hash property_p2, LuaType value_p3, ILuaTable options_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_position({0})"
		/// </summary>
		public static extern Vector3 get_position(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_position({0})"
		/// </summary>
		public static extern Vector3 get_position(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_position({0})"
		/// </summary>
		public static extern Vector3 get_position(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_position({0})"
		/// </summary>
		public static extern Vector3 get_position();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_rotation({0})"
		/// </summary>
		public static extern Quaternion get_rotation(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_rotation({0})"
		/// </summary>
		public static extern Quaternion get_rotation(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_rotation({0})"
		/// </summary>
		public static extern Quaternion get_rotation(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_scale({0})"
		/// </summary>
		public static extern Vector3 get_scale(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_scale({0})"
		/// </summary>
		public static extern Vector3 get_scale(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_scale({0})"
		/// </summary>
		public static extern Vector3 get_scale(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_scale_uniform({0})"
		/// </summary>
		public static extern double get_scale_uniform(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_scale_uniform({0})"
		/// </summary>
		public static extern double get_scale_uniform(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_scale_uniform({0})"
		/// </summary>
		public static extern double get_scale_uniform(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_position({0}, {1})"
		/// </summary>
		public static extern void set_position(Vector3 position_p1, string id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_position({0}, {1})"
		/// </summary>
		public static extern void set_position(Vector3 position_p1, Hash id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_position({0}, {1})"
		/// </summary>
		public static extern void set_position(Vector3 position_p1, Url id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_position({0}, {1})"
		/// </summary>
		public static extern void set_position(Vector3 position_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_rotation({0}, {1})"
		/// </summary>
		public static extern void set_rotation(Quaternion rotation_p1, string id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_rotation({0}, {1})"
		/// </summary>
		public static extern void set_rotation(Quaternion rotation_p1, Hash id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_rotation({0}, {1})"
		/// </summary>
		public static extern void set_rotation(Quaternion rotation_p1, Url id_p2);		
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_rotation({0}, {1})"
		/// </summary>
		public static extern void set_rotation(Quaternion rotation_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_scale({0}, {1})"
		/// </summary>
		public static extern void set_scale(double scale_p1, string id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_scale({0}, {1})"
		/// </summary>
		public static extern void set_scale(double scale_p1, Hash id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_scale({0}, {1})"
		/// </summary>
		public static extern void set_scale(double scale_p1, Url id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_scale({0}, {1})"
		/// </summary>
		public static extern void set_scale(Vector3 scale_p1, string id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_scale({0}, {1})"
		/// </summary>
		public static extern void set_scale(Vector3 scale_p1, Hash id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_scale({0}, {1})"
		/// </summary>
		public static extern void set_scale(Vector3 scale_p1, Url id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(string id_p1, string parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(string id_p1, Hash parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(string id_p1, Url parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(Hash id_p1, string parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(Hash id_p1, Hash parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(Hash id_p1, Url parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(Url id_p1, string parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(Url id_p1, Hash parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
		/// </summary>
		public static extern void set_parent(Url id_p1, Url parent_id_p2, bool keep_world_transform_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_parent({0})"
		/// </summary>
		public static extern Hash get_parent(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_parent({0})"
		/// </summary>
		public static extern Hash get_parent(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_parent({0})"
		/// </summary>
		public static extern Hash get_parent(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_position({0})"
		/// </summary>
		public static extern Vector3 get_world_position(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_position({0})"
		/// </summary>
		public static extern Vector3 get_world_position(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_position({0})"
		/// </summary>
		public static extern Vector3 get_world_position(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_rotation({0})"
		/// </summary>
		public static extern Quaternion get_world_rotation(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_rotation({0})"
		/// </summary>
		public static extern Quaternion get_world_rotation(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_rotation({0})"
		/// </summary>
		public static extern Quaternion get_world_rotation(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_scale({0})"
		/// </summary>
		public static extern Vector3 get_world_scale(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_scale({0})"
		/// </summary>
		public static extern Vector3 get_world_scale(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_scale({0})"
		/// </summary>
		public static extern Vector3 get_world_scale(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_scale_uniform({0})"
		/// </summary>
		public static extern double get_world_scale_uniform(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_scale_uniform({0})"
		/// </summary>
		public static extern double get_world_scale_uniform(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_scale_uniform({0})"
		/// </summary>
		public static extern double get_world_scale_uniform(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_transform({0})"
		/// </summary>
		public static extern Matrix4 get_world_transform(string id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_transform({0})"
		/// </summary>
		public static extern Matrix4 get_world_transform(Hash id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_world_transform({0})"
		/// </summary>
		public static extern Matrix4 get_world_transform(Url id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.get_id({0})"
		/// </summary>
		public static extern Hash get_id(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
		/// </summary>
		public static extern void cancel_animations(string url_p1, string property_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
		/// </summary>
		public static extern void cancel_animations(string url_p1, Hash property_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
		/// </summary>
		public static extern void cancel_animations(Hash url_p1, string property_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
		/// </summary>
		public static extern void cancel_animations(Hash url_p1, Hash property_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
		/// </summary>
		public static extern void cancel_animations(Url url_p1, string property_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
		/// </summary>
		public static extern void cancel_animations(Url url_p1, Hash property_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.delete({0}, {1})"
		/// </summary>
		public static extern void delete(string id_p1, bool recursive_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.delete({0}, {1})"
		/// </summary>
		public static extern void delete(Hash id_p1, bool recursive_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.delete({0}, {1})"
		/// </summary>
		public static extern void delete(Url id_p1, bool recursive_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.delete({0}, {1})"
		/// </summary>
		public static extern void delete(ILuaTable id_p1, bool recursive_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.property({0}, {1})"
		/// </summary>
		public static extern void property(string name_p1, double value_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.property({0}, {1})"
		/// </summary>
		public static extern void property(string name_p1, Hash value_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.property({0}, {1})"
		/// </summary>
		public static extern void property(string name_p1, Url value_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.property({0}, {1})"
		/// </summary>
		public static extern void property(string name_p1, Vector3 value_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.property({0}, {1})"
		/// </summary>
		public static extern void property(string name_p1, Vector4 value_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.property({0}, {1})"
		/// </summary>
		public static extern void property(string name_p1, Quaternion value_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.init({0})"
		/// </summary>
		public static extern void init(object self_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.final({0})"
		/// </summary>
		public static extern void final(object self_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.update({0}, {1})"
		/// </summary>
		public static extern void update(object self_p1, double dt_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.on_message({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void on_message(object self_p1, Hash message_id_p2, ILuaTable message_p3, Url sender_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.on_input({0}, {1}, {2})"
		/// </summary>
		public static extern bool on_input(object self_p1, Hash action_id_p2, ILuaTable action_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "go.on_reload({0})"
		/// </summary>
		public static extern void on_reload(object self_p1);
		
		
	}
}
