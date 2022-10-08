using System;
using types;

/// <summary>
/// GUI API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class gui
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_node({0})"
	/// </summary>
	public static extern Node get_node(string id_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_node({0})"
	/// </summary>
	public static extern Node get_node(Hash id_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_id({0})"
	/// </summary>
	public static extern Hash get_id(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_id({0}, {1})"
	/// </summary>
	public static extern void set_id(Node node_p1, string id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_id({0}, {1})"
	/// </summary>
	public static extern void set_id(Node node_p1, Hash id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_index({0})"
	/// </summary>
	public static extern double get_index(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.delete_node({0})"
	/// </summary>
	public static extern void delete_node(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.cancel_animation({0}, {1})"
	/// </summary>
	public static extern void cancel_animation(Node node_p1, string property_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_box_node({0}, {1})"
	/// </summary>
	public static extern Node new_box_node(Vector3 pos_p1, Vector3 size_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_box_node({0}, {1})"
	/// </summary>
	public static extern Node new_box_node(Vector4 pos_p1, Vector3 size_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_text_node({0}, {1})"
	/// </summary>
	public static extern Node new_text_node(Vector3 pos_p1, string text_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_text_node({0}, {1})"
	/// </summary>
	public static extern Node new_text_node(Vector4 pos_p1, string text_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_pie_node({0}, {1})"
	/// </summary>
	public static extern Node new_pie_node(Vector3 pos_p1, Vector3 size_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_pie_node({0}, {1})"
	/// </summary>
	public static extern Node new_pie_node(Vector4 pos_p1, Vector3 size_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_text({0})"
	/// </summary>
	public static extern string get_text(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_text({0}, {1})"
	/// </summary>
	public static extern void set_text(Node node_p1, string text_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_line_break({0})"
	/// </summary>
	public static extern bool get_line_break(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_line_break({0}, {1})"
	/// </summary>
	public static extern void set_line_break(Node node_p1, bool line_break_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_blend_mode()"
	/// </summary>
	public static extern BlendMode get_blend_mode();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_blend_mode({0}, {1})"
	/// </summary>
	public static extern void set_blend_mode(Node node_p1, BlendMode blend_mode_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_texture({0})"
	/// </summary>
	public static extern Hash get_texture(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_texture({0}, {1})"
	/// </summary>
	public static extern void set_texture(Node node_p1, string texture_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_texture({0}, {1})"
	/// </summary>
	public static extern void set_texture(Node node_p1, Hash texture_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_flipbook({0})"
	/// </summary>
	public static extern Hash get_flipbook(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, string animation_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, string animation_p2, Action<object,Node> complete_function_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, string animation_p2, Action<object,Node> complete_function_p3, ILuaTable play_properties_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, Hash animation_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, Hash animation_p2, Action<object,Node> complete_function_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_flipbook({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void play_flipbook(Node node_p1, Hash animation_p2, Action<object,Node> complete_function_p3, ILuaTable play_properties_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.cancel_flipbook({0})"
	/// </summary>
	public static extern void cancel_flipbook(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_texture({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool new_texture(string texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6, out double code_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_texture({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool new_texture(Hash texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6, out double code_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.delete_texture({0})"
	/// </summary>
	public static extern void delete_texture(string texture_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.delete_texture({0})"
	/// </summary>
	public static extern void delete_texture(Hash texture_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_texture_data({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool set_texture_data(string texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_texture_data({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern bool set_texture_data(Hash texture_p1, double width_p2, double height_p3, GuiTextureType type_p4, string buffer_p5, bool flip_p6);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_font({0})"
	/// </summary>
	public static extern Hash get_font(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_font_resource({0})"
	/// </summary>
	public static extern Hash get_font_resource(Hash font_name_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_font_resource({0})"
	/// </summary>
	public static extern Hash get_font_resource(string font_name_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_font({0}, {1})"
	/// </summary>
	public static extern void set_font(Node node_p1, string font_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_font({0}, {1})"
	/// </summary>
	public static extern void set_font(Node node_p1, Hash font_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_layer({0})"
	/// </summary>
	public static extern Hash get_layer(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_layer({0}, {1})"
	/// </summary>
	public static extern void set_layer(Node node_p1, string layer_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_layer({0}, {1})"
	/// </summary>
	public static extern void set_layer(Node node_p1, Hash layer_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_layout()"
	/// </summary>
	public static extern Hash get_layout();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_clipping_mode()"
	/// </summary>
	public static extern ClippingMode get_clipping_mode();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_clipping_mode({0}, {1})"
	/// </summary>
	public static extern void set_clipping_mode(Node node_p1, ClippingMode clipping_mode_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_clipping_visible({0})"
	/// </summary>
	public static extern bool get_clipping_visible(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_clipping_visible({0}, {1})"
	/// </summary>
	public static extern void set_clipping_visible(Node node_p1, bool visible_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_clipping_inverted({0})"
	/// </summary>
	public static extern bool get_clipping_inverted(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_clipping_inverted({0}, {1})"
	/// </summary>
	public static extern void set_clipping_inverted(Node node_p1, bool inverted_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_xanchor()"
	/// </summary>
	public static extern GuiAnchor get_xanchor();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_xanchor({0}, {1})"
	/// </summary>
	public static extern void set_xanchor(Node node_p1, GuiAnchor anchor_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_yanchor()"
	/// </summary>
	public static extern GuiAnchor get_yanchor();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_yanchor({0}, {1})"
	/// </summary>
	public static extern void set_yanchor(Node node_p1, GuiAnchor anchor_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_pivot()"
	/// </summary>
	public static extern Node get_pivot(out GuiPivot pivot_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_pivot({0}, {1})"
	/// </summary>
	public static extern void set_pivot(Node node_p1, GuiPivot pivot_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_width()"
	/// </summary>
	public static extern double get_width();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_height()"
	/// </summary>
	public static extern double get_height();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_slice9({0}, {1})"
	/// </summary>
	public static extern void set_slice9(Node node_p1, Vector4 values_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_slice9({0})"
	/// </summary>
	public static extern Vector4 get_slice9(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_perimeter_vertices({0}, {1})"
	/// </summary>
	public static extern void set_perimeter_vertices(Node node_p1, double vertices_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_perimeter_vertices({0})"
	/// </summary>
	public static extern double get_perimeter_vertices(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_fill_angle({0}, {1})"
	/// </summary>
	public static extern void set_fill_angle(Node node_p1, double angle_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_fill_angle({0})"
	/// </summary>
	public static extern double get_fill_angle(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_inner_radius({0}, {1})"
	/// </summary>
	public static extern void set_inner_radius(Node node_p1, double radius_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_inner_radius({0})"
	/// </summary>
	public static extern double get_inner_radius(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_outer_bounds({0}, {1})"
	/// </summary>
	public static extern void set_outer_bounds(Node node_p1, PieBounds bounds_mode_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_outer_bounds({0})"
	/// </summary>
	public static extern PieBounds get_outer_bounds(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_leading({0}, {1})"
	/// </summary>
	public static extern void set_leading(Node node_p1, double leading_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_leading({0})"
	/// </summary>
	public static extern double get_leading(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_tracking({0}, {1})"
	/// </summary>
	public static extern void set_tracking(Node node_p1, double tracking_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_tracking({0})"
	/// </summary>
	public static extern double get_tracking(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.pick_node({0}, {1}, {2})"
	/// </summary>
	public static extern bool pick_node(Node node_p1, double x_p2, double y_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.is_enabled({0}, {1})"
	/// </summary>
	public static extern bool is_enabled(Node node_p1, bool recursive_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_enabled({0}, {1})"
	/// </summary>
	public static extern void set_enabled(Node node_p1, bool enabled_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_visible({0})"
	/// </summary>
	public static extern bool get_visible(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_visible({0}, {1})"
	/// </summary>
	public static extern void set_visible(Node node_p1, bool visible_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_adjust_mode({0})"
	/// </summary>
	public static extern AdjustMode get_adjust_mode(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_adjust_mode({0}, {1})"
	/// </summary>
	public static extern void set_adjust_mode(Node node_p1, AdjustMode adjust_mode_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_size_mode({0})"
	/// </summary>
	public static extern SizeMode get_size_mode(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_size_mode({0}, {1})"
	/// </summary>
	public static extern void set_size_mode(Node node_p1, SizeMode size_mode_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.move_above({0}, {1})"
	/// </summary>
	public static extern void move_above(Node node_p1, Node node_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.move_above({0})"
	/// </summary>
	public static extern void move_above(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.move_below({0}, {1})"
	/// </summary>
	public static extern void move_below(Node node_p1, Node node_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.move_below({0})"
	/// </summary>
	public static extern void move_below(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_parent({0})"
	/// </summary>
	public static extern Node get_parent(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_parent({0}, {1}, {2})"
	/// </summary>
	public static extern void set_parent(Node node_p1, Node parent_p2, bool keep_scene_transform_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.clone({0})"
	/// </summary>
	public static extern Node clone(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.clone_tree({0})"
	/// </summary>
	public static extern ILuaTable clone_tree(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.reset_nodes()"
	/// </summary>
	public static extern void reset_nodes();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_render_order({0})"
	/// </summary>
	public static extern void set_render_order(double order_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.show_keyboard({0}, {1})"
	/// </summary>
	public static extern void show_keyboard(KeyboardType type_p1, bool autoclose_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.hide_keyboard()"
	/// </summary>
	public static extern void hide_keyboard();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.reset_keyboard()"
	/// </summary>
	public static extern void reset_keyboard();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_position({0})"
	/// </summary>
	public static extern Vector3 get_position(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_position({0}, {1})"
	/// </summary>
	public static extern void set_position(Node node_p1, Vector3 position_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_position({0}, {1})"
	/// </summary>
	public static extern void set_position(Node node_p1, Vector4 position_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_rotation({0})"
	/// </summary>
	public static extern Vector3 get_rotation(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_rotation({0}, {1})"
	/// </summary>
	public static extern void set_rotation(Node node_p1, Vector3 rotation_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_rotation({0}, {1})"
	/// </summary>
	public static extern void set_rotation(Node node_p1, Vector4 rotation_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_scale({0})"
	/// </summary>
	public static extern Vector3 get_scale(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(Node node_p1, Vector3 scale_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_scale({0}, {1})"
	/// </summary>
	public static extern void set_scale(Node node_p1, Vector4 scale_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_color({0})"
	/// </summary>
	public static extern Vector4 get_color(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_color({0}, {1})"
	/// </summary>
	public static extern void set_color(Node node_p1, Vector3 color_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_color({0}, {1})"
	/// </summary>
	public static extern void set_color(Node node_p1, Vector4 color_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_outline({0})"
	/// </summary>
	public static extern Vector4 get_outline(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_outline({0}, {1})"
	/// </summary>
	public static extern void set_outline(Node node_p1, Vector3 color_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_outline({0}, {1})"
	/// </summary>
	public static extern void set_outline(Node node_p1, Vector4 color_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_shadow({0})"
	/// </summary>
	public static extern Vector4 get_shadow(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_shadow({0}, {1})"
	/// </summary>
	public static extern void set_shadow(Node node_p1, Vector3 color_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_shadow({0}, {1})"
	/// </summary>
	public static extern void set_shadow(Node node_p1, Vector4 color_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_size({0}, {1})"
	/// </summary>
	public static extern void set_size(Node node_p1, Vector3 size_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_size({0}, {1})"
	/// </summary>
	public static extern void set_size(Node node_p1, Vector4 size_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_size({0})"
	/// </summary>
	public static extern Vector3 get_size(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_screen_position({0})"
	/// </summary>
	public static extern Vector3 get_screen_position(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_screen_position({0}, {1})"
	/// </summary>
	public static extern void set_screen_position(Node node_p1, Vector3 screen_position_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.screen_to_local({0}, {1})"
	/// </summary>
	public static extern Vector3 screen_to_local(Node node_p1, Vector3 screen_position_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_flipbook_cursor({0}, {1})"
	/// </summary>
	public static extern void set_flipbook_cursor(Node node_p1, double cursor_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_flipbook_playback_rate({0})"
	/// </summary>
	public static extern double get_flipbook_playback_rate(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_flipbook_playback_rate({0}, {1})"
	/// </summary>
	public static extern void set_flipbook_playback_rate(Node node_p1, double playback_rate_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector3 pos_p1, Hash particlefx_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector3 pos_p1, string particlefx_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector4 pos_p1, Hash particlefx_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.new_particlefx_node({0}, {1})"
	/// </summary>
	public static extern Node new_particlefx_node(Vector4 pos_p1, string particlefx_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_particlefx({0})"
	/// </summary>
	public static extern void play_particlefx(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.play_particlefx({0}, {1})"
	/// </summary>
	public static extern void play_particlefx(Node node_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.stop_particlefx({0}, {1})"
	/// </summary>
	public static extern void stop_particlefx(Node node_p1, ILuaTable options_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_particlefx({0}, {1})"
	/// </summary>
	public static extern void set_particlefx(Node node_p1, Hash particlefx_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_particlefx({0}, {1})"
	/// </summary>
	public static extern void set_particlefx(Node node_p1, string particlefx_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_particlefx({0})"
	/// </summary>
	public static extern Hash get_particlefx(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_inherit_alpha({0})"
	/// </summary>
	public static extern void get_inherit_alpha(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_inherit_alpha({0}, {1})"
	/// </summary>
	public static extern void set_inherit_alpha(Node node_p1, bool inherit_alpha_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.get_alpha({0})"
	/// </summary>
	public static extern void get_alpha(Node node_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.set_alpha({0}, {1})"
	/// </summary>
	public static extern void set_alpha(Node node_p1, double alpha_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.init({0})"
	/// </summary>
	public static extern void init(object self_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.final({0})"
	/// </summary>
	public static extern void final(object self_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.update({0}, {1})"
	/// </summary>
	public static extern void update(object self_p1, double dt_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.on_message({0}, {1}, {2})"
	/// </summary>
	public static extern void on_message(object self_p1, Hash message_id_p2, ILuaTable message_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.on_input({0}, {1}, {2})"
	/// </summary>
	public static extern bool on_input(object self_p1, Hash action_id_p2, ILuaTable action_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "gui.on_reload({0})"
	/// </summary>
	public static extern void on_reload(object self_p1);
		
		
}