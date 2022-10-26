using System;
using support;
using types;

/// <summary>
/// Crash API documentation
/// 
/// </summary>
public static class Crash
{
	#region Defold API
	/// <summary>
	/// Performs the same steps as if a crash had just occured but
	/// allows the program to continue.
	/// The generated dump can be read by crash.load_previous
	/// 
	/// @CSharpLua.Template = "crash.write_dump()"
	/// </summary>
	public static extern void write_dump();
	
	
	/// <summary>
	/// Crashes occuring before the path is set will be stored to a default engine location.
	/// 
	/// @CSharpLua.Template = "crash.set_file_path({0})"
	/// </summary>
	public static extern void set_file_path(string path_p1);
	
	
	/// <summary>
	/// The crash dump will be removed from disk upon a successful
	/// load, so loading is one-shot.
	/// 
	/// @CSharpLua.Template = "crash.load_previous()"
	/// </summary>
	public static extern double load_previous();
	
	
	/// <summary>
	/// releases a previously loaded crash dump
	/// 
	/// @CSharpLua.Template = "crash.release({0})"
	/// </summary>
	public static extern void release(double handle_p1);
	
	
	/// <summary>
	/// Store a user value that will get written to a crash dump when
	/// a crash occurs. This can be user id:s, breadcrumb data etc.
	/// There are 32 slots indexed from 0. Each slot stores at most 255 characters.
	/// 
	/// @CSharpLua.Template = "crash.set_user_field({0}, {1})"
	/// </summary>
	public static extern void set_user_field(double index_p1, string value_p2);
	
	
	/// <summary>
	/// The function returns a table containing entries with sub-tables that
	/// have fields 'name' and 'address' set for all loaded modules.
	/// 
	/// @CSharpLua.Template = "crash.get_modules({0})"
	/// </summary>
	public static extern ILuaTable get_modules(double handle_p1);
	
	
	/// <summary>
	/// reads user field from a loaded crash dump
	/// 
	/// @CSharpLua.Template = "crash.get_user_field({0}, {1})"
	/// </summary>
	public static extern string get_user_field(double handle_p1, double index_p2);
	
	
	/// <summary>
	/// reads a system field from a loaded crash dump
	/// 
	/// @CSharpLua.Template = "crash.get_sys_field({0}, {1})"
	/// </summary>
	public static extern string get_sys_field(double handle_p1, double index_p2);
	
	
	/// <summary>
	/// read signal number from a crash report
	/// 
	/// @CSharpLua.Template = "crash.get_signum({0})"
	/// </summary>
	public static extern double get_signum(double handle_p1);
	
	
	/// <summary>
	/// A table is returned containing the addresses of the call stack.
	/// 
	/// @CSharpLua.Template = "crash.get_backtrace({0})"
	/// </summary>
	public static extern ILuaTable get_backtrace(double handle_p1);
	
	
	/// <summary>
	/// The format of read text blob is platform specific
	/// and not guaranteed
	/// but can be useful for manual inspection.
	/// 
	/// @CSharpLua.Template = "crash.get_extra_data({0})"
	/// </summary>
	public static extern string get_extra_data(double handle_p1);
	
	
	#endregion Defold API
}
