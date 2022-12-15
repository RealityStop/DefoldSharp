namespace DefoldSharp
{
	/// <summary>
	/// </summary>
	public class Quaternion : ILuaType
	{
		private float x, y, z, w;

		/// <summary>
		/// @CSharpLua.Template = "vmath.quat()"
		/// </summary>
		public extern Quaternion();
		/// <summary>
		/// @CSharpLua.Template = "vmath.quat({0})"
		/// </summary>
		public extern Quaternion(Quaternion q);
		/// <summary>
		/// @CSharpLua.Template = "vmath.quat({0},{1},{2},{3})"
		/// </summary>
		public extern Quaternion(float x, float y, float z, float w);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_axis_angle({0},{1})"
		/// </summary>
		public static extern Quaternion From_axis_angle(vector3 v, float angle);

		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_basis({0},{1},{2})"
		/// </summary>
		public static extern Quaternion From_basis(vector3 x, vector3 y, vector3 z);

		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_from_to({0},{1})"
		/// </summary>
		public static extern Quaternion From_to(vector3 v1, vector3 v2);

		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_rotation_x({0})"
		/// </summary>
		public static extern Quaternion Rotation_x(float angle);
		            
		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_rotation_y({0})"
		/// </summary>
		public static extern Quaternion Rotation_y(float angle);
		            
		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_rotation_z({0})"
		/// </summary>
		public static extern Quaternion Rotation_z(float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.rotate({this},{0})"
		/// </summary>
		public extern vector3 RotateVector(vector3 v);




		/// <summary>
		/// @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern Quaternion operator *(Quaternion a, Quaternion b);
	}
}
