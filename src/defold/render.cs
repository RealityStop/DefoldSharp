using System;
using support;
using types;

/// <summary>
/// Rendering API documentation
/// 
/// </summary>
public static class Render
{
	#region Defold API
	/// <summary>
	/// </summary>
	public class draw_debug_text_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("draw_debug_text");
		public override Hash FetchCode() => __CODE__;
		
		public Vector3 position;
		public string text;
		public Vector4 color;
	}
	
	
	/// <summary>
	/// </summary>
	public class draw_line_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("draw_line");
		public override Hash FetchCode() => __CODE__;
		
		public Vector3 start_point;
		public Vector3 end_point;
		public Vector4 color;
	}
	
	
	/// <summary>
	/// </summary>
	public class window_resized_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("window_resized");
		public override Hash FetchCode() => __CODE__;
		
		public double height;
		public double width;
	}
	
	
	/// <summary>
	/// </summary>
	public class resize_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("resize");
		public override Hash FetchCode() => __CODE__;
		
		public double height;
		public double width;
	}
	
	
	/// <summary>
	/// </summary>
	public class clear_color_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("clear_color");
		public override Hash FetchCode() => __CODE__;
		
		public Vector4 color;
	}
	
	
	/// <summary>
	/// Constant buffers are used to set shader program variables and are optionally passed to the <code>render.draw()</code> function.
	/// The buffer's constant elements can be indexed like an ordinary Lua table, but you can't iterate over them with pairs() or ipairs().
	/// 
	/// @CSharpLua.Template = "render.constant_buffer()"
	/// </summary>
	public static extern LuaTable constant_buffer();
	
	
	/// <summary>
	/// Set the render viewport to the specified rectangle.
	/// 
	/// @CSharpLua.Template = "render.set_viewport({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_viewport(double x_p1, double y_p2, double width_p3, double height_p4);
	
	
	/// <summary>
	/// Disables a texture unit for a render target that has previourly been enabled.
	/// 
	/// @CSharpLua.Template = "render.disable_texture({0})"
	/// </summary>
	public static extern void disable_texture(double unit_p1);
	
	
	/// <summary>
	/// Clear buffers in the currently enabled render target with specified value. If the render target has been created with multiple
	/// color attachments, all buffers will be cleared with the same value.
	/// 
	/// @CSharpLua.Template = "render.clear({0})"
	/// </summary>
	public static extern void clear(ILuaTable buffers_p1);
	
	
	/// <summary>
	/// Draws all objects that match a specified predicate. An optional constant buffer can be
	/// provided to override the default constants. If no constants buffer is provided, a default
	/// system constants buffer is used containing constants as defined in materials and set through
	/// <a href="/ref/go#go.set">go.set</a> (or <a href="/ref/particlefx#particlefx.set_constant">particlefx.set_constant</a>) on visual components.
	/// 
	/// @CSharpLua.Template = "render.draw({0})"
	/// </summary>
	public static extern void draw(ILuaTable predicate_p1);
	
	
	/// <summary>
	/// Draws all objects that match a specified predicate. An optional constant buffer can be
	/// provided to override the default constants. If no constants buffer is provided, a default
	/// system constants buffer is used containing constants as defined in materials and set through
	/// <a href="/ref/go#go.set">go.set</a> (or <a href="/ref/particlefx#particlefx.set_constant">particlefx.set_constant</a>) on visual components.
	/// 
	/// @CSharpLua.Template = "render.draw({0}, {1})"
	/// </summary>
	public static extern void draw(ILuaTable predicate_p1, ILuaTable options_p2);
	
	
	/// <summary>
	/// Draws all 3d debug graphics such as lines drawn with "draw_line" messages and physics visualization.
	/// 
	/// @CSharpLua.Template = "render.draw_debug3d()"
	/// </summary>
	public static extern void draw_debug3d();
	
	
	/// <summary>
	/// Draws all 3d debug graphics such as lines drawn with "draw_line" messages and physics visualization.
	/// 
	/// @CSharpLua.Template = "render.draw_debug3d({0})"
	/// </summary>
	public static extern void draw_debug3d(ILuaTable options_p1);
	
	
	/// <summary>
	/// Sets the view matrix to use when rendering.
	/// 
	/// @CSharpLua.Template = "render.set_view({0})"
	/// </summary>
	public static extern void set_view(Matrix4 matrix_p1);
	
	
	/// <summary>
	/// Sets the projection matrix to use when rendering.
	/// 
	/// @CSharpLua.Template = "render.set_projection({0})"
	/// </summary>
	public static extern void set_projection(Matrix4 matrix_p1);
	
	
	/// <summary>
	/// Specifies whether the individual color components in the frame buffer is enabled for writing (<code>true</code>) or disabled (<code>false</code>). For example, if <code>blue</code> is <code>false</code>, nothing is written to the blue component of any pixel in any of the color buffers, regardless of the drawing operation attempted. Note that writing are either enabled or disabled for entire color components, not the individual bits of a component.
	/// The component masks are all initially <code>true</code>.
	/// 
	/// @CSharpLua.Template = "render.set_color_mask({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_color_mask(bool red_p1, bool green_p2, bool blue_p3, bool alpha_p4);
	
	
	/// <summary>
	/// Specifies whether the depth buffer is enabled for writing. The supplied mask governs
	/// if depth buffer writing is enabled (<code>true</code>) or disabled (<code>false</code>).
	/// The mask is initially <code>true</code>.
	/// 
	/// @CSharpLua.Template = "render.set_depth_mask({0})"
	/// </summary>
	public static extern void set_depth_mask(bool depth_p1);
	
	
	/// <summary>
	/// The stencil mask controls the writing of individual bits in the stencil buffer.
	/// The least significant <code>n</code> bits of the parameter <code>mask</code>, where <code>n</code> is the number of
	/// bits in the stencil buffer, specify the mask.
	/// Where a <code>1</code> bit appears in the mask, the corresponding
	/// bit in the stencil buffer can be written. Where a <code>0</code> bit appears in the mask,
	/// the corresponding bit in the stencil buffer is never written.
	/// The mask is initially all <code>1</code>'s.
	/// 
	/// @CSharpLua.Template = "render.set_stencil_mask({0})"
	/// </summary>
	public static extern void set_stencil_mask(double mask_p1);
	
	
	/// <summary>
	/// Sets the scale and units used to calculate depth values.
	/// If <code>render.STATE_POLYGON_OFFSET_FILL</code> is enabled, each fragment's depth value
	/// is offset from its interpolated value (depending on the depth value of the
	/// appropriate vertices). Polygon offset can be used when drawing decals, rendering
	/// hidden-line images etc.
	/// <code>factor</code> specifies a scale factor that is used to create a variable depth
	/// offset for each polygon. The initial value is <code>0</code>.
	/// <code>units</code> is multiplied by an implementation-specific value to create a
	/// constant depth offset. The initial value is <code>0</code>.
	/// The value of the offset is computed as <code>factor</code> &times; <code>DZ</code> + <code>r</code> &times; <code>units</code>
	/// <code>DZ</code> is a measurement of the depth slope of the polygon which is the change in z (depth)
	/// values divided by the change in either x or y coordinates, as you traverse a polygon.
	/// The depth values are in window coordinates, clamped to the range [0, 1].
	/// <code>r</code> is the smallest value that is guaranteed to produce a resolvable difference.
	/// It's value is an implementation-specific constant.
	/// The offset is added before the depth test is performed and before the
	/// value is written into the depth buffer.
	/// 
	/// @CSharpLua.Template = "render.set_polygon_offset({0}, {1})"
	/// </summary>
	public static extern void set_polygon_offset(double factor_p1, double units_p2);
	
	
	/// <summary>
	/// Returns the logical window width that is set in the "game.project" settings.
	/// Note that the actual window pixel size can change, either by device constraints
	/// or user input.
	/// 
	/// @CSharpLua.Template = "render.get_width()"
	/// </summary>
	public static extern double get_width();
	
	
	/// <summary>
	/// Returns the logical window height that is set in the "game.project" settings.
	/// Note that the actual window pixel size can change, either by device constraints
	/// or user input.
	/// 
	/// @CSharpLua.Template = "render.get_height()"
	/// </summary>
	public static extern double get_height();
	
	
	/// <summary>
	/// Returns the actual physical window width.
	/// Note that this value might differ from the logical width that is set in the
	/// "game.project" settings.
	/// 
	/// @CSharpLua.Template = "render.get_window_width()"
	/// </summary>
	public static extern double get_window_width();
	
	
	/// <summary>
	/// Returns the actual physical window height.
	/// Note that this value might differ from the logical height that is set in the
	/// "game.project" settings.
	/// 
	/// @CSharpLua.Template = "render.get_window_height()"
	/// </summary>
	public static extern double get_window_height();
	
	
	/// <summary>
	/// This function returns a new render predicate for objects with materials matching
	/// the provided material tags. The provided tags are combined into a bit mask
	/// for the predicate. If multiple tags are provided, the predicate matches materials
	/// with all tags ANDed together.
	/// The current limit to the number of tags that can be defined is <code>64</code>.
	/// 
	/// @CSharpLua.Template = "render.predicate({0})"
	/// </summary>
	public static extern ILuaTable predicate(ILuaTable tags_p1);
	
	
	/// <summary>
	/// If another material was already enabled, it will be automatically disabled
	/// and the specified material is used instead.
	/// The name of the material must be specified in the ".render" resource set
	/// in the "game.project" setting.
	/// 
	/// @CSharpLua.Template = "render.enable_material({0})"
	/// </summary>
	public static extern void enable_material(string material_id_p1);
	
	
	/// <summary>
	/// If another material was already enabled, it will be automatically disabled
	/// and the specified material is used instead.
	/// The name of the material must be specified in the ".render" resource set
	/// in the "game.project" setting.
	/// 
	/// @CSharpLua.Template = "render.enable_material({0})"
	/// </summary>
	public static extern void enable_material(Hash material_id_p1);
	
	
	/// <summary>
	/// If a material is currently enabled, disable it.
	/// The name of the material must be specified in the ".render" resource set
	/// in the "game.project" setting.
	/// 
	/// @CSharpLua.Template = "render.disable_material()"
	/// </summary>
	public static extern void disable_material();
	
	
	#endregion Defold API
}
