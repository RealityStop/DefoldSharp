﻿using System;

namespace attributes
{
	/// <summary>
	///     Flags a class as a property proxy, and that properties need to be generated on scripts
	///     that use this class as a proxy.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class DefoldPropertyProxyGenAttribute : Attribute
	{
	}
}