using System;
using support;
using lua;
using types;

/// <summary>
/// Game object API documentation
/// 
/// </summary>
public static class Go
{
	#region Defold API
	#region Messages
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


	#endregion Messages


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
	public static extern LuaType get(string url_p1, string property_p2, LuaTableBase options_p3);


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
	public static extern LuaType get(string url_p1, Hash property_p2, LuaTableBase options_p3);


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
	public static extern LuaType get(Hash url_p1, string property_p2, LuaTableBase options_p3);


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
	public static extern LuaType get(Hash url_p1, Hash property_p2, LuaTableBase options_p3);


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
	public static extern LuaType get(Url url_p1, string property_p2, LuaTableBase options_p3);


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
	public static extern LuaType get(Url url_p1, Hash property_p2, LuaTableBase options_p3);


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
	public static extern void set(string url_p1, string property_p2, LuaType value_p3, LuaTableBase options_p4);


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
	public static extern void set(string url_p1, Hash property_p2, LuaType value_p3, LuaTableBase options_p4);


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
	public static extern void set(Hash url_p1, string property_p2, LuaType value_p3, LuaTableBase options_p4);


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
	public static extern void set(Hash url_p1, Hash property_p2, LuaType value_p3, LuaTableBase options_p4);


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
	public static extern void set(Url url_p1, string property_p2, LuaType value_p3, LuaTableBase options_p4);


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
	public static extern void set(Url url_p1, Hash property_p2, LuaType value_p3, LuaTableBase options_p4);


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
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(string url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Hash url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, string property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, double to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector3 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Vector4 to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7);


	/// <summary>
	/// This is only supported for numerical properties. If the node property is already being
	/// animated, that animation will be canceled and replaced by the new one.
	/// If a <code>complete_function</code> (lua function) is specified, that function will be called when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced together. See the examples for more information.
	/// <span class="icon-attention"></span> If you call <code>go.animate()</code> from a game object's <code>final()</code> function,
	/// any passed <code>complete_function</code> will be ignored and never called upon animation completion.
	/// See the <a href="/manuals/properties">properties guide</a> for which properties can be animated and the <a href="/manuals/animation">animation guide</a> for how
	/// them.
	/// 
	/// @CSharpLua.Template = "go.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Url url_p1, Hash property_p2, GoPlaybackMode playback_p3, Quaternion to_p4, Easing easing_p5, double duration_p6, double delay_p7, Action<object,Url,Hash> complete_function_p8);


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
	public static extern void delete(LuaTableBase id_p1);


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
	public static extern void delete(LuaTableBase id_p1, bool recursive_p2);


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


	#endregion Defold API
}
