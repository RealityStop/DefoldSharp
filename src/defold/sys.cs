using System;
using support;
using lua;
using types;

/// <summary>
/// System API documentation
/// 
/// </summary>
public static class Sys
{
	#region Defold API
	#region Messages
	/// <summary>
	/// </summary>
	public class exit_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("exit");
		public override Hash FetchCode() => __CODE__;

		public double code;
	}


	/// <summary>
	/// </summary>
	public class toggle_profile_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("toggle_profile");
		public override Hash FetchCode() => __CODE__;

	}


	/// <summary>
	/// </summary>
	public class toggle_physics_debug_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("toggle_physics_debug");
		public override Hash FetchCode() => __CODE__;

	}


	/// <summary>
	/// </summary>
	public class start_record_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("start_record");
		public override Hash FetchCode() => __CODE__;

		public string file_name;
		public double frame_period;
		public double fps;
	}


	/// <summary>
	/// </summary>
	public class stop_record_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("stop_record");
		public override Hash FetchCode() => __CODE__;

	}


	/// <summary>
	/// </summary>
	public class reboot_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("reboot");
		public override Hash FetchCode() => __CODE__;

		public string arg1;
		public string arg2;
		public string arg3;
		public string arg4;
		public string arg5;
		public string arg6;
	}


	/// <summary>
	/// </summary>
	public class set_vsync_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("set_vsync");
		public override Hash FetchCode() => __CODE__;

	}


	/// <summary>
	/// </summary>
	public class set_update_frequency_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("set_update_frequency");
		public override Hash FetchCode() => __CODE__;

	}


	#endregion Messages


	/// <summary>
	/// The table can later be loaded by <code>sys.load</code>.
	/// Use <code>sys.get_save_file</code> to obtain a valid location for the file.
	/// Internally, this function uses a workspace buffer sized output file sized 512kb.
	/// This size reflects the output file size which must not exceed this limit.
	/// Additionally, the total number of rows that any one table may contain is limited to 65536
	/// (i.e. a 16 bit range). When tables are used to represent arrays, the values of
	/// keys are permitted to fall within a 32 bit range, supporting sparse arrays, however
	/// the limit on the total number of rows remains in effect.
	/// 
	/// @CSharpLua.Template = "sys.save({0}, {1})"
	/// </summary>
	public static extern bool save(string filename_p1, LuaTableBase table_p2);


	/// <summary>
	/// If the file exists, it must have been created by <code>sys.save</code> to be loaded.
	/// 
	/// @CSharpLua.Template = "sys.load({0})"
	/// </summary>
	public static extern LuaTable load(string filename_p1);


	/// <summary>
	/// The save-file path is operating system specific and is typically located under the user's home directory.
	/// 
	/// @CSharpLua.Template = "sys.get_save_file({0}, {1})"
	/// </summary>
	public static extern string get_save_file(string application_id_p1, string file_name_p2);


	/// <summary>
	/// The path from which the application is run.
	/// 
	/// @CSharpLua.Template = "sys.get_application_path()"
	/// </summary>
	public static extern string get_application_path();


	/// <summary>
	/// Get config value from the game.project configuration file.
	/// In addition to the project file, configuration values can also be passed
	/// to the runtime as command line arguments with the <code>--config</code> argument.
	/// 
	/// @CSharpLua.Template = "sys.get_config({0})"
	/// </summary>
	public static extern string get_config(string key_p1);


	/// <summary>
	/// Get config value from the game.project configuration file with default value
	/// 
	/// @CSharpLua.Template = "sys.get_config({0}, {1})"
	/// </summary>
	public static extern string get_config(string key_p1, string default_value_p2);


	/// <summary>
	/// Open URL in default application, typically a browser
	/// 
	/// @CSharpLua.Template = "sys.open_url({0})"
	/// </summary>
	public static extern bool open_url(string url_p1);


	/// <summary>
	/// Open URL in default application, typically a browser
	/// 
	/// @CSharpLua.Template = "sys.open_url({0}, {1})"
	/// </summary>
	public static extern bool open_url(string url_p1, LuaTableBase attributes_p2);


	/// <summary>
	/// Loads a custom resource. Specify the full filename of the resource that you want
	/// to load. When loaded, the file data is returned as a string.
	/// If loading fails, the function returns nil plus the error message.
	/// In order for the engine to include custom resources in the build process, you need
	/// to specify them in the "custom_resources" key in your "game.project" settings file.
	/// You can specify single resource files or directories. If a directory is included
	/// in the resource list, all files and directories in that directory is recursively
	/// included:
	/// For example "main/data/,assets/level_data.json".
	/// 
	/// @CSharpLua.Template = "sys.load_resource({0})"
	/// </summary>
	public static extern string load_resource(string filename_p1, out string error_o1);


	/// <summary>
	/// Returns a table with system information.
	/// 
	/// @CSharpLua.Template = "sys.get_sys_info()"
	/// </summary>
	public static extern LuaTable get_sys_info();


	/// <summary>
	/// Returns a table with system information.
	/// 
	/// @CSharpLua.Template = "sys.get_sys_info({0})"
	/// </summary>
	public static extern LuaTable get_sys_info(LuaTableBase options_p1);


	/// <summary>
	/// Returns a table with engine information.
	/// 
	/// @CSharpLua.Template = "sys.get_engine_info()"
	/// </summary>
	public static extern LuaTable get_engine_info();


	/// <summary>
	/// Returns a table with application information for the requested app.
	/// <span class="icon-ios"></span> On iOS, the <code>app_string</code> is an url scheme for the app that is queried. Your
	/// game needs to list the schemes that are queried in an <code>LSApplicationQueriesSchemes</code> array
	/// in a custom "Info.plist".
	/// <span class="icon-android"></span> On Android, the <code>app_string</code> is the package identifier for the app.
	/// 
	/// @CSharpLua.Template = "sys.get_application_info({0})"
	/// </summary>
	public static extern LuaTable get_application_info(string app_string_p1);


	/// <summary>
	/// Returns an array of tables with information on network interfaces.
	/// 
	/// @CSharpLua.Template = "sys.get_ifaddrs()"
	/// </summary>
	public static extern LuaTable get_ifaddrs();


	/// <summary>
	/// Set the Lua error handler function.
	/// The error handler is a function which is called whenever a lua runtime error occurs.
	/// 
	/// @CSharpLua.Template = "sys.set_error_handler({0})"
	/// </summary>
	public static extern void set_error_handler(Action<string,string,string> error_handler_p1);


	/// <summary>
	/// Sets the host that is used to check for network connectivity against.
	/// 
	/// @CSharpLua.Template = "sys.set_connectivity_host({0})"
	/// </summary>
	public static extern void set_connectivity_host(string host_p1);


	/// <summary>
	/// <span class="icon-ios"></span> <span class="icon-android"></span> Returns the current network connectivity status
	/// on mobile platforms.
	/// On desktop, this function always return <code>sys.NETWORK_CONNECTED</code>.
	/// 
	/// @CSharpLua.Template = "sys.get_connectivity()"
	/// </summary>
	public static extern SysConnectivity get_connectivity();


	/// <summary>
	/// Terminates the game application and reports the specified <code>code</code> to the OS.
	/// 
	/// @CSharpLua.Template = "sys.exit({0})"
	/// </summary>
	public static extern void exit(double code_p1);


	/// <summary>
	/// Reboots the game engine with a specified set of arguments.
	/// Arguments will be translated into command line arguments. Calling reboot
	/// function is equivalent to starting the engine with the same arguments.
	/// On startup the engine reads configuration from "game.project" in the
	/// project root.
	/// 
	/// @CSharpLua.Template = "sys.reboot({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void reboot(string arg1_p1, string arg2_p2, string arg3_p3, string arg4_p4, string arg5_p5, string arg6_p6);


	/// <summary>
	/// Set the vsync swap interval. The interval with which to swap the front and back buffers
	/// in sync with vertical blanks (v-blank), the hardware event where the screen image is updated
	/// with data from the front buffer. A value of 1 swaps the buffers at every v-blank, a value of
	/// 2 swaps the buffers every other v-blank and so on. A value of 0 disables waiting for v-blank
	/// before swapping the buffers. Default value is 1.
	/// When setting the swap interval to 0 and having <code>vsync</code> disabled in
	/// "game.project", the engine will try to respect the set frame cap value from
	/// "game.project" in software instead.
	/// This setting may be overridden by driver settings.
	/// 
	/// @CSharpLua.Template = "sys.set_vsync_swap_interval({0})"
	/// </summary>
	public static extern void set_vsync_swap_interval(double swap_interval_p1);


	/// <summary>
	/// Set game update-frequency (frame cap). This option is equivalent to <code>display.update_frequency</code> in
	/// the "game.project" settings but set in run-time. If <code>Vsync</code> checked in "game.project", the rate will
	/// be clamped to a swap interval that matches any detected main monitor refresh rate. If <code>Vsync</code> is
	/// unchecked the engine will try to respect the rate in software using timers. There is no
	/// guarantee that the frame cap will be achieved depending on platform specifics and hardware settings.
	/// 
	/// @CSharpLua.Template = "sys.set_update_frequency({0})"
	/// </summary>
	public static extern void set_update_frequency(double frequency_p1);


	/// <summary>
	/// The buffer can later deserialized by <code>sys.deserialize</code>.
	/// This method has all the same limitations as <code>sys.save</code>.
	/// 
	/// @CSharpLua.Template = "sys.serialize({0})"
	/// </summary>
	public static extern string serialize(LuaTableBase table_p1);


	/// <summary>
	/// deserializes buffer into a lua table
	/// 
	/// @CSharpLua.Template = "sys.deserialize({0})"
	/// </summary>
	public static extern LuaTable deserialize(string buffer_p1);


	#endregion Defold API
}
