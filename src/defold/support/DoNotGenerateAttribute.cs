using System;

namespace support
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class DoNotGenerateAttribute : Attribute
	{
	}
}