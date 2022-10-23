using types;

/// <summary>
///     Camera API documentation
/// </summary>
public static class Camera
{
	/// <summary>
	/// </summary>
	public class set_camera_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("set_camera");

		public double aspect_ratio;
		public double far_z;
		public double fov;
		public double near_z;
		public bool orthographic_projection;
		public double orthographic_zoom;


		public override Hash FetchCode()
		{
			return __CODE__;
		}
	}


	/// <summary>
	/// </summary>
	public class acquire_camera_focus_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("acquire_camera_focus");


		public override Hash FetchCode()
		{
			return __CODE__;
		}
	}


	/// <summary>
	/// </summary>
	public class release_camera_focus_message : MessageImplementation
	{
		public static Hash __CODE__ = Defold.hash("release_camera_focus");


		public override Hash FetchCode()
		{
			return __CODE__;
		}
	}
}