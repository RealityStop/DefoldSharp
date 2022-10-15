using System;
using types;

/// <summary>
/// Messaging API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class msg
{
	/// <summary>
	/// This is equivalent to <code>msg.url(nil)</code> or <code>msg.url("#")</code>, which creates an url to the current
	/// script component.
	/// 
	/// @CSharpLua.Template = "msg.url()"
	/// </summary>
	public static extern Url url();
	
	
	/// <summary>
	/// The format of the string must be <code>[socket:][path][#fragment]</code>, which is similar to a HTTP URL.
	/// When addressing instances:
	/// <ul>
	/// <li><code>socket</code> is the name of a valid world (a collection)</li>
	/// <li><code>path</code> is the id of the instance, which can either be relative the instance of the calling script or global</li>
	/// <li><code>fragment</code> would be the id of the desired component</li>
	/// </ul>
	/// In addition, the following shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "msg.url({0})"
	/// </summary>
	public static extern Url url(string urlstring_p1);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1})"
	/// </summary>
	public static extern Url url(string socket_p1, string path_p2);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(string socket_p1, string path_p2, string fragment_p3);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(string socket_p1, string path_p2, Hash fragment_p3);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1})"
	/// </summary>
	public static extern Url url(string socket_p1, Hash path_p2);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(string socket_p1, Hash path_p2, string fragment_p3);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(string socket_p1, Hash path_p2, Hash fragment_p3);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1})"
	/// </summary>
	public static extern Url url(Hash socket_p1, string path_p2);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(Hash socket_p1, string path_p2, string fragment_p3);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(Hash socket_p1, string path_p2, Hash fragment_p3);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1})"
	/// </summary>
	public static extern Url url(Hash socket_p1, Hash path_p2);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(Hash socket_p1, Hash path_p2, string fragment_p3);
	
	
	/// <summary>
	/// creates a new URL from separate arguments
	/// 
	/// @CSharpLua.Template = "msg.url({0}, {1}, {2})"
	/// </summary>
	public static extern Url url(Hash socket_p1, Hash path_p2, Hash fragment_p3);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1})"
	/// </summary>
	public static extern void post(string receiver_p1, string message_id_p2);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
	/// </summary>
	public static extern void post(string receiver_p1, string message_id_p2, ILuaTable message_p3);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1})"
	/// </summary>
	public static extern void post(string receiver_p1, Hash message_id_p2);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
	/// </summary>
	public static extern void post(string receiver_p1, Hash message_id_p2, ILuaTable message_p3);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1})"
	/// </summary>
	public static extern void post(Url receiver_p1, string message_id_p2);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
	/// </summary>
	public static extern void post(Url receiver_p1, string message_id_p2, ILuaTable message_p3);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1})"
	/// </summary>
	public static extern void post(Url receiver_p1, Hash message_id_p2);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
	/// </summary>
	public static extern void post(Url receiver_p1, Hash message_id_p2, ILuaTable message_p3);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1})"
	/// </summary>
	public static extern void post(Hash receiver_p1, string message_id_p2);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
	/// </summary>
	public static extern void post(Hash receiver_p1, string message_id_p2, ILuaTable message_p3);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1})"
	/// </summary>
	public static extern void post(Hash receiver_p1, Hash message_id_p2);
	
	
	/// <summary>
	/// Post a message to a receiving URL. The most common case is to send messages
	/// to a component. If the component part of the receiver is omitted, the message
	/// is broadcast to all components in the game object.
	/// The following receiver shorthands are available:
	/// <ul>
	/// <li><code>"."</code> the current game object</li>
	/// <li><code>"#"</code> the current component</li>
	/// </ul>
	/// <span class="icon-attention"></span> There is a 2 kilobyte limit to the message parameter table size.
	/// 
	/// @CSharpLua.Template = "msg.post({0}, {1}, {2})"
	/// </summary>
	public static extern void post(Hash receiver_p1, Hash message_id_p2, ILuaTable message_p3);
	
	
}
