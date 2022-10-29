using System;
using support;
using types;

/// <summary>
/// Collection proxy API documentation
/// 
/// </summary>
public static class Collectionproxy
{
	#region Defold API
	#region Messages
	/// <summary>
	/// </summary>
	public class set_time_step_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("set_time_step");
		public override Hash FetchCode() => __CODE__;
		
		public double factor;
		public double mode;
	}
	
	
	/// <summary>
	/// </summary>
	public class load_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("load");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class async_load_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("async_load");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class proxy_loaded_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("proxy_loaded");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class init_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("init");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class enable_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("enable");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class disable_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("disable");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class final_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("final");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class unload_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("unload");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	/// <summary>
	/// </summary>
	public class proxy_unloaded_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("proxy_unloaded");
		public override Hash FetchCode() => __CODE__;
		
	}
	
	
	#endregion Messages
	
	
	#endregion Defold API
}
