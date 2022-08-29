﻿using System.Dynamic;
using src2.defold.support;
using src2.defold.types;

namespace src2.defold
{
	public static class Message
	{
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
		/// @CSharpLua.Template = msg.post({0},{1})
		/// </summary>
		public static extern void post(HashOrStringOrUrl id, string message);


		/// <summary>
		/// @CSharpLua.Template = msg.post({0},{1},{2})
		/// </summary>
		public static extern void post(HashOrStringOrUrl id, string code, ILuaTable data);


		public static void postMessage(HashOrStringOrUrl id, string code, ILuaTableSerializable data)
		{
			post(id, code, data.ToTable());
		}
		
		public static void postMessage(HashOrStringOrUrl id, StandardMessageImplementation message)
		{
			post(id, message.Code, message.ToTable());
		}
		
		public static void postMessage<T>(HashOrStringOrUrl id, T message) where T: CustomMessageImplementation
		{
			post(id, typeof(T).Name, message.ToTable());
		}


		
		/// <summary>
		/// @CSharpLua.Template = msg.post({0},{1},{2})
		/// </summary>
		public static extern void post(HashOrStringOrUrl id, string code, ExpandoObject data);



		public static bool IsMessage<T>(Hash message_id, dynamic message,  Hash expectedCode, out T messageImpl) where T : StandardMessageImplementation
		{
			if (message_id == expectedCode)
			{
				messageImpl = message;
				return true;
			}

			
			messageImpl = message;
			return false;
		}
		
		public static bool IsMessage<T>(Hash message_id, dynamic message, out T messageImpl, bool reconstructMetadata = false) where T : CustomMessageImplementation, new()
		{
			if (message_id == Defold.hash(typeof(T).Name))
			{
				if (reconstructMetadata)
					messageImpl = LuaTableSerializableExt.DefaultTableDeserialization<T>(message);
				else
					messageImpl = (dynamic)message;
				
				return true;
			}


			messageImpl = (dynamic) message;
			return false;
		}
	}
	
	public abstract class StandardMessageImplementation : ILuaTableSerializable
	{
		public abstract Hash Code { get; }


		public ILuaTable ToTable()
		{
			return this.DefaultTableSerialization();
		}
	}
	
	public abstract class CustomMessageImplementation : ILuaTableSerializable
	{
		public ILuaTable ToTable()
		{
			return this.DefaultTableSerialization();
		}
	}
}