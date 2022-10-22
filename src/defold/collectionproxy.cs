using System;
using types;

/// <summary>
/// Collection proxy API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class collectionproxy
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class set_time_step_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("set_time_step");
		public double factor;
		public double mode;
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class load_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("load");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class async_load_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("async_load");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class proxy_loaded_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("proxy_loaded");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class init_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("init");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class enable_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("enable");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class disable_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("disable");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class final_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("final");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class unload_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("unload");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class proxy_unloaded_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("proxy_unloaded");
	}
	
	
}
