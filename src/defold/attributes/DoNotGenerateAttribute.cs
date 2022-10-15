using System;

namespace attributes
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class DoNotGenerateAttribute : Attribute
	{
	}
}