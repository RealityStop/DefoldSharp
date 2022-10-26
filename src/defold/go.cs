using System;
using support;
using types;

/// <summary>
/// Game object API documentation
/// 
/// </summary>
public static class Go
{
	#region Defold API
	/// <summary>
	/// </summary>
	public class acquire_input_focus_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("acquire_input_focus");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class release_input_focus_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("release_input_focus");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class set_parent_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("set_parent");
		public override Hash FetchCode() => __CODE__;
		
		public Hash parent_id;
		public double keep_world_transform;
	}
	
	
	/// <summary>
	/// </summary>
	public class enable_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("enable");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class disable_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("disable");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1})"
	/// </summary>
	public static extern LuaType get(string url_p1, string property_p2);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
	/// </summary>
	public static extern LuaType get(string url_p1, string property_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1})"
	/// </summary>
	public static extern LuaType get(string url_p1, Hash property_p2);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
	/// </summary>
	public static extern LuaType get(string url_p1, Hash property_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1})"
	/// </summary>
	public static extern LuaType get(Hash url_p1, string property_p2);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
	/// </summary>
	public static extern LuaType get(Hash url_p1, string property_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1})"
	/// </summary>
	public static extern LuaType get(Hash url_p1, Hash property_p2);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
	/// </summary>
	public static extern LuaType get(Hash url_p1, Hash property_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1})"
	/// </summary>
	public static extern LuaType get(Url url_p1, string property_p2);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
	/// </summary>
	public static extern LuaType get(Url url_p1, string property_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1})"
	/// </summary>
	public static extern LuaType get(Url url_p1, Hash property_p2);
	
	
	/// <summary>
	/// gets a named property of the specified game object or component
	/// 
	/// @CSharpLua.Template = "go.get({0}, {1}, {2})"
	/// </summary>
	public static extern LuaType get(Url url_p1, Hash property_p2, ILuaTable options_p3);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2})"
	/// </summary>
	public static extern void set(string url_p1, string property_p2, LuaType value_p3);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set(string url_p1, string property_p2, LuaType value_p3, ILuaTable options_p4);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2})"
	/// </summary>
	public static extern void set(string url_p1, Hash property_p2, LuaType value_p3);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set(string url_p1, Hash property_p2, LuaType value_p3, ILuaTable options_p4);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2})"
	/// </summary>
	public static extern void set(Hash url_p1, string property_p2, LuaType value_p3);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set(Hash url_p1, string property_p2, LuaType value_p3, ILuaTable options_p4);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2})"
	/// </summary>
	public static extern void set(Hash url_p1, Hash property_p2, LuaType value_p3);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set(Hash url_p1, Hash property_p2, LuaType value_p3, ILuaTable options_p4);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2})"
	/// </summary>
	public static extern void set(Url url_p1, string property_p2, LuaType value_p3);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set(Url url_p1, string property_p2, LuaType value_p3, ILuaTable options_p4);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2})"
	/// </summary>
	public static extern void set(Url url_p1, Hash property_p2, LuaType value_p3);
	
	
	/// <summary>
	/// sets a named property of the specified game object or component, or a material constant
	/// 
	/// @CSharpLua.Template = "go.set({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set(Url url_p1, Hash property_p2, LuaType value_p3, ILuaTable options_p4);
	
	
	/// <summary>
	/// The position is relative the parent (if any). Use <a href="/ref/go#go.get_world_position">go.get_world_position</a> to retrieve the global world position.
	/// 
	/// @CSharpLua.Template = "go.get_position()"
	/// </summary>
	public static extern Vector3 get_position();
	
	
	/// <summary>
	/// The position is relative the parent (if any). Use <a href="/ref/go#go.get_world_position">go.get_world_position</a> to retrieve the global world position.
	/// 
	/// @CSharpLua.Template = "go.get_position({0})"
	/// </summary>
	public static extern Vector3 get_position(string id_p1);
	
	
	/// <summary>
	/// The position is relative the parent (if any). Use <a href="/ref/go#go.get_world_position">go.get_world_position</a> to retrieve the global world position.
	/// 
	/// @CSharpLua.Template = "go.get_position({0})"
	/// </summary>
	public static extern Vector3 get_position(Hash id_p1);
	
	
	/// <summary>
	/// The position is relative the parent (if any). Use <a href="/ref/go#go.get_world_position">go.get_world_position</a> to retrieve the global world position.
	/// 
	/// @CSharpLua.Template = "go.get_position({0})"
	/// </summary>
	public static extern Vector3 get_position(Url id_p1);
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). Use <a href="/ref/go#go.get_world_rotation">go.get_world_rotation</a> to retrieve the global world rotation.
	/// 
	/// @CSharpLua.Template = "go.get_rotation()"
	/// </summary>
	public static extern Quaternion get_rotation();
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). Use <a href="/ref/go#go.get_world_rotation">go.get_world_rotation</a> to retrieve the global world rotation.
	/// 
	/// @CSharpLua.Template = "go.get_rotation({0})"
	/// </summary>
	public static extern Quaternion get_rotation(string id_p1);
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). Use <a href="/ref/go#go.get_world_rotation">go.get_world_rotation</a> to retrieve the global world rotation.
	/// 
	/// @CSharpLua.Template = "go.get_rotation({0})"
	/// </summary>
	public static extern Quaternion get_rotation(Hash id_p1);
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). Use <a href="/ref/go#go.get_world_rotation">go.get_world_rotation</a> to retrieve the global world rotation.
	/// 
	/// @CSharpLua.Template = "go.get_rotation({0})"
	/// </summary>
	public static extern Quaternion get_rotation(Url id_p1);
	
	
	/// <summary>
	/// The scale is relative the parent (if any). Use <a href="/ref/go#go.get_world_scale">go.get_world_scale</a> to retrieve the global world 3D scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale()"
	/// </summary>
	public static extern Vector3 get_scale();
	
	
	/// <summary>
	/// The scale is relative the parent (if any). Use <a href="/ref/go#go.get_world_scale">go.get_world_scale</a> to retrieve the global world 3D scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale({0})"
	/// </summary>
	public static extern Vector3 get_scale(string id_p1);
	
	
	/// <summary>
	/// The scale is relative the parent (if any). Use <a href="/ref/go#go.get_world_scale">go.get_world_scale</a> to retrieve the global world 3D scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale({0})"
	/// </summary>
	public static extern Vector3 get_scale(Hash id_p1);
	
	
	/// <summary>
	/// The scale is relative the parent (if any). Use <a href="/ref/go#go.get_world_scale">go.get_world_scale</a> to retrieve the global world 3D scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale({0})"
	/// </summary>
	public static extern Vector3 get_scale(Url id_p1);
	
	
	/// <summary>
	/// The uniform scale is relative the parent (if any). If the underlying scale vector is non-uniform the min element of the vector is returned as the uniform scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale_uniform()"
	/// </summary>
	public static extern double get_scale_uniform();
	
	
	/// <summary>
	/// The uniform scale is relative the parent (if any). If the underlying scale vector is non-uniform the min element of the vector is returned as the uniform scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale_uniform({0})"
	/// </summary>
	public static extern double get_scale_uniform(string id_p1);
	
	
	/// <summary>
	/// The uniform scale is relative the parent (if any). If the underlying scale vector is non-uniform the min element of the vector is returned as the uniform scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale_uniform({0})"
	/// </summary>
	public static extern double get_scale_uniform(Hash id_p1);
	
	
	/// <summary>
	/// The uniform scale is relative the parent (if any). If the underlying scale vector is non-uniform the min element of the vector is returned as the uniform scale factor.
	/// 
	/// @CSharpLua.Template = "go.get_scale_uniform({0})"
	/// </summary>
	public static extern double get_scale_uniform(Url id_p1);
	
	
	/// <summary>
	/// The position is relative to the parent (if any). The global world position cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_position({0})"
	/// </summary>
	public static extern void set_position(Vector3 position_p1);
	
	
	/// <summary>
	/// The position is relative to the parent (if any). The global world position cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_position({0}, {1})"
	/// </summary>
	public static extern void set_position(Vector3 position_p1, string id_p2);
	
	
	/// <summary>
	/// The position is relative to the parent (if any). The global world position cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_position({0}, {1})"
	/// </summary>
	public static extern void set_position(Vector3 position_p1, Hash id_p2);
	
	
	/// <summary>
	/// The position is relative to the parent (if any). The global world position cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_position({0}, {1})"
	/// </summary>
	public static extern void set_position(Vector3 position_p1, Url id_p2);
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). The global world rotation cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_rotation({0})"
	/// </summary>
	public static extern void set_rotation(Quaternion rotation_p1);
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). The global world rotation cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_rotation({0}, {1})"
	/// </summary>
	public static extern void set_rotation(Quaternion rotation_p1, string id_p2);
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). The global world rotation cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_rotation({0}, {1})"
	/// </summary>
	public static extern void set_rotation(Quaternion rotation_p1, Hash id_p2);
	
	
	/// <summary>
	/// The rotation is relative to the parent (if any). The global world rotation cannot be manually set.
	/// 
	/// @CSharpLua.Template = "go.set_rotation({0}, {1})"
	/// </summary>
	public static extern void set_rotation(Quaternion rotation_p1, Url id_p2);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0})"
	/// </summary>
	public static extern void set_scale(double scale_p1);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(double scale_p1, string id_p2);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(double scale_p1, Hash id_p2);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(double scale_p1, Url id_p2);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0})"
	/// </summary>
	public static extern void set_scale(Vector3 scale_p1);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(Vector3 scale_p1, string id_p2);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(Vector3 scale_p1, Hash id_p2);
	
	
	/// <summary>
	/// The scale factor is relative to the parent (if any). The global world scale factor cannot be manually set.
	/// <span class="icon-attention"></span> Physics are currently not affected when setting scale from this function.
	/// 
	/// @CSharpLua.Template = "go.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(Vector3 scale_p1, Url id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent()"
	/// </summary>
	public static extern void set_parent();
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0})"
	/// </summary>
	public static extern void set_parent(string id_p1);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(string id_p1, string parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(string id_p1, string parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(string id_p1, Hash parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(string id_p1, Hash parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(string id_p1, Url parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(string id_p1, Url parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0})"
	/// </summary>
	public static extern void set_parent(Hash id_p1);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(Hash id_p1, string parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Hash id_p1, string parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(Hash id_p1, Hash parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Hash id_p1, Hash parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(Hash id_p1, Url parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Hash id_p1, Url parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0})"
	/// </summary>
	public static extern void set_parent(Url id_p1);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(Url id_p1, string parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Url id_p1, string parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(Url id_p1, Hash parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Url id_p1, Hash parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1})"
	/// </summary>
	public static extern void set_parent(Url id_p1, Url parent_id_p2);
	
	
	/// <summary>
	/// Sets the parent for a game object instance. This means that the instance will exist in the geometrical space of its parent,
	/// like a basic transformation hierarchy or scene graph. If no parent is specified, the instance will be detached from any parent and exist in world
	/// space.
	/// This function will generate a <code>set_parent</code> message. It is not until the message has been processed that the change actually takes effect. This
	/// typically happens later in the same frame or the beginning of the next frame. Refer to the manual to learn how messages are processed by the
	/// engine.
	/// 
	/// @CSharpLua.Template = "go.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Url id_p1, Url parent_id_p2, bool keep_world_transform_p3);
	
	
	/// <summary>
	/// Get the parent for a game object instance.
	/// 
	/// @CSharpLua.Template = "go.get_parent()"
	/// </summary>
	public static extern Hash get_parent();
	
	
	/// <summary>
	/// Get the parent for a game object instance.
	/// 
	/// @CSharpLua.Template = "go.get_parent({0})"
	/// </summary>
	public static extern Hash get_parent(string id_p1);
	
	
	/// <summary>
	/// Get the parent for a game object instance.
	/// 
	/// @CSharpLua.Template = "go.get_parent({0})"
	/// </summary>
	public static extern Hash get_parent(Hash id_p1);
	
	
	/// <summary>
	/// Get the parent for a game object instance.
	/// 
	/// @CSharpLua.Template = "go.get_parent({0})"
	/// </summary>
	public static extern Hash get_parent(Url id_p1);
	
	
	/// <summary>
	/// The function will return the world position calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_position">go.get_position</a> to retrieve the position relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_position()"
	/// </summary>
	public static extern Vector3 get_world_position();
	
	
	/// <summary>
	/// The function will return the world position calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_position">go.get_position</a> to retrieve the position relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_position({0})"
	/// </summary>
	public static extern Vector3 get_world_position(string id_p1);
	
	
	/// <summary>
	/// The function will return the world position calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_position">go.get_position</a> to retrieve the position relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_position({0})"
	/// </summary>
	public static extern Vector3 get_world_position(Hash id_p1);
	
	
	/// <summary>
	/// The function will return the world position calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_position">go.get_position</a> to retrieve the position relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_position({0})"
	/// </summary>
	public static extern Vector3 get_world_position(Url id_p1);
	
	
	/// <summary>
	/// The function will return the world rotation calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_rotation">go.get_rotation</a> to retrieve the rotation relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_rotation()"
	/// </summary>
	public static extern Quaternion get_world_rotation();
	
	
	/// <summary>
	/// The function will return the world rotation calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_rotation">go.get_rotation</a> to retrieve the rotation relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_rotation({0})"
	/// </summary>
	public static extern Quaternion get_world_rotation(string id_p1);
	
	
	/// <summary>
	/// The function will return the world rotation calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_rotation">go.get_rotation</a> to retrieve the rotation relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_rotation({0})"
	/// </summary>
	public static extern Quaternion get_world_rotation(Hash id_p1);
	
	
	/// <summary>
	/// The function will return the world rotation calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_rotation">go.get_rotation</a> to retrieve the rotation relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_rotation({0})"
	/// </summary>
	public static extern Quaternion get_world_rotation(Url id_p1);
	
	
	/// <summary>
	/// The function will return the world 3D scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale">go.get_scale</a> to retrieve the 3D scale factor relative to the parent.
	/// This vector is derived by decomposing the transformation matrix and should be used with care.
	/// For most cases it should be fine to use <a href="/ref/go#go.get_world_scale_uniform">go.get_world_scale_uniform</a> instead.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale()"
	/// </summary>
	public static extern Vector3 get_world_scale();
	
	
	/// <summary>
	/// The function will return the world 3D scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale">go.get_scale</a> to retrieve the 3D scale factor relative to the parent.
	/// This vector is derived by decomposing the transformation matrix and should be used with care.
	/// For most cases it should be fine to use <a href="/ref/go#go.get_world_scale_uniform">go.get_world_scale_uniform</a> instead.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale({0})"
	/// </summary>
	public static extern Vector3 get_world_scale(string id_p1);
	
	
	/// <summary>
	/// The function will return the world 3D scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale">go.get_scale</a> to retrieve the 3D scale factor relative to the parent.
	/// This vector is derived by decomposing the transformation matrix and should be used with care.
	/// For most cases it should be fine to use <a href="/ref/go#go.get_world_scale_uniform">go.get_world_scale_uniform</a> instead.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale({0})"
	/// </summary>
	public static extern Vector3 get_world_scale(Hash id_p1);
	
	
	/// <summary>
	/// The function will return the world 3D scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale">go.get_scale</a> to retrieve the 3D scale factor relative to the parent.
	/// This vector is derived by decomposing the transformation matrix and should be used with care.
	/// For most cases it should be fine to use <a href="/ref/go#go.get_world_scale_uniform">go.get_world_scale_uniform</a> instead.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale({0})"
	/// </summary>
	public static extern Vector3 get_world_scale(Url id_p1);
	
	
	/// <summary>
	/// The function will return the world scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale_uniform">go.get_scale_uniform</a> to retrieve the scale factor relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale_uniform()"
	/// </summary>
	public static extern double get_world_scale_uniform();
	
	
	/// <summary>
	/// The function will return the world scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale_uniform">go.get_scale_uniform</a> to retrieve the scale factor relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale_uniform({0})"
	/// </summary>
	public static extern double get_world_scale_uniform(string id_p1);
	
	
	/// <summary>
	/// The function will return the world scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale_uniform">go.get_scale_uniform</a> to retrieve the scale factor relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale_uniform({0})"
	/// </summary>
	public static extern double get_world_scale_uniform(Hash id_p1);
	
	
	/// <summary>
	/// The function will return the world scale factor calculated at the end of the previous frame.
	/// Use <a href="/ref/go#go.get_scale_uniform">go.get_scale_uniform</a> to retrieve the scale factor relative to the parent.
	/// 
	/// @CSharpLua.Template = "go.get_world_scale_uniform({0})"
	/// </summary>
	public static extern double get_world_scale_uniform(Url id_p1);
	
	
	/// <summary>
	/// The function will return the world transform matrix calculated at the end of the previous frame.
	/// 
	/// @CSharpLua.Template = "go.get_world_transform()"
	/// </summary>
	public static extern Matrix4 get_world_transform();
	
	
	/// <summary>
	/// The function will return the world transform matrix calculated at the end of the previous frame.
	/// 
	/// @CSharpLua.Template = "go.get_world_transform({0})"
	/// </summary>
	public static extern Matrix4 get_world_transform(string id_p1);
	
	
	/// <summary>
	/// The function will return the world transform matrix calculated at the end of the previous frame.
	/// 
	/// @CSharpLua.Template = "go.get_world_transform({0})"
	/// </summary>
	public static extern Matrix4 get_world_transform(Hash id_p1);
	
	
	/// <summary>
	/// The function will return the world transform matrix calculated at the end of the previous frame.
	/// 
	/// @CSharpLua.Template = "go.get_world_transform({0})"
	/// </summary>
	public static extern Matrix4 get_world_transform(Url id_p1);
	
	
	/// <summary>
	/// Returns or constructs an instance identifier. The instance id is a hash
	/// of the absolute path to the instance.
	/// <ul>
	/// <li>If <code>path</code> is specified, it can either be absolute or relative to the instance of the calling script.</li>
	/// <li>If <code>path</code> is not specified, the id of the game object instance the script is attached to will be returned.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "go.get_id()"
	/// </summary>
	public static extern Hash get_id();
	
	
	/// <summary>
	/// Returns or constructs an instance identifier. The instance id is a hash
	/// of the absolute path to the instance.
	/// <ul>
	/// <li>If <code>path</code> is specified, it can either be absolute or relative to the instance of the calling script.</li>
	/// <li>If <code>path</code> is not specified, the id of the game object instance the script is attached to will be returned.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "go.get_id({0})"
	/// </summary>
	public static extern Hash get_id(string path_p1);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0})"
	/// </summary>
	public static extern void cancel_animations(string url_p1);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
	/// </summary>
	public static extern void cancel_animations(string url_p1, string property_p2);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
	/// </summary>
	public static extern void cancel_animations(string url_p1, Hash property_p2);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0})"
	/// </summary>
	public static extern void cancel_animations(Hash url_p1);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
	/// </summary>
	public static extern void cancel_animations(Hash url_p1, string property_p2);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
	/// </summary>
	public static extern void cancel_animations(Hash url_p1, Hash property_p2);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0})"
	/// </summary>
	public static extern void cancel_animations(Url url_p1);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
	/// </summary>
	public static extern void cancel_animations(Url url_p1, string property_p2);
	
	
	/// <summary>
	/// By calling this function, all or specified stored property animations of the game object or component will be canceled.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how to animate them.
	/// 
	/// @CSharpLua.Template = "go.cancel_animations({0}, {1})"
	/// </summary>
	public static extern void cancel_animations(Url url_p1, Hash property_p2);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete()"
	/// </summary>
	public static extern void delete();
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0})"
	/// </summary>
	public static extern void delete(string id_p1);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0}, {1})"
	/// </summary>
	public static extern void delete(string id_p1, bool recursive_p2);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0})"
	/// </summary>
	public static extern void delete(Hash id_p1);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0}, {1})"
	/// </summary>
	public static extern void delete(Hash id_p1, bool recursive_p2);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0})"
	/// </summary>
	public static extern void delete(Url id_p1);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0}, {1})"
	/// </summary>
	public static extern void delete(Url id_p1, bool recursive_p2);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0})"
	/// </summary>
	public static extern void delete(ILuaTable id_p1);
	
	
	/// <summary>
	/// Delete one or more game objects identified by id. Deletion is asynchronous meaning that
	/// the game object(s) are scheduled for deletion which will happen at the end of the current
	/// frame. Note that game objects scheduled for deletion will be counted against
	/// <code>max_instances</code> in "game.project" until they are actually removed.
	/// <span class="icon-attention"></span> Deleting a game object containing a particle FX component emitting particles will not immediately stop the particle FX from emitting particles. You need to manually stop the particle FX using <code>particlefx.stop()</code>.
	/// <span class="icon-attention"></span> Deleting a game object containing a sound component that is playing will not immediately stop the sound from playing. You need to manually stop the sound using <code>sound.stop()</code>.
	/// 
	/// @CSharpLua.Template = "go.delete({0}, {1})"
	/// </summary>
	public static extern void delete(ILuaTable id_p1, bool recursive_p2);
	
	
	/// <summary>
	/// This function defines a property which can then be used in the script through the self-reference.
	/// The properties defined this way are automatically exposed in the editor in game objects and collections which use the script.
	/// Note that you can only use this function outside any callback-functions like init and update.
	/// 
	/// @CSharpLua.Template = "go.property({0}, {1})"
	/// </summary>
	public static extern void property(string name_p1, double value_p2);
	
	
	/// <summary>
	/// This function defines a property which can then be used in the script through the self-reference.
	/// The properties defined this way are automatically exposed in the editor in game objects and collections which use the script.
	/// Note that you can only use this function outside any callback-functions like init and update.
	/// 
	/// @CSharpLua.Template = "go.property({0}, {1})"
	/// </summary>
	public static extern void property(string name_p1, Hash value_p2);
	
	
	/// <summary>
	/// This function defines a property which can then be used in the script through the self-reference.
	/// The properties defined this way are automatically exposed in the editor in game objects and collections which use the script.
	/// Note that you can only use this function outside any callback-functions like init and update.
	/// 
	/// @CSharpLua.Template = "go.property({0}, {1})"
	/// </summary>
	public static extern void property(string name_p1, Url value_p2);
	
	
	/// <summary>
	/// This function defines a property which can then be used in the script through the self-reference.
	/// The properties defined this way are automatically exposed in the editor in game objects and collections which use the script.
	/// Note that you can only use this function outside any callback-functions like init and update.
	/// 
	/// @CSharpLua.Template = "go.property({0}, {1})"
	/// </summary>
	public static extern void property(string name_p1, Vector3 value_p2);
	
	
	/// <summary>
	/// This function defines a property which can then be used in the script through the self-reference.
	/// The properties defined this way are automatically exposed in the editor in game objects and collections which use the script.
	/// Note that you can only use this function outside any callback-functions like init and update.
	/// 
	/// @CSharpLua.Template = "go.property({0}, {1})"
	/// </summary>
	public static extern void property(string name_p1, Vector4 value_p2);
	
	
	/// <summary>
	/// This function defines a property which can then be used in the script through the self-reference.
	/// The properties defined this way are automatically exposed in the editor in game objects and collections which use the script.
	/// Note that you can only use this function outside any callback-functions like init and update.
	/// 
	/// @CSharpLua.Template = "go.property({0}, {1})"
	/// </summary>
	public static extern void property(string name_p1, Quaternion value_p2);
	
	
	/// <summary>
	/// This is a callback-function, which is called by the engine when a script component is initialized. It can be used
	/// to set the initial state of the script.
	/// 
	/// @CSharpLua.Template = "go.init({0})"
	/// </summary>
	public static extern void init(object self_p1);
	
	
	/// <summary>
	/// This is a callback-function, which is called by the engine when a script component is finalized (destroyed). It can
	/// be used to e.g. take some last action, report the finalization to other game object instances, delete spawned objects
	/// or release user input focus (see <a href="#release_input_focus">release_input_focus</a>).
	/// 
	/// @CSharpLua.Template = "go.final({0})"
	/// </summary>
	public static extern void final(object self_p1);
	
	
	/// <summary>
	/// This is a callback-function, which is called by the engine every frame to update the state of a script component.
	/// It can be used to perform any kind of game related tasks, e.g. moving the game object instance.
	/// 
	/// @CSharpLua.Template = "go.update({0}, {1})"
	/// </summary>
	public static extern void update(object self_p1, double dt_p2);
	
	
	/// <summary>
	/// This is a callback-function, which is called by the engine whenever a message has been sent to the script component.
	/// It can be used to take action on the message, e.g. send a response back to the sender of the message.
	/// The <code>message</code> parameter is a table containing the message data. If the message is sent from the engine, the
	/// documentation of the message specifies which data is supplied.
	/// 
	/// @CSharpLua.Template = "go.on_message({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void on_message(object self_p1, Hash message_id_p2, ILuaTable message_p3, Url sender_p4);
	
	
	/// <summary>
	/// This is a callback-function, which is called by the engine when user input is sent to the game object instance of the script.
	/// It can be used to take action on the input, e.g. move the instance according to the input.
	/// For an instance to obtain user input, it must first acquire input focus
	/// through the message <code>acquire_input_focus</code>.
	/// Any instance that has obtained input will be put on top of an
	/// input stack. Input is sent to all listeners on the stack until the
	/// end of stack is reached, or a listener returns <code>true</code>
	/// to signal that it wants input to be consumed.
	/// See the documentation of <a href="#acquire_input_focus">acquire_input_focus</a> for more
	/// information.
	/// The <code>action</code> parameter is a table containing data about the input mapped to the
	/// <code>action_id</code>.
	/// For mapped actions it specifies the value of the input and if it was just pressed or released.
	/// Actions are mapped to input in an input_binding-file.
	/// Mouse movement is specifically handled and uses <code>nil</code> as its <code>action_id</code>.
	/// The <code>action</code> only contains positional parameters in this case, such as x and y of the pointer.
	/// Here is a brief description of the available table fields:
	/// <table>
	/// <thead>
	/// <tr>
	/// <th>Field</th>
	/// <th>Description</th>
	/// </tr>
	/// </thead>
	/// <tbody>
	/// <tr>
	/// <td><code>value</code></td>
	/// <td>The amount of input given by the user. This is usually 1 for buttons and 0-1 for analogue inputs. This is not present for mouse movement.</td>
	/// </tr>
	/// <tr>
	/// <td><code>pressed</code></td>
	/// <td>If the input was pressed this frame. This is not present for mouse movement.</td>
	/// </tr>
	/// <tr>
	/// <td><code>released</code></td>
	/// <td>If the input was released this frame. This is not present for mouse movement.</td>
	/// </tr>
	/// <tr>
	/// <td><code>repeated</code></td>
	/// <td>If the input was repeated this frame. This is similar to how a key on a keyboard is repeated when you hold it down. This is not present for mouse movement.</td>
	/// </tr>
	/// <tr>
	/// <td><code>x</code></td>
	/// <td>The x value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>y</code></td>
	/// <td>The y value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>screen_x</code></td>
	/// <td>The screen space x value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>screen_y</code></td>
	/// <td>The screen space y value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>dx</code></td>
	/// <td>The change in x value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>dy</code></td>
	/// <td>The change in y value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>screen_dx</code></td>
	/// <td>The change in screen space x value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>screen_dy</code></td>
	/// <td>The change in screen space y value of a pointer device, if present.</td>
	/// </tr>
	/// <tr>
	/// <td><code>gamepad</code></td>
	/// <td>The index of the gamepad device that provided the input.</td>
	/// </tr>
	/// <tr>
	/// <td><code>touch</code></td>
	/// <td>List of touch input, one element per finger, if present. See table below about touch input</td>
	/// </tr>
	/// </tbody>
	/// </table>
	/// Touch input table:
	/// <table>
	/// <thead>
	/// <tr>
	/// <th>Field</th>
	/// <th>Description</th>
	/// </tr>
	/// </thead>
	/// <tbody>
	/// <tr>
	/// <td><code>id</code></td>
	/// <td>A number identifying the touch input during its duration.</td>
	/// </tr>
	/// <tr>
	/// <td><code>pressed</code></td>
	/// <td>True if the finger was pressed this frame.</td>
	/// </tr>
	/// <tr>
	/// <td><code>released</code></td>
	/// <td>True if the finger was released this frame.</td>
	/// </tr>
	/// <tr>
	/// <td><code>tap_count</code></td>
	/// <td>Number of taps, one for single, two for double-tap, etc</td>
	/// </tr>
	/// <tr>
	/// <td><code>x</code></td>
	/// <td>The x touch location.</td>
	/// </tr>
	/// <tr>
	/// <td><code>y</code></td>
	/// <td>The y touch location.</td>
	/// </tr>
	/// <tr>
	/// <td><code>dx</code></td>
	/// <td>The change in x value.</td>
	/// </tr>
	/// <tr>
	/// <td><code>dy</code></td>
	/// <td>The change in y value.</td>
	/// </tr>
	/// <tr>
	/// <td><code>acc_x</code></td>
	/// <td>Accelerometer x value (if present).</td>
	/// </tr>
	/// <tr>
	/// <td><code>acc_y</code></td>
	/// <td>Accelerometer y value (if present).</td>
	/// </tr>
	/// <tr>
	/// <td><code>acc_z</code></td>
	/// <td>Accelerometer z value (if present).</td>
	/// </tr>
	/// </tbody>
	/// </table>
	/// 
	/// @CSharpLua.Template = "go.on_input({0}, {1}, {2})"
	/// </summary>
	public static extern bool on_input(object self_p1, Hash action_id_p2, ILuaTable action_p3);
	
	
	/// <summary>
	/// This is a callback-function, which is called by the engine when the script component is reloaded, e.g. from the editor.
	/// It can be used for live development, e.g. to tweak constants or set up the state properly for the instance.
	/// 
	/// @CSharpLua.Template = "go.on_reload({0})"
	/// </summary>
	public static extern void on_reload(object self_p1);
	
	
	#endregion Defold API
}
