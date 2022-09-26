using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Rendering API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class render
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.constant_buffer()"
		/// </summary>
		public static extern LuaTable constant_buffer();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.enable_state({0})"
		/// </summary>
		public static extern void enable_state(RenderState state_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.disable_state({0})"
		/// </summary>
		public static extern void disable_state(RenderState state_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_viewport({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set_viewport(double x_p1, double y_p2, double width_p3, double height_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.disable_texture({0})"
		/// </summary>
		public static extern void disable_texture(double unit_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.clear({0})"
		/// </summary>
		public static extern void clear(ILuaTable buffers_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.draw({0}, {1})"
		/// </summary>
		public static extern void draw(ILuaTable predicate_p1, ILuaTable options_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.draw_debug3d({0})"
		/// </summary>
		public static extern void draw_debug3d(ILuaTable options_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_view({0})"
		/// </summary>
		public static extern void set_view(Matrix4 matrix_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_projection({0})"
		/// </summary>
		public static extern void set_projection(Matrix4 matrix_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_blend_func({0}, {1})"
		/// </summary>
		public static extern void set_blend_func(BlendFunction source_factor_p1, BlendFunction destination_factor_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_color_mask({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern void set_color_mask(bool red_p1, bool green_p2, bool blue_p3, bool alpha_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_depth_mask({0})"
		/// </summary>
		public static extern void set_depth_mask(bool depth_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_stencil_mask({0})"
		/// </summary>
		public static extern void set_stencil_mask(double mask_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_depth_func({0})"
		/// </summary>
		public static extern void set_depth_func(DepthFunction func_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_stencil_func({0}, {1}, {2})"
		/// </summary>
		public static extern void set_stencil_func(DepthFunction func_p1, double ref_p2, double mask_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_stencil_op({0}, {1}, {2})"
		/// </summary>
		public static extern void set_stencil_op(StencilOperator sfail_p1, StencilOperator dpfail_p2, StencilOperator dppass_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_cull_face({0})"
		/// </summary>
		public static extern void set_cull_face(FaceType face_type_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.set_polygon_offset({0}, {1})"
		/// </summary>
		public static extern void set_polygon_offset(double factor_p1, double units_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.get_width()"
		/// </summary>
		public static extern double get_width();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.get_height()"
		/// </summary>
		public static extern double get_height();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.get_window_width()"
		/// </summary>
		public static extern double get_window_width();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.get_window_height()"
		/// </summary>
		public static extern double get_window_height();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.predicate({0})"
		/// </summary>
		public static extern ILuaTable predicate(ILuaTable tags_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.enable_material({0})"
		/// </summary>
		public static extern void enable_material(string material_id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.enable_material({0})"
		/// </summary>
		public static extern void enable_material(Hash material_id_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "render.disable_material()"
		/// </summary>
		public static extern void disable_material();
		
		
	}
}
