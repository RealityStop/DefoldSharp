using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Crash API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class crash
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.write_dump()"
		/// </summary>
		public static extern void write_dump();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.set_file_path({0})"
		/// </summary>
		public static extern void set_file_path(string path_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.load_previous()"
		/// </summary>
		public static extern double load_previous();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.release({0})"
		/// </summary>
		public static extern void release(double handle_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.set_user_field({0}, {1})"
		/// </summary>
		public static extern void set_user_field(double index_p1, string value_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.get_modules({0})"
		/// </summary>
		public static extern ILuaTable get_modules(double handle_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.get_user_field({0}, {1})"
		/// </summary>
		public static extern string get_user_field(double handle_p1, double index_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.get_sys_field({0}, {1})"
		/// </summary>
		public static extern string get_sys_field(double handle_p1, double index_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.get_signum({0})"
		/// </summary>
		public static extern double get_signum(double handle_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.get_backtrace({0})"
		/// </summary>
		public static extern ILuaTable get_backtrace(double handle_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "crash.get_extra_data({0})"
		/// </summary>
		public static extern string get_extra_data(double handle_p1);
		
		
	}
}
