using System;
using support;
using types;

/// <summary>
/// Camera API documentation
/// 
/// </summary>
public static class Camera
{
	#region Defold API
	#region Messages
	/// <summary>
	/// </summary>
	public class set_camera_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("set_camera");
		public override Hash FetchCode() => __CODE__;

		public double aspect_ratio;
		public double fov;
		public double near_z;
		public double far_z;
		public bool orthographic_projection;
		public double orthographic_zoom;
	}


	/// <summary>
	/// </summary>
	public class acquire_camera_focus_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("acquire_camera_focus");
		public override Hash FetchCode() => __CODE__;

	}


	/// <summary>
	/// </summary>
	public class release_camera_focus_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("release_camera_focus");
		public override Hash FetchCode() => __CODE__;

	}


	#endregion Messages


	#endregion Defold API
}
