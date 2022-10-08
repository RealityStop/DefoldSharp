using System;
using types;

/// <summary>
/// System API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class sys
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.save({0}, {1})"
	/// </summary>
	public static extern bool save(string filename_p1, ILuaTable table_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.load({0})"
	/// </summary>
	public static extern ILuaTable load(string filename_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_save_file({0}, {1})"
	/// </summary>
	public static extern string get_save_file(string application_id_p1, string file_name_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_application_path()"
	/// </summary>
	public static extern string get_application_path();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_config({0})"
	/// </summary>
	public static extern string get_config(string key_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_config({0}, {1})"
	/// </summary>
	public static extern string get_config(string key_p1, string default_value_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.open_url({0})"
	/// </summary>
	public static extern bool open_url(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.open_url({0}, {1})"
	/// </summary>
	public static extern bool open_url(string url_p1, ILuaTable attributes_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.load_resource({0})"
	/// </summary>
	public static extern string load_resource(string filename_p1, out string error_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_sys_info({0})"
	/// </summary>
	public static extern ILuaTable get_sys_info(ILuaTable options_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_engine_info()"
	/// </summary>
	public static extern ILuaTable get_engine_info();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_application_info({0})"
	/// </summary>
	public static extern ILuaTable get_application_info(string app_string_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_ifaddrs()"
	/// </summary>
	public static extern ILuaTable get_ifaddrs();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.set_error_handler({0})"
	/// </summary>
	public static extern void set_error_handler(Action<string,string,string> error_handler_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.set_connectivity_host({0})"
	/// </summary>
	public static extern void set_connectivity_host(string host_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.get_connectivity()"
	/// </summary>
	public static extern SysConnectivity get_connectivity();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.exit({0})"
	/// </summary>
	public static extern void exit(double code_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.reboot({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void reboot(string arg1_p1, string arg2_p2, string arg3_p3, string arg4_p4, string arg5_p5, string arg6_p6);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.set_vsync_swap_interval({0})"
	/// </summary>
	public static extern void set_vsync_swap_interval(double swap_interval_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.set_update_frequency({0})"
	/// </summary>
	public static extern void set_update_frequency(double frequency_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.serialize({0})"
	/// </summary>
	public static extern string serialize(ILuaTable table_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sys.deserialize({0})"
	/// </summary>
	public static extern ILuaTable deserialize(string buffer_p1);
		
		
}