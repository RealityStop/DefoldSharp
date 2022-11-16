using System;
using support;

namespace types
{
	/// <summary>
	/// </summary>
	public class Node
	{
		/// <summary>
		/// @CSharpLua.Template = "gui.set_enabled({this}, {0})"
		/// </summary>
		public extern void SetEnabled(bool enabled);
	}

	public class NodeProxy
	{
		private Node _proxy;


		internal void __assignproxy__(Node proxy)
		{
			_proxy = proxy;
		}
		
		public static implicit operator Node(NodeProxy p)
		{
			return p._proxy;
		}
	}
	
	public class TextNode : NodeProxy
	{
		public string GetText()
		{
			return Gui.get_text(this);
		}


		public void SetText(string text)
		{
			Gui.set_text(this, text);
		}
	}

	public class ButtonNode : NodeProxy
	{
		
	}
}