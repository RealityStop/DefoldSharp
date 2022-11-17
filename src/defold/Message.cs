using System;
using System.Collections.Generic;
using System.Dynamic;
using support;
using types;

public static class Message
{
	private static readonly Dictionary<Type, Hash> typeToHashLookup = new Dictionary<Type, Hash>();
	///// <summary>
	///// @CSharpLua.Template = "msg.post({0},{1})"
	///// </summary>
	//public static extern void post<T>(HashOrStringOrUrl receiver, Message message_id);

	///// <summary>
	///// @CSharpLua.Template = "msg.post({0},{1},{2})"
	///// </summary>
	//public static extern void post<T>(HashOrStringOrUrl receiver, Message<T> message_id, T message_data);


	///// <summary>
	///// @CSharpLua.Template = "msg.post({0},{1},{2})"
	///// </summary>
	//public static extern void post(HashOrStringOrUrl receiver, HashOrString message_id, object message_data);


	/// <summary>
	///     @CSharpLua.Template = msg.post({0},{1})
	/// </summary>
	public static extern void post(string id, string message);

	/// <summary>
	///     @CSharpLua.Template = msg.post({0},{1})
	/// </summary>
	public static extern void post(Url id, string message);
	/// <summary>
	///     @CSharpLua.Template = msg.post({0},{1})
	/// </summary>
	public static extern void post(Hash id, string message);


	/// <summary>
	///     @CSharpLua.Template = msg.post({0},{1},{2})
	/// </summary>
	public static extern void post(string id, string code, ILuaTable data);

	/// <summary>
	///     @CSharpLua.Template = msg.post({0},{1},{2})
	/// </summary>
	public static extern void post(Url id, string code, ILuaTable data);
	
	/// <summary>
	///     @CSharpLua.Template = msg.post({0},{1},{2})
	/// </summary>
	public static extern void post(Hash id, string code, ILuaTable data);


	public static void postMessage(string id, string code, ILuaTableSerializable data)
	{
		post(id, code, data.ToTable());
	}


	public static void postMessage(Url id, string code, ILuaTableSerializable data)
	{
		post(id, code, data.ToTable());
	}


	public static void postMessage(Hash id, string code, ILuaTableSerializable data)
	{
		post(id, code, data.ToTable());
	}


	public static void postMessage(string id, MessageImplementation message)
	{
		post(id, message.FetchCode(), message.ToTable());
	}


	public static void postMessage(Hash id, MessageImplementation message)
	{
		post(id, message.FetchCode(), message.ToTable());
	}


	public static void postMessage(Url id, MessageImplementation message)
	{
		post(id, message.FetchCode(), message.ToTable());
	}


	public static bool IsMessage<T>(Hash message_id, dynamic message, Hash expectedCode, out T messageImpl)
		where T : MessageImplementation
	{
		if (message_id == expectedCode)
		{
			messageImpl = message;
			return true;
		}


		messageImpl = message;
		return false;
	}


	public static bool IsMessage<T>(Hash message_id, dynamic message, out T messageImpl,
		bool reconstructMetadata = false) where T : MessageImplementation, new()
	{
		if (!typeToHashLookup.TryGetValue(typeof(T), out var hash))
		{
			var dummy = new T();
			hash = dummy.FetchCode();
			typeToHashLookup.Add(typeof(T), hash);
		}

		if (hash == message_id)
		{
			if (reconstructMetadata)
				messageImpl = LuaTableSerializableExt.DefaultTableDeserialization<T>(message);
			else
				messageImpl = message;

			return true;
		}


		messageImpl = message;
		return false;
	}
}

public abstract class MessageImplementation : ILuaTableSerializable
{
	public ILuaTable ToTable()
	{
		return this.DefaultTableSerialization();
	}


	public abstract Hash FetchCode();
}