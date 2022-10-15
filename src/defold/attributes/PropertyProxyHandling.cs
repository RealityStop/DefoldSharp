using System;

namespace attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public class PropertyProxyHandling : Attribute
	{
		public enum HandlingStyle
		{
			Implicit,
			Explicit
		}


		public PropertyProxyHandling(HandlingStyle style)
		{
			Style = style;
		}


		public HandlingStyle Style { get; }
	}
}