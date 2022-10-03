using System;
using types;

/// <summary>
/// Profiler API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class profiler
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.get_memory_usage()"
	/// </summary>
	public static extern double get_memory_usage();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.get_cpu_usage()"
	/// </summary>
	public static extern double get_cpu_usage();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.enable_ui({0})"
	/// </summary>
	public static extern void enable_ui(bool enabled_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.set_ui_mode({0})"
	/// </summary>
	public static extern void set_ui_mode(ProfilerMode mode_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.set_ui_view_mode({0})"
	/// </summary>
	public static extern void set_ui_view_mode(ProfilerViewMode mode_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.set_ui_vsync_wait_visible({0})"
	/// </summary>
	public static extern void set_ui_vsync_wait_visible(bool visible_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.recorded_frame_count()"
	/// </summary>
	public static extern double recorded_frame_count();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.view_recorded_frame({0})"
	/// </summary>
	public static extern void view_recorded_frame(ILuaTable frame_index_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.log_text({0})"
	/// </summary>
	public static extern void log_text(string text_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.scope_begin({0})"
	/// </summary>
	public static extern void scope_begin(string name_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "profiler.scope_end()"
	/// </summary>
	public static extern void scope_end();
		
		
}