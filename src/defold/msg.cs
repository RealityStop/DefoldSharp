using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Messaging API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class msg
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url()"
		/// </summary>
		public static extern Url url();
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0})"
		/// </summary>
		public static extern Url url(string urlstring_p1);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(string socket_p1, string path_p2, string fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(string socket_p1, string path_p2, Hash fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(string socket_p1, Hash path_p2, string fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(string socket_p1, Hash path_p2, Hash fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(Hash socket_p1, string path_p2, string fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(Hash socket_p1, string path_p2, Hash fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(Hash socket_p1, Hash path_p2, string fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
		/// </summary>
		public static extern Url url(Hash socket_p1, Hash path_p2, Hash fragment_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(string receiver_p1, string message_id_p2, ILuaTable message_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(string receiver_p1, string message_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(string receiver_p1, Hash message_id_p2, ILuaTable message_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(string receiver_p1, Hash message_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Url receiver_p1, string message_id_p2, ILuaTable message_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Url receiver_p1, string message_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Url receiver_p1, Hash message_id_p2, ILuaTable message_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Url receiver_p1, Hash message_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Hash receiver_p1, string message_id_p2, ILuaTable message_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Hash receiver_p1, string message_id_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Hash receiver_p1, Hash message_id_p2, ILuaTable message_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
		/// </summary>
		public static extern void post(Hash receiver_p1, Hash message_id_p2);
		
		
	}
}
