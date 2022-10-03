namespace types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class Matrix4
	{
		public float x, y, u, v;

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4()"
/// </summary>
public extern Matrix4();

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4({0})"
/// </summary>
public static extern Matrix4 Clone(Matrix4 m1);
      
/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_axis_angle({0},{1})"
/// </summary>
public static extern Matrix4 From_axis_angle(Vector3 v, float angle);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_from_quat({0})"
/// </summary>
public static extern Matrix4 From_quat(Quaternion q);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_frustum({0},{1},{2},{3},{4},{5})"
/// </summary>
public static extern Matrix4 From_frustum(float left, float right, float bottom, float top, float near, float far);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_look_at({0},{1},{2})"
/// </summary>
public static extern Matrix4 From_look_at(Vector3 eye, Vector3 lookat, Vector3 up);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_orthographic({0},{1},{2},{3},{4},{5})"
/// </summary>
public static extern Matrix4 From_orthographic(float left, float right, float bottom, float top, float near, float far);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_perspective({0},{1},{2},{3})"
/// </summary>
public static extern Matrix4 From_perspective(float fov, float aspect, float near, float far);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_rotation_x({0})"
/// </summary>
public static extern Matrix4 From_rotation_x(float angle);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_rotation_y({0})"
/// </summary>
public static extern Matrix4 From_rotation_y(float angle);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_rotation_z({0})"
/// </summary>
public static extern Matrix4 From_rotation_z(float angle);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
/// </summary>
public static extern Matrix4 From_translation(Vector3 position);

/// <summary>
/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
/// </summary>
public static extern Matrix4 From_translation(Vector4 position);









/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Matrix4 operator *(Matrix4 a, float b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Matrix4 operator *(float a, Matrix4 b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Matrix4 operator *(Matrix4 a, Matrix4 b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Matrix4 operator *(Matrix4 a, Vector4 b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Matrix4 operator *(Vector4 a, Matrix4 b);



/// <summary>
/// @CSharpLua.Template = "vmath.ortho_inv({this})"
/// </summary>
public extern Matrix4 OrthoInv();
	}
}
