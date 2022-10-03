using System;

namespace support
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public class DoNotGenerateAttribute : Attribute
	{
		
	}
}