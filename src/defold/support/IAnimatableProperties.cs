using System;
using attributes;

namespace support
{
	/// <summary>
	///   Because Defold will establish properties on the self userobject, we have to create a proxy to source the properties from.  
	/// </summary>
	[DefoldPropertyProxyGen]
	public class AnimatableProperties
	{
		public AnimatableProperties()
		{
			throw new InvalidOperationException("Defold handles property construction. Do not call the constructor yourself!");
		}
	}
}