using System;
using lua;
using types;

/// <summary>
/// GUI API documentation
/// 
/// </summary>
public static class Gui
{
	#region Defold API
	#region Messages
	/// <summary>
	/// </summary>
	public class layout_changed_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("layout_changed");
		public override Hash FetchCode() => __CODE__;

		public Hash id;
		public Hash previous_id;
	}


	#endregion Messages


	/// <summary>
	/// Retrieves the node with the specified id.
	/// 
	/// @CSharpLua.Template = "gui.get_node({0})"
	/// </summary>
	public static extern Node get_node(string id_p1);


	/// <summary>
	/// Retrieves the node with the specified id.
	/// 
	/// @CSharpLua.Template = "gui.get_node({0})"
	/// </summary>
	public static extern Node get_node(Hash id_p1);


	/// <summary>
	/// Retrieves the id of the specified node.
	/// 
	/// @CSharpLua.Template = "gui.get_id({0})"
	/// </summary>
	public static extern Hash get_id(Node node_p1);


	/// <summary>
	/// Set the id of the specicied node to a new value.
	/// Nodes created with the gui.new_*_node() functions get
	/// an empty id. This function allows you to give dynamically
	/// created nodes an id.
	/// <span class="icon-attention"></span> No checking is done on the uniqueness of supplied ids.
	/// It is up to you to make sure you use unique ids.
	/// 
	/// @CSharpLua.Template = "gui.set_id({0}, {1})"
	/// </summary>
	public static extern void set_id(Node node_p1, string id_p2);


	/// <summary>
	/// Set the id of the specicied node to a new value.
	/// Nodes created with the gui.new_*_node() functions get
	/// an empty id. This function allows you to give dynamically
	/// created nodes an id.
	/// <span class="icon-attention"></span> No checking is done on the uniqueness of supplied ids.
	/// It is up to you to make sure you use unique ids.
	/// 
	/// @CSharpLua.Template = "gui.set_id({0}, {1})"
	/// </summary>
	public static extern void set_id(Node node_p1, Hash id_p2);


	/// <summary>
	/// Retrieve the index of the specified node among its siblings.
	/// The index defines the order in which a node appear in a GUI scene.
	/// Higher index means the node is drawn on top of lower indexed nodes.
	/// 
	/// @CSharpLua.Template = "gui.get_index({0})"
	/// </summary>
	public static extern double get_index(Node node_p1);


	/// <summary>
	/// Deletes the specified node. Any child nodes of the specified node will be
	/// recursively deleted.
	/// 
	/// @CSharpLua.Template = "gui.delete_node({0})"
	/// </summary>
	public static extern void delete_node(Node node_p1);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, double to_p3, Easing easing_p4, double duration_p5);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, double to_p3, Easing easing_p4, double duration_p5, double delay_p6);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, double to_p3, Easing easing_p4, double duration_p5, double delay_p6, Action<object,Node> complete_function_p7);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, double to_p3, Easing easing_p4, double duration_p5, double delay_p6, Action<object,Node> complete_function_p7, GuiPlaybackMode playback_p8);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector3 to_p3, Easing easing_p4, double duration_p5);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector3 to_p3, Easing easing_p4, double duration_p5, double delay_p6);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector3 to_p3, Easing easing_p4, double duration_p5, double delay_p6, Action<object,Node> complete_function_p7);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector3 to_p3, Easing easing_p4, double duration_p5, double delay_p6, Action<object,Node> complete_function_p7, GuiPlaybackMode playback_p8);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector4 to_p3, Easing easing_p4, double duration_p5);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector4 to_p3, Easing easing_p4, double duration_p5, double delay_p6);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector4 to_p3, Easing easing_p4, double duration_p5, double delay_p6, Action<object,Node> complete_function_p7);


	/// <summary>
	/// This starts an animation of a node property according to the specified parameters.
	/// If the node property is already being animated, that animation will be canceled and
	/// replaced by the new one. Note however that several different node properties
	/// can be animated simultaneously. Use <code>gui.cancel_animation</code> to stop the animation
	/// before it has completed.
	/// Composite properties of type vector3, vector4 or quaternion
	/// also expose their sub-components (x, y, z and w).
	/// You can address the components individually by suffixing the name with a dot '.'
	/// and the name of the component.
	/// For instance, <code>"position.x"</code> (the position x coordinate) or <code>"color.w"</code>
	/// (the color alpha value).
	/// If a <code>complete_function</code> (Lua function) is specified, that function will be called
	/// when the animation has completed.
	/// By starting a new animation in that function, several animations can be sequenced
	/// together. See the examples below for more information.
	/// 
	/// @CSharpLua.Template = "gui.animate({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
	/// </summary>
	public static extern void animate(Node node_p1, string property_p2, Vector4 to_p3, Easing easing_p4, double duration_p5, double delay_p6, Action<object,Node> complete_function_p7, GuiPlaybackMode playback_p8);


	/// <summary>
	/// If an animation of the specified node is currently running (started by <code>gui.animate</code>), it will immediately be canceled.
	/// 
	/// @CSharpLua.Template = "gui.cancel_animation({0}, {1})"
	/// </summary>
	public static extern void cancel_animation(Node node_p1, string property_p2);


	/// <summary>
	/// Dynamically create a new box node.
	/// 
	/// @CSharpLua.Template = "gui.new_box_node({0}, {1})"
	/// </summary>
	public static extern Node new_box_node(Vector3 pos_p1, Vector3 size_p2);


	/// <summary>
	/// Dynamically create a new box node.
	/// 
	/// @CSharpLua.Template = "gui.new_box_node({0}, {1})"
	/// </summary>
	public static extern Node new_box_node(Vector4 pos_p1, Vector3 size_p2);


	/// <summary>
	/// Dynamically create a new text node.
	/// 
	/// @CSharpLua.Template = "gui.new_text_node({0}, {1})"
	/// </summary>
	public static extern Node new_text_node(Vector3 pos_p1, string text_p2);


	/// <summary>
	/// Dynamically create a new text node.
	/// 
	/// @CSharpLua.Template = "gui.new_text_node({0}, {1})"
	/// </summary>
	public static extern Node new_text_node(Vector4 pos_p1, string text_p2);


	/// <summary>
	/// Dynamically create a new pie node.
	/// 
	/// @CSharpLua.Template = "gui.new_pie_node({0}, {1})"
	/// </summary>
	public static extern Node new_pie_node(Vector3 pos_p1, Vector3 size_p2);


	/// <summary>
	/// Dynamically create a new pie node.
	/// 
	/// @CSharpLua.Template = "gui.new_pie_node({0}, {1})"
	/// </summary>
	public static extern Node new_pie_node(Vector4 pos_p1, Vector3 size_p2);


	/// <summary>
	/// Returns the text value of a text node. This is only useful for text nodes.
	/// 
	/// @CSharpLua.Template = "gui.get_text({0})"
	/// </summary>
	public static extern string get_text(Node node_p1);


	/// <summary>
	/// Set the text value of a text node. This is only useful for text nodes.
	/// 
	/// @CSharpLua.Template = "gui.set_text({0}, {1})"
	/// </summary>
	public static extern void set_text(Node node_p1, string text_p2);


	/// <summary>
	/// Returns whether a text node is in line-break mode or not.
	/// This is only useful for text nodes.
	/// 
	/// @CSharpLua.Template = "gui.get_line_break({0})"
	/// </summary>
	public static extern bool get_line_break(Node node_p1);


	/// <summary>
	/// Sets the line-break mode on a text node.
	/// This is only useful for text nodes.
	/// 
	/// @CSharpLua.Template = "gui.set_line_break({0}, {1})"
	/// </summary>
	public static extern void set_line_break(Node node_p1, bool line_break_p2);


	/// <summary>
	/// Returns the blend mode of a node.
	/// Blend mode defines how the node will be blended with the background.
	/// 
	/// @CSharpLua.Template = "gui.get_blend_mode()"
	/// </summary>
	public static extern BlendMode get_blend_mode();


	/// <summary>
	/// Set the blend mode of a node.
	/// Blend mode defines how the node will be blended with the background.
	/// 
	/// @CSharpLua.Template = "gui.set_blend_mode({0}, {1})"
	/// </summary>
	public static extern void set_blend_mode(Node node_p1, BlendMode blend_mode_p2);


	/// <summary>
	/// Returns the texture of a node.
	/// This is currently only useful for box or pie nodes.
	/// The texture must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.get_texture({0})"
	/// </summary>
	public static extern Hash get_texture(Node node_p1);


	/// <summary>
	/// Set the texture on a box or pie node. The texture must be mapped to
	/// the gui scene in the gui editor. The function points out which texture
	/// the node should render from. If the texture is an atlas, further
	/// information is needed to select which image/animation in the atlas
	/// to render. In such cases, use <code>gui.play_flipbook()</code> in
	/// addition to this function.
	/// 
	/// @CSharpLua.Template = "gui.set_texture({0}, {1})"
	/// </summary>
	public static extern void set_texture(Node node_p1, string texture_p2);


	/// <summary>
	/// Set the texture on a box or pie node. The texture must be mapped to
	/// the gui scene in the gui editor. The function points out which texture
	/// the node should render from. If the texture is an atlas, further
	/// information is needed to select which image/animation in the atlas
	/// to render. In such cases, use <code>gui.play_flipbook()</code> in
	/// addition to this function.
	/// 
	/// @CSharpLua.Template = "gui.set_texture({0}, {1})"
	/// </summary>
	public static extern void set_texture(Node node_p1, Hash texture_p2);


	/// <summary>
	/// Get node flipbook animation.
	/// 
	/// @CSharpLua.Template = "gui.get_flipbook({0})"
	/// </summary>
	public static extern Hash get_flipbook(Node node_p1);


	/// <summary>
	/// Play flipbook animation on a box or pie node.
	/// The current node texture must contain the animation.
	/// Use this function to set one-frame still images on the node.
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, string animation_p2);


	/// <summary>
	/// Play flipbook animation on a box or pie node.
	/// The current node texture must contain the animation.
	/// Use this function to set one-frame still images on the node.
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, string animation_p2, Action<object,Node> complete_function_p3);


	/// <summary>
	/// Play flipbook animation on a box or pie node.
	/// The current node texture must contain the animation.
	/// Use this function to set one-frame still images on the node.
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, string animation_p2, Action<object,Node> complete_function_p3, LuaTable play_properties_p4);


	/// <summary>
	/// Play flipbook animation on a box or pie node.
	/// The current node texture must contain the animation.
	/// Use this function to set one-frame still images on the node.
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, Hash animation_p2);


	/// <summary>
	/// Play flipbook animation on a box or pie node.
	/// The current node texture must contain the animation.
	/// Use this function to set one-frame still images on the node.
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, Hash animation_p2, Action<object,Node> complete_function_p3);


	/// <summary>
	/// Play flipbook animation on a box or pie node.
	/// The current node texture must contain the animation.
	/// Use this function to set one-frame still images on the node.
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, Hash animation_p2, Action<object,Node> complete_function_p3, LuaTable play_properties_p4);


	/// <summary>
	/// Cancels any running flipbook animation on the specified node.
	/// 
	/// @CSharpLua.Template = "gui.cancel_flipbook({0})"
	/// </summary>
	public static extern void cancel_flipbook(Node node_p1);


	/// <summary>
	/// Dynamically create a new texture.
	/// 
	/// @CSharpLua.Template = "gui.new_texture({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool new_texture(string texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6, out double code_o1);


	/// <summary>
	/// Dynamically create a new texture.
	/// 
	/// @CSharpLua.Template = "gui.new_texture({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool new_texture(Hash texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6, out double code_o1);


	/// <summary>
	/// Delete a dynamically created texture.
	/// 
	/// @CSharpLua.Template = "gui.delete_texture({0})"
	/// </summary>
	public static extern void delete_texture(string texture_p1);


	/// <summary>
	/// Delete a dynamically created texture.
	/// 
	/// @CSharpLua.Template = "gui.delete_texture({0})"
	/// </summary>
	public static extern void delete_texture(Hash texture_p1);


	/// <summary>
	/// Set the texture buffer data for a dynamically created texture.
	/// 
	/// @CSharpLua.Template = "gui.set_texture_data({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool set_texture_data(string texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6);


	/// <summary>
	/// Set the texture buffer data for a dynamically created texture.
	/// 
	/// @CSharpLua.Template = "gui.set_texture_data({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool set_texture_data(Hash texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6);


	/// <summary>
	/// This is only useful for text nodes. The font must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.get_font({0})"
	/// </summary>
	public static extern Hash get_font(Node node_p1);


	/// <summary>
	/// This is only useful for text nodes. The font must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.get_font_resource({0})"
	/// </summary>
	public static extern Hash get_font_resource(Hash font_name_p1);


	/// <summary>
	/// This is only useful for text nodes. The font must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.get_font_resource({0})"
	/// </summary>
	public static extern Hash get_font_resource(string font_name_p1);


	/// <summary>
	/// This is only useful for text nodes.
	/// The font must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.set_font({0}, {1})"
	/// </summary>
	public static extern void set_font(Node node_p1, string font_p2);


	/// <summary>
	/// This is only useful for text nodes.
	/// The font must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.set_font({0}, {1})"
	/// </summary>
	public static extern void set_font(Node node_p1, Hash font_p2);


	/// <summary>
	/// The layer must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.get_layer({0})"
	/// </summary>
	public static extern Hash get_layer(Node node_p1);


	/// <summary>
	/// The layer must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.set_layer({0}, {1})"
	/// </summary>
	public static extern void set_layer(Node node_p1, string layer_p2);


	/// <summary>
	/// The layer must be mapped to the gui scene in the gui editor.
	/// 
	/// @CSharpLua.Template = "gui.set_layer({0}, {1})"
	/// </summary>
	public static extern void set_layer(Node node_p1, Hash layer_p2);


	/// <summary>
	/// gets the scene current layout
	/// 
	/// @CSharpLua.Template = "gui.get_layout()"
	/// </summary>
	public static extern Hash get_layout();


	/// <summary>
	/// Clipping mode defines how the node will clip it's children nodes
	/// 
	/// @CSharpLua.Template = "gui.get_clipping_mode()"
	/// </summary>
	public static extern ClippingMode get_clipping_mode();


	/// <summary>
	/// Clipping mode defines how the node will clip it's children nodes
	/// 
	/// @CSharpLua.Template = "gui.set_clipping_mode({0}, {1})"
	/// </summary>
	public static extern void set_clipping_mode(Node node_p1, ClippingMode clipping_mode_p2);


	/// <summary>
	/// If node is set as visible clipping node, it will be shown as well as clipping. Otherwise, it will only clip but not show visually.
	/// 
	/// @CSharpLua.Template = "gui.get_clipping_visible({0})"
	/// </summary>
	public static extern bool get_clipping_visible(Node node_p1);


	/// <summary>
	/// If node is set as an visible clipping node, it will be shown as well as clipping. Otherwise, it will only clip but not show visually.
	/// 
	/// @CSharpLua.Template = "gui.set_clipping_visible({0}, {1})"
	/// </summary>
	public static extern void set_clipping_visible(Node node_p1, bool visible_p2);


	/// <summary>
	/// If node is set as an inverted clipping node, it will clip anything inside as opposed to outside.
	/// 
	/// @CSharpLua.Template = "gui.get_clipping_inverted({0})"
	/// </summary>
	public static extern bool get_clipping_inverted(Node node_p1);


	/// <summary>
	/// If node is set as an inverted clipping node, it will clip anything inside as opposed to outside.
	/// 
	/// @CSharpLua.Template = "gui.set_clipping_inverted({0}, {1})"
	/// </summary>
	public static extern void set_clipping_inverted(Node node_p1, bool inverted_p2);


	/// <summary>
	/// The x-anchor specifies how the node is moved when the game is run in a different resolution.
	/// 
	/// @CSharpLua.Template = "gui.get_xanchor()"
	/// </summary>
	public static extern GuiAnchor get_xanchor();


	/// <summary>
	/// The x-anchor specifies how the node is moved when the game is run in a different resolution.
	/// 
	/// @CSharpLua.Template = "gui.set_xanchor({0}, {1})"
	/// </summary>
	public static extern void set_xanchor(Node node_p1, GuiAnchor anchor_p2);


	/// <summary>
	/// The y-anchor specifies how the node is moved when the game is run in a different resolution.
	/// 
	/// @CSharpLua.Template = "gui.get_yanchor()"
	/// </summary>
	public static extern GuiAnchor get_yanchor();


	/// <summary>
	/// The y-anchor specifies how the node is moved when the game is run in a different resolution.
	/// 
	/// @CSharpLua.Template = "gui.set_yanchor({0}, {1})"
	/// </summary>
	public static extern void set_yanchor(Node node_p1, GuiAnchor anchor_p2);


	/// <summary>
	/// The pivot specifies how the node is drawn and rotated from its position.
	/// 
	/// @CSharpLua.Template = "gui.get_pivot()"
	/// </summary>
	public static extern Node get_pivot(out GuiPivot pivot_o1);


	/// <summary>
	/// The pivot specifies how the node is drawn and rotated from its position.
	/// 
	/// @CSharpLua.Template = "gui.set_pivot({0}, {1})"
	/// </summary>
	public static extern void set_pivot(Node node_p1, GuiPivot pivot_p2);


	/// <summary>
	/// Returns the scene width.
	/// 
	/// @CSharpLua.Template = "gui.get_width()"
	/// </summary>
	public static extern double get_width();


	/// <summary>
	/// Returns the scene height.
	/// 
	/// @CSharpLua.Template = "gui.get_height()"
	/// </summary>
	public static extern double get_height();


	/// <summary>
	/// Set the slice9 configuration values for the node.
	/// 
	/// @CSharpLua.Template = "gui.set_slice9({0}, {1})"
	/// </summary>
	public static extern void set_slice9(Node node_p1, Vector4 values_p2);


	/// <summary>
	/// Returns the slice9 configuration values for the node.
	/// 
	/// @CSharpLua.Template = "gui.get_slice9({0})"
	/// </summary>
	public static extern Vector4 get_slice9(Node node_p1);


	/// <summary>
	/// Sets the number of generated vertices around the perimeter of a pie node.
	/// 
	/// @CSharpLua.Template = "gui.set_perimeter_vertices({0}, {1})"
	/// </summary>
	public static extern void set_perimeter_vertices(Node node_p1, double vertices_p2);


	/// <summary>
	/// Returns the number of generated vertices around the perimeter
	/// of a pie node.
	/// 
	/// @CSharpLua.Template = "gui.get_perimeter_vertices({0})"
	/// </summary>
	public static extern double get_perimeter_vertices(Node node_p1);


	/// <summary>
	/// Set the sector angle of a pie node.
	/// 
	/// @CSharpLua.Template = "gui.set_fill_angle({0}, {1})"
	/// </summary>
	public static extern void set_fill_angle(Node node_p1, double angle_p2);


	/// <summary>
	/// Returns the sector angle of a pie node.
	/// 
	/// @CSharpLua.Template = "gui.get_fill_angle({0})"
	/// </summary>
	public static extern double get_fill_angle(Node node_p1);


	/// <summary>
	/// Sets the inner radius of a pie node.
	/// The radius is defined along the x-axis.
	/// 
	/// @CSharpLua.Template = "gui.set_inner_radius({0}, {1})"
	/// </summary>
	public static extern void set_inner_radius(Node node_p1, double radius_p2);


	/// <summary>
	/// Returns the inner radius of a pie node.
	/// The radius is defined along the x-axis.
	/// 
	/// @CSharpLua.Template = "gui.get_inner_radius({0})"
	/// </summary>
	public static extern double get_inner_radius(Node node_p1);


	/// <summary>
	/// Sets the outer bounds mode for a pie node.
	/// 
	/// @CSharpLua.Template = "gui.set_outer_bounds({0}, {1})"
	/// </summary>
	public static extern void set_outer_bounds(Node node_p1, PieBounds bounds_mode_p2);


	/// <summary>
	/// Returns the outer bounds mode for a pie node.
	/// 
	/// @CSharpLua.Template = "gui.get_outer_bounds({0})"
	/// </summary>
	public static extern PieBounds get_outer_bounds(Node node_p1);


	/// <summary>
	/// Sets the leading value for a text node. This value is used to
	/// scale the line spacing of text.
	/// 
	/// @CSharpLua.Template = "gui.set_leading({0}, {1})"
	/// </summary>
	public static extern void set_leading(Node node_p1, double leading_p2);


	/// <summary>
	/// Returns the leading value for a text node.
	/// 
	/// @CSharpLua.Template = "gui.get_leading({0})"
	/// </summary>
	public static extern double get_leading(Node node_p1);


	/// <summary>
	/// Sets the tracking value of a text node. This value is used to
	/// adjust the vertical spacing of characters in the text.
	/// 
	/// @CSharpLua.Template = "gui.set_tracking({0}, {1})"
	/// </summary>
	public static extern void set_tracking(Node node_p1, double tracking_p2);


	/// <summary>
	/// Returns the tracking value of a text node.
	/// 
	/// @CSharpLua.Template = "gui.get_tracking({0})"
	/// </summary>
	public static extern double get_tracking(Node node_p1);


	/// <summary>
	/// Tests whether a coordinate is within the bounding box of a
	/// node.
	/// 
	/// @CSharpLua.Template = "gui.pick_node({0}, {1}, {2})"
	/// </summary>
	public static extern bool pick_node(Node node_p1, double x_p2, double y_p3);


	/// <summary>
	/// Returns <code>true</code> if a node is enabled and <code>false</code> if it's not.
	/// Disabled nodes are not rendered and animations acting on them are not evaluated.
	/// 
	/// @CSharpLua.Template = "gui.is_enabled({0}, {1})"
	/// </summary>
	public static extern bool is_enabled(Node node_p1, bool recursive_p2);


	/// <summary>
	/// Sets a node to the disabled or enabled state.
	/// Disabled nodes are not rendered and animations acting on them are not evaluated.
	/// 
	/// @CSharpLua.Template = "gui.set_enabled({0}, {1})"
	/// </summary>
	public static extern void set_enabled(Node node_p1, bool enabled_p2);


	/// <summary>
	/// Returns <code>true</code> if a node is visible and <code>false</code> if it's not.
	/// Invisible nodes are not rendered.
	/// 
	/// @CSharpLua.Template = "gui.get_visible({0})"
	/// </summary>
	public static extern bool get_visible(Node node_p1);


	/// <summary>
	/// Set if a node should be visible or not. Only visible nodes are rendered.
	/// 
	/// @CSharpLua.Template = "gui.set_visible({0}, {1})"
	/// </summary>
	public static extern void set_visible(Node node_p1, bool visible_p2);


	/// <summary>
	/// Returns the adjust mode of a node.
	/// The adjust mode defines how the node will adjust itself to screen
	/// resolutions that differs from the one in the project settings.
	/// 
	/// @CSharpLua.Template = "gui.get_adjust_mode({0})"
	/// </summary>
	public static extern AdjustMode get_adjust_mode(Node node_p1);


	/// <summary>
	/// Sets the adjust mode on a node.
	/// The adjust mode defines how the node will adjust itself to screen
	/// resolutions that differs from the one in the project settings.
	/// 
	/// @CSharpLua.Template = "gui.set_adjust_mode({0}, {1})"
	/// </summary>
	public static extern void set_adjust_mode(Node node_p1, AdjustMode adjust_mode_p2);


	/// <summary>
	/// Returns the size of a node.
	/// The size mode defines how the node will adjust itself in size. Automatic
	/// size mode alters the node size based on the node's content. Automatic size
	/// mode works for Box nodes and Pie nodes which will both adjust their size
	/// to match the assigned image. Particle fx and Text nodes will ignore
	/// any size mode setting.
	/// 
	/// @CSharpLua.Template = "gui.get_size_mode({0})"
	/// </summary>
	public static extern SizeMode get_size_mode(Node node_p1);


	/// <summary>
	/// Sets the size mode of a node.
	/// The size mode defines how the node will adjust itself in size. Automatic
	/// size mode alters the node size based on the node's content. Automatic size
	/// mode works for Box nodes and Pie nodes which will both adjust their size
	/// to match the assigned image. Particle fx and Text nodes will ignore
	/// any size mode setting.
	/// 
	/// @CSharpLua.Template = "gui.set_size_mode({0}, {1})"
	/// </summary>
	public static extern void set_size_mode(Node node_p1, SizeMode size_mode_p2);


	/// <summary>
	/// Alters the ordering of the two supplied nodes by moving the first node
	/// above the second.
	/// If the second argument is <code>nil</code> the first node is moved to the top.
	/// 
	/// @CSharpLua.Template = "gui.move_above({0}, {1})"
	/// </summary>
	public static extern void move_above(Node node_p1, Node node_p2);


	/// <summary>
	/// Alters the ordering of the two supplied nodes by moving the first node
	/// above the second.
	/// If the second argument is <code>nil</code> the first node is moved to the top.
	/// 
	/// @CSharpLua.Template = "gui.move_above({0})"
	/// </summary>
	public static extern void move_above(Node node_p1);


	/// <summary>
	/// Alters the ordering of the two supplied nodes by moving the first node
	/// below the second.
	/// If the second argument is <code>nil</code> the first node is moved to the bottom.
	/// 
	/// @CSharpLua.Template = "gui.move_below({0}, {1})"
	/// </summary>
	public static extern void move_below(Node node_p1, Node node_p2);


	/// <summary>
	/// Alters the ordering of the two supplied nodes by moving the first node
	/// below the second.
	/// If the second argument is <code>nil</code> the first node is moved to the bottom.
	/// 
	/// @CSharpLua.Template = "gui.move_below({0})"
	/// </summary>
	public static extern void move_below(Node node_p1);


	/// <summary>
	/// Returns the parent node of the specified node.
	/// If the supplied node does not have a parent, <code>nil</code> is returned.
	/// 
	/// @CSharpLua.Template = "gui.get_parent({0})"
	/// </summary>
	public static extern Node get_parent(Node node_p1);


	/// <summary>
	/// Sets the parent node of the specified node.
	/// 
	/// @CSharpLua.Template = "gui.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Node node_p1, Node parent_p2, bool keep_scene_transform_p3);


	/// <summary>
	/// Make a clone instance of a node.
	/// This function does not clone the supplied node's children nodes.
	/// Use gui.clone_tree for that purpose.
	/// 
	/// @CSharpLua.Template = "gui.clone({0})"
	/// </summary>
	public static extern Node clone(Node node_p1);


	/// <summary>
	/// Make a clone instance of a node and all its children.
	/// Use gui.clone to clone a node excluding its children.
	/// 
	/// @CSharpLua.Template = "gui.clone_tree({0})"
	/// </summary>
	public static extern LuaTable clone_tree(Node node_p1);


	/// <summary>
	/// Resets all nodes in the current GUI scene to their initial state.
	/// The reset only applies to static node loaded from the scene.
	/// Nodes that are created dynamically from script are not affected.
	/// 
	/// @CSharpLua.Template = "gui.reset_nodes()"
	/// </summary>
	public static extern void reset_nodes();


	/// <summary>
	/// Set the order number for the current GUI scene.
	/// The number dictates the sorting of the "gui" render predicate,
	/// in other words in which order the scene will be rendered in relation
	/// to other currently rendered GUI scenes.
	/// The number must be in the range 0 to 15.
	/// 
	/// @CSharpLua.Template = "gui.set_render_order({0})"
	/// </summary>
	public static extern void set_render_order(double order_p1);


	/// <summary>
	/// Shows the on-display touch keyboard.
	/// The specified type of keyboard is displayed if it is available on
	/// the device.
	/// This function is only available on iOS and Android. <span class="icon-ios"></span> <span class="icon-android"></span>.
	/// 
	/// @CSharpLua.Template = "gui.show_keyboard({0}, {1})"
	/// </summary>
	public static extern void show_keyboard(KeyboardType type_p1, bool autoclose_p2);


	/// <summary>
	/// Hides the on-display touch keyboard on the device.
	/// 
	/// @CSharpLua.Template = "gui.hide_keyboard()"
	/// </summary>
	public static extern void hide_keyboard();


	/// <summary>
	/// Resets the input context of keyboard. This will clear marked text.
	/// 
	/// @CSharpLua.Template = "gui.reset_keyboard()"
	/// </summary>
	public static extern void reset_keyboard();


	/// <summary>
	/// Returns the position of the supplied node.
	/// 
	/// @CSharpLua.Template = "gui.get_position({0})"
	/// </summary>
	public static extern Vector3 get_position(Node node_p1);


	/// <summary>
	/// Sets the position of the supplied node.
	/// 
	/// @CSharpLua.Template = "gui.set_position({0}, {1})"
	/// </summary>
	public static extern void set_position(Node node_p1, Vector3 position_p2);


	/// <summary>
	/// Sets the position of the supplied node.
	/// 
	/// @CSharpLua.Template = "gui.set_position({0}, {1})"
	/// </summary>
	public static extern void set_position(Node node_p1, Vector4 position_p2);


	/// <summary>
	/// Returns the rotation of the supplied node.
	/// The rotation is expressed in degree Euler angles.
	/// 
	/// @CSharpLua.Template = "gui.get_rotation({0})"
	/// </summary>
	public static extern Vector3 get_rotation(Node node_p1);


	/// <summary>
	/// Sets the rotation of the supplied node.
	/// The rotation is expressed in degree Euler angles.
	/// 
	/// @CSharpLua.Template = "gui.set_rotation({0}, {1})"
	/// </summary>
	public static extern void set_rotation(Node node_p1, Vector3 rotation_p2);


	/// <summary>
	/// Sets the rotation of the supplied node.
	/// The rotation is expressed in degree Euler angles.
	/// 
	/// @CSharpLua.Template = "gui.set_rotation({0}, {1})"
	/// </summary>
	public static extern void set_rotation(Node node_p1, Vector4 rotation_p2);


	/// <summary>
	/// Returns the scale of the supplied node.
	/// 
	/// @CSharpLua.Template = "gui.get_scale({0})"
	/// </summary>
	public static extern Vector3 get_scale(Node node_p1);


	/// <summary>
	/// Sets the scaling of the supplied node.
	/// 
	/// @CSharpLua.Template = "gui.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(Node node_p1, Vector3 scale_p2);


	/// <summary>
	/// Sets the scaling of the supplied node.
	/// 
	/// @CSharpLua.Template = "gui.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(Node node_p1, Vector4 scale_p2);


	/// <summary>
	/// Returns the color of the supplied node. The components
	/// of the returned vector4 contains the color channel values:
	/// <table>
	/// <thead>
	/// <tr>
	/// <th>Component</th>
	/// <th>Color value</th>
	/// </tr>
	/// </thead>
	/// <tbody>
	/// <tr>
	/// <td>x</td>
	/// <td>Red value</td>
	/// </tr>
	/// <tr>
	/// <td>y</td>
	/// <td>Green value</td>
	/// </tr>
	/// <tr>
	/// <td>z</td>
	/// <td>Blue value</td>
	/// </tr>
	/// <tr>
	/// <td>w</td>
	/// <td>Alpha value</td>
	/// </tr>
	/// </tbody>
	/// </table>
	/// 
	/// @CSharpLua.Template = "gui.get_color({0})"
	/// </summary>
	public static extern Vector4 get_color(Node node_p1);


	/// <summary>
	/// Sets the color of the supplied node. The components
	/// of the supplied vector3 or vector4 should contain the color channel values:
	/// <table>
	/// <thead>
	/// <tr>
	/// <th>Component</th>
	/// <th>Color value</th>
	/// </tr>
	/// </thead>
	/// <tbody>
	/// <tr>
	/// <td>x</td>
	/// <td>Red value</td>
	/// </tr>
	/// <tr>
	/// <td>y</td>
	/// <td>Green value</td>
	/// </tr>
	/// <tr>
	/// <td>z</td>
	/// <td>Blue value</td>
	/// </tr>
	/// <tr>
	/// <td>w <span class="type">vector4</span></td>
	/// <td>Alpha value</td>
	/// </tr>
	/// </tbody>
	/// </table>
	/// 
	/// @CSharpLua.Template = "gui.set_color({0}, {1})"
	/// </summary>
	public static extern void set_color(Node node_p1, Vector3 color_p2);


	/// <summary>
	/// Sets the color of the supplied node. The components
	/// of the supplied vector3 or vector4 should contain the color channel values:
	/// <table>
	/// <thead>
	/// <tr>
	/// <th>Component</th>
	/// <th>Color value</th>
	/// </tr>
	/// </thead>
	/// <tbody>
	/// <tr>
	/// <td>x</td>
	/// <td>Red value</td>
	/// </tr>
	/// <tr>
	/// <td>y</td>
	/// <td>Green value</td>
	/// </tr>
	/// <tr>
	/// <td>z</td>
	/// <td>Blue value</td>
	/// </tr>
	/// <tr>
	/// <td>w <span class="type">vector4</span></td>
	/// <td>Alpha value</td>
	/// </tr>
	/// </tbody>
	/// </table>
	/// 
	/// @CSharpLua.Template = "gui.set_color({0}, {1})"
	/// </summary>
	public static extern void set_color(Node node_p1, Vector4 color_p2);


	/// <summary>
	/// Returns the outline color of the supplied node.
	/// See <a href="/ref/gui#gui.get_color">gui.get_color</a> for info how vectors encode color values.
	/// 
	/// @CSharpLua.Template = "gui.get_outline({0})"
	/// </summary>
	public static extern Vector4 get_outline(Node node_p1);


	/// <summary>
	/// Sets the outline color of the supplied node.
	/// See <a href="/ref/gui#gui.set_color">gui.set_color</a> for info how vectors encode color values.
	/// 
	/// @CSharpLua.Template = "gui.set_outline({0}, {1})"
	/// </summary>
	public static extern void set_outline(Node node_p1, Vector3 color_p2);


	/// <summary>
	/// Sets the outline color of the supplied node.
	/// See <a href="/ref/gui#gui.set_color">gui.set_color</a> for info how vectors encode color values.
	/// 
	/// @CSharpLua.Template = "gui.set_outline({0}, {1})"
	/// </summary>
	public static extern void set_outline(Node node_p1, Vector4 color_p2);


	/// <summary>
	/// Returns the shadow color of the supplied node.
	/// See <a href="/ref/gui#gui.get_color">gui.get_color</a> for info how vectors encode color values.
	/// 
	/// @CSharpLua.Template = "gui.get_shadow({0})"
	/// </summary>
	public static extern Vector4 get_shadow(Node node_p1);


	/// <summary>
	/// Sets the shadow color of the supplied node.
	/// See <a href="/ref/gui#gui.set_color">gui.set_color</a> for info how vectors encode color values.
	/// 
	/// @CSharpLua.Template = "gui.set_shadow({0}, {1})"
	/// </summary>
	public static extern void set_shadow(Node node_p1, Vector3 color_p2);


	/// <summary>
	/// Sets the shadow color of the supplied node.
	/// See <a href="/ref/gui#gui.set_color">gui.set_color</a> for info how vectors encode color values.
	/// 
	/// @CSharpLua.Template = "gui.set_shadow({0}, {1})"
	/// </summary>
	public static extern void set_shadow(Node node_p1, Vector4 color_p2);


	/// <summary>
	/// Sets the size of the supplied node.
	/// <span class="icon-attention"></span> You can only set size on nodes with size mode set to SIZE_MODE_MANUAL
	/// 
	/// @CSharpLua.Template = "gui.set_size({0}, {1})"
	/// </summary>
	public static extern void set_size(Node node_p1, Vector3 size_p2);


	/// <summary>
	/// Sets the size of the supplied node.
	/// <span class="icon-attention"></span> You can only set size on nodes with size mode set to SIZE_MODE_MANUAL
	/// 
	/// @CSharpLua.Template = "gui.set_size({0}, {1})"
	/// </summary>
	public static extern void set_size(Node node_p1, Vector4 size_p2);


	/// <summary>
	/// Returns the size of the supplied node.
	/// 
	/// @CSharpLua.Template = "gui.get_size({0})"
	/// </summary>
	public static extern Vector3 get_size(Node node_p1);


	/// <summary>
	/// Returns the screen position of the supplied node. This function returns the
	/// calculated transformed position of the node, taking into account any parent node
	/// transforms.
	/// 
	/// @CSharpLua.Template = "gui.get_screen_position({0})"
	/// </summary>
	public static extern Vector3 get_screen_position(Node node_p1);


	/// <summary>
	/// Set the screen position to the supplied node
	/// 
	/// @CSharpLua.Template = "gui.set_screen_position({0}, {1})"
	/// </summary>
	public static extern void set_screen_position(Node node_p1, Vector3 screen_position_p2);


	/// <summary>
	/// Convert the screen position to the local position of supplied node
	/// 
	/// @CSharpLua.Template = "gui.screen_to_local({0}, {1})"
	/// </summary>
	public static extern Vector3 screen_to_local(Node node_p1, Vector3 screen_position_p2);


	/// <summary>
	/// This is only useful nodes with flipbook animations. The cursor is normalized.
	/// 
	/// @CSharpLua.Template = "gui.set_flipbook_cursor({0}, {1})"
	/// </summary>
	public static extern void set_flipbook_cursor(Node node_p1, double cursor_p2);


	/// <summary>
	/// This is only useful nodes with flipbook animations. Gets the playback rate of the flipbook animation on a node.
	/// 
	/// @CSharpLua.Template = "gui.get_flipbook_playback_rate({0})"
	/// </summary>
	public static extern double get_flipbook_playback_rate(Node node_p1);


	/// <summary>
	/// This is only useful nodes with flipbook animations. Sets the playback rate of the flipbook animation on a node. Must be positive.
	/// 
	/// @CSharpLua.Template = "gui.set_flipbook_playback_rate({0}, {1})"
	/// </summary>
	public static extern void set_flipbook_playback_rate(Node node_p1, double playback_rate_p2);


	/// <summary>
	/// Dynamically create a particle fx node.
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector3 pos_p1, Hash particlefx_p2);


	/// <summary>
	/// Dynamically create a particle fx node.
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector3 pos_p1, string particlefx_p2);


	/// <summary>
	/// Dynamically create a particle fx node.
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector4 pos_p1, Hash particlefx_p2);


	/// <summary>
	/// Dynamically create a particle fx node.
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector4 pos_p1, string particlefx_p2);


	/// <summary>
	/// Plays the paricle fx for a gui node
	/// 
	/// @CSharpLua.Template = "gui.play_particlefx({0})"
	/// </summary>
	public static extern void play_particlefx(Node node_p1);


	/// <summary>
	/// Plays the paricle fx for a gui node
	/// 
	/// @CSharpLua.Template = "gui.play_particlefx({0}, {1})"
	/// </summary>
	public static extern void play_particlefx(Node node_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);


	/// <summary>
	/// Stops the particle fx for a gui node
	/// 
	/// @CSharpLua.Template = "gui.stop_particlefx({0}, {1})"
	/// </summary>
	public static extern void stop_particlefx(Node node_p1, LuaTable options_p2);


	/// <summary>
	/// Set the paricle fx for a gui node
	/// 
	/// @CSharpLua.Template = "gui.set_particlefx({0}, {1})"
	/// </summary>
	public static extern void set_particlefx(Node node_p1, Hash particlefx_p2);


	/// <summary>
	/// Set the paricle fx for a gui node
	/// 
	/// @CSharpLua.Template = "gui.set_particlefx({0}, {1})"
	/// </summary>
	public static extern void set_particlefx(Node node_p1, string particlefx_p2);


	/// <summary>
	/// Get the paricle fx for a gui node
	/// 
	/// @CSharpLua.Template = "gui.get_particlefx({0})"
	/// </summary>
	public static extern Hash get_particlefx(Node node_p1);


	/// <summary>
	/// gets the node inherit alpha state
	/// 
	/// @CSharpLua.Template = "gui.get_inherit_alpha({0})"
	/// </summary>
	public static extern void get_inherit_alpha(Node node_p1);


	/// <summary>
	/// sets the node inherit alpha state
	/// 
	/// @CSharpLua.Template = "gui.set_inherit_alpha({0}, {1})"
	/// </summary>
	public static extern void set_inherit_alpha(Node node_p1, bool inherit_alpha_p2);


	/// <summary>
	/// gets the node alpha
	/// 
	/// @CSharpLua.Template = "gui.get_alpha({0})"
	/// </summary>
	public static extern void get_alpha(Node node_p1);


	/// <summary>
	/// sets the node alpha
	/// 
	/// @CSharpLua.Template = "gui.set_alpha({0}, {1})"
	/// </summary>
	public static extern void set_alpha(Node node_p1, double alpha_p2);


	/// <summary>
	/// This is a callback-function, which is called by the engine when a gui component is initialized. It can be used
	/// to set the initial state of the script and gui scene.
	/// 
	/// @CSharpLua.Template = "gui.init({0})"
	/// </summary>
	public static extern void init(object self_p1);


	/// <summary>
	/// This is a callback-function, which is called by the engine when a gui component is finalized (destroyed). It can
	/// be used to e.g. take some last action, report the finalization to other game object instances
	/// or release user input focus (see <code>release_input_focus</code>). There is no use in starting any animations or similar
	/// from this function since the gui component is about to be destroyed.
	/// 
	/// @CSharpLua.Template = "gui.final({0})"
	/// </summary>
	public static extern void final(object self_p1);


	/// <summary>
	/// This is a callback-function, which is called by the engine every frame to update the state of a gui component.
	/// It can be used to perform any kind of gui related tasks, e.g. animating nodes.
	/// 
	/// @CSharpLua.Template = "gui.update({0}, {1})"
	/// </summary>
	public static extern void update(object self_p1, double dt_p2);


	/// <summary>
	/// This is a callback-function, which is called by the engine whenever a message has been sent to the gui component.
	/// It can be used to take action on the message, e.g. update the gui or send a response back to the sender of the message.
	/// The <code>message</code> parameter is a table containing the message data. If the message is sent from the engine, the
	/// documentation of the message specifies which data is supplied.
	/// See the <a href="#update">update</a> function for examples on how to use this callback-function.
	/// 
	/// @CSharpLua.Template = "gui.on_message({0}, {1}, {2})"
	/// </summary>
	public static extern void on_message(object self_p1, Hash message_id_p2, LuaTable message_p3);


	/// <summary>
	/// This is a callback-function, which is called by the engine when user input is sent to the instance of the gui component.
	/// It can be used to take action on the input, e.g. modify the gui according to the input.
	/// For an instance to obtain user input, it must first acquire input
	/// focus through the message <code>acquire_input_focus</code>.
	/// Any instance that has obtained input will be put on top of an
	/// input stack. Input is sent to all listeners on the stack until the
	/// end of stack is reached, or a listener returns <code>true</code>
	/// to signal that it wants input to be consumed.
	/// See the documentation of <a href="/ref/go/#acquire_input_focus">acquire_input_focus</a> for more
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
	/// @CSharpLua.Template = "gui.on_input({0}, {1}, {2})"
	/// </summary>
	public static extern bool on_input(object self_p1, Hash action_id_p2, LuaTable action_p3);


	/// <summary>
	/// This is a callback-function, which is called by the engine when the gui script is reloaded, e.g. from the editor.
	/// It can be used for live development, e.g. to tweak constants or set up the state properly for the script.
	/// 
	/// @CSharpLua.Template = "gui.on_reload({0})"
	/// </summary>
	public static extern void on_reload(object self_p1);


	#endregion Defold API


	/// <summary>
	/// @CSharpLua.Template = "gui.get_node({0})"
	/// </summary>
	public static extern Node GetNode(Hash id);


	public static TNode GetNode<TNode>(Hash id) where TNode : NodeProxy, new()
	{
		var node = new TNode();
		node.__assignproxy__(Gui.get_node(id));
		return node;
	}
}