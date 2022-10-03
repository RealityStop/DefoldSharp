using System;

namespace attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public class PropertyProxyHandling : Attribute
	{
		public enum HandlingStyle { Implicit, Explicit }

		public HandlingStyle Style { get;}


		public PropertyProxyHandling(HandlingStyle style)
		{
			Style = style;
		}
	}
}