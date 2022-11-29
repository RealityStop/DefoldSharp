using System;
using support;
using lua;
using types;

/// <summary>
/// Rendering API documentation
/// 
/// </summary>
public static class Render
{
	#region Defold API
	#region Messages
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


	#endregion Messages


	/// <summary>
	/// Constant buffers are used to set shader program variables and are optionally passed to the <code>render.draw()</code> function.
	/// The buffer's constant elements can be indexed like an ordinary Lua table, but you can't iterate over them with pairs() or ipairs().
	/// 
	/// @CSharpLua.Template = "render.constant_buffer()"
	/// </summary>
	public static extern ConstantBuffer constant_buffer();


	/// <summary>
	/// Enables a particular render state. The state will be enabled until disabled.
	/// 
	/// @CSharpLua.Template = "render.enable_state({0})"
	/// </summary>
	public static extern void enable_state(RenderState state_p1);


	/// <summary>
	/// Disables a render state.
	/// 
	/// @CSharpLua.Template = "render.disable_state({0})"
	/// </summary>
	public static extern void disable_state(RenderState state_p1);


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
	public static extern void clear(LuaTableBase buffers_p1);


	/// <summary>
	/// Draws all objects that match a specified predicate. An optional constant buffer can be
	/// provided to override the default constants. If no constants buffer is provided, a default
	/// system constants buffer is used containing constants as defined in materials and set through
	/// <a href="/ref/go#go.set">go.set</a> (or <a href="/ref/particlefx#particlefx.set_constant">particlefx.set_constant</a>) on visual components.
	/// 
	/// @CSharpLua.Template = "render.draw({0})"
	/// </summary>
	public static extern void draw(LuaTableBase predicate_p1);


	/// <summary>
	/// Draws all objects that match a specified predicate. An optional constant buffer can be
	/// provided to override the default constants. If no constants buffer is provided, a default
	/// system constants buffer is used containing constants as defined in materials and set through
	/// <a href="/ref/go#go.set">go.set</a> (or <a href="/ref/particlefx#particlefx.set_constant">particlefx.set_constant</a>) on visual components.
	/// 
	/// @CSharpLua.Template = "render.draw({0}, {1})"
	/// </summary>
	public static extern void draw(LuaTableBase predicate_p1, LuaTableBase options_p2);


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
	public static extern void draw_debug3d(LuaTableBase options_p1);


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
	/// Specifies the arithmetic used when computing pixel values that are written to the frame
	/// buffer. In RGBA mode, pixels can be drawn using a function that blends the source RGBA
	/// pixel values with the destination pixel values already in the frame buffer.
	/// Blending is initially disabled.
	/// <code>source_factor</code> specifies which method is used to scale the source color components.
	/// <code>destination_factor</code> specifies which method is used to scale the destination color
	/// components.
	/// Source color components are referred to as (R<sub>s</sub>,G<sub>s</sub>,B<sub>s</sub>,A<sub>s</sub>).
	/// Destination color components are referred to as (R<sub>d</sub>,G<sub>d</sub>,B<sub>d</sub>,A<sub>d</sub>).
	/// The color specified by setting the blendcolor is referred to as (R<sub>c</sub>,G<sub>c</sub>,B<sub>c</sub>,A<sub>c</sub>).
	/// The source scale factor is referred to as (s<sub>R</sub>,s<sub>G</sub>,s<sub>B</sub>,s<sub>A</sub>).
	/// The destination scale factor is referred to as (d<sub>R</sub>,d<sub>G</sub>,d<sub>B</sub>,d<sub>A</sub>).
	/// The color values have integer values between 0 and (k<sub>R</sub>,k<sub>G</sub>,k<sub>B</sub>,k<sub>A</sub>), where k<sub>c</sub> = 2<sup>m<sub>c</sub></sup> - 1 and m<sub>c</sub> is the number of bitplanes for that color. I.e for 8 bit color depth, color values are between <code>0</code> and <code>255</code>.
	/// Available factor constants and corresponding scale factors:
	/// <table>
	/// <thead>
	/// <tr>
	/// <th>Factor constant</th>
	/// <th>Scale factor (f<sub>R</sub>,f<sub>G</sub>,f<sub>B</sub>,f<sub>A</sub>)</th>
	/// </tr>
	/// </thead>
	/// <tbody>
	/// <tr>
	/// <td><code>render.BLEND_ZERO</code></td>
	/// <td>(0,0,0,0)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_ONE</code></td>
	/// <td>(1,1,1,1)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_SRC_COLOR</code></td>
	/// <td>(R<sub>s</sub>/k<sub>R</sub>,G<sub>s</sub>/k<sub>G</sub>,B<sub>s</sub>/k<sub>B</sub>,A<sub>s</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_ONE_MINUS_SRC_COLOR</code></td>
	/// <td>(1,1,1,1) - (R<sub>s</sub>/k<sub>R</sub>,G<sub>s</sub>/k<sub>G</sub>,B<sub>s</sub>/k<sub>B</sub>,A<sub>s</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_DST_COLOR</code></td>
	/// <td>(R<sub>d</sub>/k<sub>R</sub>,G<sub>d</sub>/k<sub>G</sub>,B<sub>d</sub>/k<sub>B</sub>,A<sub>d</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_ONE_MINUS_DST_COLOR</code></td>
	/// <td>(1,1,1,1) - (R<sub>d</sub>/k<sub>R</sub>,G<sub>d</sub>/k<sub>G</sub>,B<sub>d</sub>/k<sub>B</sub>,A<sub>d</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_SRC_ALPHA</code></td>
	/// <td>(A<sub>s</sub>/k<sub>A</sub>,A<sub>s</sub>/k<sub>A</sub>,A<sub>s</sub>/k<sub>A</sub>,A<sub>s</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_ONE_MINUS_SRC_ALPHA</code></td>
	/// <td>(1,1,1,1) - (A<sub>s</sub>/k<sub>A</sub>,A<sub>s</sub>/k<sub>A</sub>,A<sub>s</sub>/k<sub>A</sub>,A<sub>s</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_DST_ALPHA</code></td>
	/// <td>(A<sub>d</sub>/k<sub>A</sub>,A<sub>d</sub>/k<sub>A</sub>,A<sub>d</sub>/k<sub>A</sub>,A<sub>d</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_ONE_MINUS_DST_ALPHA</code></td>
	/// <td>(1,1,1,1) - (A<sub>d</sub>/k<sub>A</sub>,A<sub>d</sub>/k<sub>A</sub>,A<sub>d</sub>/k<sub>A</sub>,A<sub>d</sub>/k<sub>A</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_CONSTANT_COLOR</code></td>
	/// <td>(R<sub>c</sub>,G<sub>c</sub>,B<sub>c</sub>,A<sub>c</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_ONE_MINUS_CONSTANT_COLOR</code></td>
	/// <td>(1,1,1,1) - (R<sub>c</sub>,G<sub>c</sub>,B<sub>c</sub>,A<sub>c</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_CONSTANT_ALPHA</code></td>
	/// <td>(A<sub>c</sub>,A<sub>c</sub>,A<sub>c</sub>,A<sub>c</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_ONE_MINUS_CONSTANT_ALPHA</code></td>
	/// <td>(1,1,1,1) - (A<sub>c</sub>,A<sub>c</sub>,A<sub>c</sub>,A<sub>c</sub>)</td>
	/// </tr>
	/// <tr>
	/// <td><code>render.BLEND_SRC_ALPHA_SATURATE</code></td>
	/// <td>(i,i,i,1) where i = min(A<sub>s</sub>, k<sub>A</sub> - A<sub>d</sub>) /k<sub>A</sub></td>
	/// </tr>
	/// </tbody>
	/// </table>
	/// The blended RGBA values of a pixel comes from the following equations:
	/// <ul>
	/// <li>R<sub>d</sub> = min(k<sub>R</sub>, R<sub>s</sub> * s<sub>R</sub> + R<sub>d</sub> * d<sub>R</sub>)</li>
	/// <li>G<sub>d</sub> = min(k<sub>G</sub>, G<sub>s</sub> * s<sub>G</sub> + G<sub>d</sub> * d<sub>G</sub>)</li>
	/// <li>B<sub>d</sub> = min(k<sub>B</sub>, B<sub>s</sub> * s<sub>B</sub> + B<sub>d</sub> * d<sub>B</sub>)</li>
	/// <li>A<sub>d</sub> = min(k<sub>A</sub>, A<sub>s</sub> * s<sub>A</sub> + A<sub>d</sub> * d<sub>A</sub>)</li>
	/// </ul>
	/// Blend function <code>(render.BLEND_SRC_ALPHA, render.BLEND_ONE_MINUS_SRC_ALPHA)</code> is useful for
	/// drawing with transparency when the drawn objects are sorted from farthest to nearest.
	/// It is also useful for drawing antialiased points and lines in arbitrary order.
	/// 
	/// @CSharpLua.Template = "render.set_blend_func({0}, {1})"
	/// </summary>
	public static extern void set_blend_func(BlendFunction source_factor_p1, BlendFunction destination_factor_p2);


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
	/// Specifies the function that should be used to compare each incoming pixel
	/// depth value with the value present in the depth buffer.
	/// The comparison is performed only if depth testing is enabled and specifies
	/// the conditions under which a pixel will be drawn.
	/// Function constants:
	/// <ul>
	/// <li><code>render.COMPARE_FUNC_NEVER</code> (never passes)</li>
	/// <li><code>render.COMPARE_FUNC_LESS</code> (passes if the incoming depth value is less than the stored value)</li>
	/// <li><code>render.COMPARE_FUNC_LEQUAL</code> (passes if the incoming depth value is less than or equal to the stored value)</li>
	/// <li><code>render.COMPARE_FUNC_GREATER</code> (passes if the incoming depth value is greater than the stored value)</li>
	/// <li><code>render.COMPARE_FUNC_GEQUAL</code> (passes if the incoming depth value is greater than or equal to the stored value)</li>
	/// <li><code>render.COMPARE_FUNC_EQUAL</code> (passes if the incoming depth value is equal to the stored value)</li>
	/// <li><code>render.COMPARE_FUNC_NOTEQUAL</code> (passes if the incoming depth value is not equal to the stored value)</li>
	/// <li><code>render.COMPARE_FUNC_ALWAYS</code> (always passes)</li>
	/// </ul>
	/// The depth function is initially set to <code>render.COMPARE_FUNC_LESS</code>.
	/// 
	/// @CSharpLua.Template = "render.set_depth_func({0})"
	/// </summary>
	public static extern void set_depth_func(DepthFunction func_p1);


	/// <summary>
	/// Stenciling is similar to depth-buffering as it enables and disables drawing on a
	/// per-pixel basis. First, GL drawing primitives are drawn into the stencil planes.
	/// Second, geometry and images are rendered but using the stencil planes to mask out
	/// where to draw.
	/// The stencil test discards a pixel based on the outcome of a comparison between the
	/// reference value <code>ref</code> and the corresponding value in the stencil buffer.
	/// <code>func</code> specifies the comparison function. See the table below for values.
	/// The initial value is <code>render.COMPARE_FUNC_ALWAYS</code>.
	/// <code>ref</code> specifies the reference value for the stencil test. The value is clamped to
	/// the range [0, 2<sup>n</sup>-1], where n is the number of bitplanes in the stencil buffer.
	/// The initial value is <code>0</code>.
	/// <code>mask</code> is ANDed with both the reference value and the stored stencil value when the test
	/// is done. The initial value is all <code>1</code>'s.
	/// Function constant:
	/// <ul>
	/// <li><code>render.COMPARE_FUNC_NEVER</code> (never passes)</li>
	/// <li><code>render.COMPARE_FUNC_LESS</code> (passes if (ref &amp; mask) &lt; (stencil &amp; mask))</li>
	/// <li><code>render.COMPARE_FUNC_LEQUAL</code> (passes if (ref &amp; mask) &lt;= (stencil &amp; mask))</li>
	/// <li><code>render.COMPARE_FUNC_GREATER</code> (passes if (ref &amp; mask) &gt; (stencil &amp; mask))</li>
	/// <li><code>render.COMPARE_FUNC_GEQUAL</code> (passes if (ref &amp; mask) &gt;= (stencil &amp; mask))</li>
	/// <li><code>render.COMPARE_FUNC_EQUAL</code> (passes if (ref &amp; mask) = (stencil &amp; mask))</li>
	/// <li><code>render.COMPARE_FUNC_NOTEQUAL</code> (passes if (ref &amp; mask) != (stencil &amp; mask))</li>
	/// <li><code>render.COMPARE_FUNC_ALWAYS</code> (always passes)</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "render.set_stencil_func({0}, {1}, {2})"
	/// </summary>
	public static extern void set_stencil_func(DepthFunction func_p1, double ref_p2, double mask_p3);


	/// <summary>
	/// The stencil test discards a pixel based on the outcome of a comparison between the
	/// reference value <code>ref</code> and the corresponding value in the stencil buffer.
	/// To control the test, call <a href="/ref/render#render.set_stencil_func">render.set_stencil_func</a>.
	/// This function takes three arguments that control what happens to the stored stencil
	/// value while stenciling is enabled. If the stencil test fails, no change is made to the
	/// pixel's color or depth buffers, and <code>sfail</code> specifies what happens to the stencil buffer
	/// contents.
	/// Operator constants:
	/// <ul>
	/// <li><code>render.STENCIL_OP_KEEP</code> (keeps the current value)</li>
	/// <li><code>render.STENCIL_OP_ZERO</code> (sets the stencil buffer value to 0)</li>
	/// <li><code>render.STENCIL_OP_REPLACE</code> (sets the stencil buffer value to <code>ref</code>, as specified by <a href="/ref/render#render.set_stencil_func">render.set_stencil_func</a>)</li>
	/// <li><code>render.STENCIL_OP_INCR</code> (increments the stencil buffer value and clamp to the maximum representable unsigned value)</li>
	/// <li><code>render.STENCIL_OP_INCR_WRAP</code> (increments the stencil buffer value and wrap to zero when incrementing the maximum representable unsigned value)</li>
	/// <li><code>render.STENCIL_OP_DECR</code> (decrements the current stencil buffer value and clamp to 0)</li>
	/// <li><code>render.STENCIL_OP_DECR_WRAP</code> (decrements the current stencil buffer value and wrap to the maximum representable unsigned value when decrementing zero)</li>
	/// <li><code>render.STENCIL_OP_INVERT</code> (bitwise inverts the current stencil buffer value)</li>
	/// </ul>
	/// <code>dppass</code> and <code>dpfail</code> specify the stencil buffer actions depending on whether subsequent
	/// depth buffer tests succeed (dppass) or fail (dpfail).
	/// The initial value for all operators is <code>render.STENCIL_OP_KEEP</code>.
	/// 
	/// @CSharpLua.Template = "render.set_stencil_op({0}, {1}, {2})"
	/// </summary>
	public static extern void set_stencil_op(StencilOperator sfail_p1, StencilOperator dpfail_p2, StencilOperator dppass_p3);


	/// <summary>
	/// Specifies whether front- or back-facing polygons can be culled
	/// when polygon culling is enabled. Polygon culling is initially disabled.
	/// If mode is <code>render.FACE_FRONT_AND_BACK</code>, no polygons are drawn, but other
	/// primitives such as points and lines are drawn. The initial value for
	/// <code>face_type</code> is <code>render.FACE_BACK</code>.
	/// 
	/// @CSharpLua.Template = "render.set_cull_face({0})"
	/// </summary>
	public static extern void set_cull_face(FaceType face_type_p1);


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
	public static extern LuaTable predicate(LuaTableBase tags_p1);


	/// <summary>
	/// This function returns a new render predicate for objects with materials matching
	/// the provided material tags. The provided tags are combined into a bit mask
	/// for the predicate. If multiple tags are provided, the predicate matches materials
	/// with all tags ANDed together.
	/// The current limit to the number of tags that can be defined is <code>64</code>.
	/// 
	/// @CSharpLua.Template = "render.predicate({0})"
	/// </summary>
	public static extern LuaTable predicate(LuaArrayOf<string> tags_p1);


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
