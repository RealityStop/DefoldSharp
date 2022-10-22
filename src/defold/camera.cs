using System;
using types;

/// <summary>
/// Camera API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class camera
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class set_camera_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("set_camera");
		public double aspect_ratio;
		public double fov;
		public double near_z;
		public double far_z;
		public bool orthographic_projection;
		public double orthographic_zoom;
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class acquire_camera_focus_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("acquire_camera_focus");
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class release_camera_focus_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("release_camera_focus");
	}
	
	
}
