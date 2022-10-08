using System;

namespace attributes
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public class DoNotGenerateAttribute : Attribute
	{
		
	}
}