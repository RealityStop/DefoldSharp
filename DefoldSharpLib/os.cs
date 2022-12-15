namespace DefoldSharp
{
	public static class OS
	{
		/// <summary>
		/// @CSharpLua.Template = "os.clock()"
		/// </summary>
		public static extern double clock();


		//TODO: Figure out how we need to format this one.  Might need a stand-in.
	
		/// <summary>
		/// @CSharpLua.Template = "os.date({0},{1})"
		/// </summary>
		public static extern string date();
	
	
		/// <summary>
		/// @CSharpLua.Template = "os.date({0})"
		/// </summary>
		public static extern string date(string format);


		/// <summary>
		/// @CSharpLua.Template = "os.difftime({0},{1})"
		/// </summary>
		public static extern double difftime(double t2, double t1);


		/// <summary>
		/// @CSharpLua.Template = "os.execute({0})"
		/// </summary>
		public static extern int execute(string command);


		/// <summary>
		/// @CSharpLua.Template = "(os.execute() ~= 0)"
		/// </summary>
		public static extern bool IsShellAvailable();


		/// <summary>
		/// Safely shuts the game down.  Use exit() if an immediate force exit is needed
		/// </summary>
		public static void Shutdown()
		{
			/*[[
		 msg.post("@system:", "exit", {code = 0})
		 ]]*/
		}


		/// <summary>
		/// @CSharpLua.Template = "os.exit()"
		/// </summary>
		public static extern void exit();


		/// <summary>
		/// @CSharpLua.Template = "os.exit({0})"
		/// </summary>
		public static extern void exit(int code);


		/// <summary>
		/// @CSharpLua.Template = "os.getenv({0})"
		/// </summary>
		public static extern string getenv(string varname);


		/// <summary>
		/// @CSharpLua.Template = "os.remove({0})"
		/// </summary>
		public static extern bool remove(string filename, out string error);


		/// <summary>
		/// @CSharpLua.Template = "os.rename({0},{1})"
		/// </summary>
		public static extern bool rename(string oldname, string newname, out string error);


		/// <summary>
		/// @CSharpLua.Template = "os.setlocale(nil)"
		/// </summary>
		public static extern string setlocale();


		/// <summary>
		/// @CSharpLua.Template = "os.setlocale(nil)"
		/// </summary>
		public static extern string getlocale();


		/// <summary>
		/// @CSharpLua.Template = "os.setlocale({0})"
		/// </summary>
		public static extern string setlocale(string locale);


		/// <summary>
		/// @CSharpLua.Template = "os.setlocale({0},{1})"
		/// </summary>
		public static extern string setlocale(string locale, string category);


		/// <summary>
		/// @CSharpLua.Template = "os.time()"
		/// </summary>
		public static extern double time();


		/// <summary>
		/// @CSharpLua.Template = "os.time({0})"
		/// </summary>
		public static extern double time(LuaTable table);


		/// <summary>
		/// @CSharpLua.Template = "os.time()"
		/// </summary>
		public static extern string tmpname();
	}
}