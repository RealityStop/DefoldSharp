namespace DefoldSharp
{
	[DoNotGenerate]
	public class ScriptPropertyHost<TProps> : GeneratedScript where TProps : AnimatableProperties
	{
		protected TProps Properties { get; private set; }
		protected bool IsInputFocusHeld { get; private set; }



		protected virtual void AssignProperties(TProps prop)
		{
			Properties = prop;
		}
		
		protected void RequestInput()
		{
			InputHelpers.RequestInput();
			IsInputFocusHeld = true;
		}


		protected void ReleaseInput()
		{
			IsInputFocusHeld = false;
			InputHelpers.ReleaseInput();
		}
	}
}