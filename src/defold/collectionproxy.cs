using lua;
using support.ComponentReferences;
using types;

/// <summary>
/// Collection proxy API documentation
/// 
/// </summary>
public class CollectionProxy : BuiltInComponentBase
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


	/// <summary>
	/// return an indexed table of resources for a collection proxy. Each
	/// entry is a hexadecimal string that represents the data of the specific
	/// resource. This representation corresponds with the filename for each
	/// individual resource that is exported when you bundle an application with
	/// LiveUpdate functionality.
	/// 
	/// @CSharpLua.Template = "collectionproxy.get_resources({0})"
	/// </summary>
	public static extern LuaTable get_resources(Url collectionproxy_p1);


	/// <summary>
	/// return an array of missing resources for a collection proxy. Each
	/// entry is a hexadecimal string that represents the data of the specific
	/// resource. This representation corresponds with the filename for each
	/// individual resource that is exported when you bundle an application with
	/// LiveUpdate functionality. It should be considered good practise to always
	/// check whether or not there are any missing resources in a collection proxy
	/// before attempting to load the collection proxy.
	/// 
	/// @CSharpLua.Template = "collectionproxy.missing_resources({0})"
	/// </summary>
	public static extern LuaTable missing_resources(Url collectionproxy_p1);


	#endregion Defold API


	/// <summary>
	/// Posts a load message to the collection-proxy-component to start the loading of the referenced collection. When the loading has completed, the message proxy_loaded will be sent back to the script. A loaded collection must be initialized (message init) and enabled (message enable) in order to be simulated and drawn.
	/// </summary>
	public void Load()
	{
		var message = new load_message();
		Message.postMessage(this, message);
	}


	/// <summary>
	/// Posts a async_load message to a collection-proxy-component to start background loading of the referenced collection. When the loading has completed, the message proxy_loaded will be sent back to the script. A loaded collection must be initialized (message init) and enabled (message enable) in order to be simulated and drawn.
	/// </summary>
	public void LoadAsync()
	{
		var message = new async_load_message();
		Message.postMessage(this, message);
	}


	/// <summary>
	/// Post this message to a collection-proxy-component to initialize the game objects and components in the referenced collection. Sending enable to an uninitialized collection proxy automatically initializes it. The init message simply provides a higher level of control.
	/// </summary>
	public void Init()
	{
		var message = new init_message();
		Message.postMessage(this, message);
	}


	/// <summary>
	/// Post this message to a collection-proxy-component to enable the referenced collection, which in turn enables the contained game objects and components. If the referenced collection was not initialized prior to this call, it will automatically be initialized.
	/// </summary>
	public void Enable()
	{
		var message = new enable_message();
		Message.postMessage(this, message);
	}


	/// <summary>
	/// Post this message to a collection-proxy-component to disable the referenced collection, which in turn disables the contained game objects and components.
	/// </summary>
	public void Disable()
	{
		var message = new disable_message();
		Message.postMessage(this, message);
	}


	/// <summary>
	/// Post this message to a collection-proxy-component to finalize the referenced collection, which in turn finalizes the contained game objects and components.
	/// </summary>
	public void Final()
	{
		var message = new final_message();
		Message.postMessage(this, message);
	}


	/// <summary>
	/// Post this message to a collection-proxy-component to start the unloading of the referenced collection. When the unloading has completed, the message proxy_unloaded will be sent back to the script.
	/// </summary>
	public void Unload()
	{
		var message = new unload_message();
		Message.postMessage(this, message);
	}


	/// <summary>
	/// Post this message to a collection-proxy-component to modify the time-step used when updating the collection controlled by the proxy. The time-step is modified by a scaling factor and can be incremented either continuously or in discrete steps. The continuous mode can be used for slow-motion or fast-forward effects. The discrete mode is only useful when scaling the time-step to pass slower than real time (factor is below 1). The time-step will then be set to 0 for as many frames as the scaling demands and then take on the full real-time-step for one frame, to simulate pulses. E.g. if factor is set to 0.1 the time-step would be 0 for 9 frames, then be 1/60 for one frame, 0 for 9 frames, and so on. The result in practice is that the game looks like it's updated at a much lower frequency than 60 Hz, which can be useful for debugging when each frame needs to be inspected.
	/// </summary>
	/// <param name="factor"></param>
	/// <param name="mode"></param>
	public void SetTimeStep(double factor, TimeStepMode mode)
	{
		var message = new set_time_step_message() { factor = factor, mode = (dynamic)mode };
		Message.postMessage(this, message);
	}
}