namespace support
{
	[DoNotGenerate]
	public class ScriptPropertyHost<TProps> : GeneratedScript where TProps : AnimatableProperties
	{
		protected TProps Properties { get; private set; }


		protected virtual void AssignProperties(TProps prop)
		{
			Properties = prop;
		}
	}
}