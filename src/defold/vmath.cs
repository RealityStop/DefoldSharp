using Microsoft.VisualBasic.CompilerServices;
using src2.defold.types;

namespace src2.defold
{
	/// <summary>
	///   Functions for mathematical operations on vectors, matrices and quaternions.
	///   
	///   * The vector types (`Vector3` and `Vector4`) supports addition and subtraction
	///   with vectors of the same type. Vectors can be negated and multiplied with numbers
	///   (scaled).
	///   
	///   * The quaternion type (`Quaternion`) supports multiplication with other quaternions.
	///   
	///   * The matrix type (`Matrix4`) can be multiplied with numbers, other matrices and `Vector4` values.
	///   
	///   * All types performs equality comparison by each component value.
	/// @CSharpLua.Ignore
	/// </summary>
	public static class vmath
	{
		/// <summary>
		/// @CSharpLua.Template = "vmath.conj({0})"
		/// </summary>
		public static extern Quaternion conj(Quaternion q1);


		/// <summary>
		/// @CSharpLua.Template = "vmath.cross({0},{1})"
		/// </summary>
		public static extern Vector2 cross(Vector2 v1, Vector2 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.cross({0},{1})"
		/// </summary>
		public static extern Vector3 cross(Vector3 v1, Vector3 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.dot({0},{1})"
		/// </summary>
		public static extern float dot(Vector2 v1, Vector2 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.dot({0},{1})"
		/// </summary>
		public static extern float dot(Vector3 v1, Vector3 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.dot({0},{1})"
		/// </summary>
		public static extern float dot(Vector4 v1, Vector4 v2);


		//TODO:inv


		/// <summary>
		/// @CSharpLua.Template = "vmath.length({0})"
		/// </summary>
		public static extern float length(Vector2 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length({0})"
		/// </summary>
		public static extern float length(Vector3 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length({0})"
		/// </summary>
		public static extern float length(Vector4 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length({0})"
		/// </summary>
		public static extern float length(Quaternion v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length_sqr({0})"
		/// </summary>
		public static extern float length_sqr(Vector2 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length_sqr({0})"
		/// </summary>
		public static extern float length_sqr(Vector3 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length_sqr({0})"
		/// </summary>
		public static extern float length_sqr(Vector4 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length_sqr({0})"
		/// </summary>
		public static extern float length_sqr(Quaternion v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.slerp({0},{1},{2})"
		/// </summary>
		public static extern Quaternion slerp(float t, Quaternion v1, Quaternion v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.slerp({0},{1},{2})"
		/// </summary>
		public static extern Vector3 slerp(float t, Vector3 v1, Vector3 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.slerp({0},{1},{2})"
		/// </summary>
		public static extern Vector4 slerp(float t, Vector4 v1, Vector4 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.slerp({0},{1},{2})"
		/// </summary>
		public static extern float slerp(float t, float v1, float v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3()"
		/// </summary>
		public static extern Vector3 vector3();


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3({0})"
		/// </summary>
		public static extern Vector3 vector3(float n);


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3({0})"
		/// </summary>
		public static extern Vector3 vector3(Vector3 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3({0},{1},{2})"
		/// </summary>
		public static extern Vector3 vector3(float x, float y, float z);


		//TODO:Create vector from table  (vmath.vector)


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector4()"
		/// </summary>
		public static extern Vector4 vector4();


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector4({0})"
		/// </summary>
		public static extern Vector4 vector4(float n);


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3({0})"
		/// </summary>
		public static extern Vector4 vector4(Vector4 v);


		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3({0},{1},{2})"
		/// </summary>
		public static extern Vector4 vector4(float x, float y, float z, float w);


		/// <summary>
		/// @CSharpLua.Template = "vmath.mul_per_elem({0},{1})"
		/// </summary>
		public static extern Vector3 mul_per_elem(Vector3 v1, Vector3 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.mul_per_elem({0},{1})"
		/// </summary>
		public static extern Vector4 mul_per_elem(Vector4 v1, Vector4 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.normalize({0})"
		/// </summary>
		public static extern Vector3 normalize(Vector3 v1);


		/// <summary>
		/// @CSharpLua.Template = "vmath.normalize({0})"
		/// </summary>
		public static extern Vector4 normalize(Vector4 v1);


		/// <summary>
		/// @CSharpLua.Template = "vmath.normalize({0})"
		/// </summary>
		public static extern Quaternion normalize(Quaternion v1);


		/// <summary>
		/// @CSharpLua.Template = "vmath.project({0},{1})"
		/// </summary>
		public static extern float project(Vector3 v1, Vector3 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4()"
		/// </summary>
		public static extern Matrix4 matrix4();


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4({0})"
		/// </summary>
		public static extern Matrix4 matrix4(Matrix4 m1);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_axis_angle({0},{1})"
		/// </summary>
		public static extern Matrix4 matrix4_axis_angle(Vector3 v, float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_from_quat({0})"
		/// </summary>
		public static extern Matrix4 matrix4_from_quat(Quaternion q);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_frustum({0},{1},{2},{3},{4},{5})"
		/// </summary>
		public static extern Matrix4 matrix4_frustum(float left, float right, float bottom, float top, float near,
			float far);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_look_at({0},{1},{2})"
		/// </summary>
		public static extern Matrix4 matrix4_look_at(Vector3 eye, Vector3 lookat, Vector3 up);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_orthographic({0},{1},{2},{3},{4},{5})"
		/// </summary>
		public static extern Matrix4 matrix4_orthographic(float left, float right, float bottom, float top, float near,
			float far);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_perspective({0},{1},{2},{3})"
		/// </summary>
		public static extern Matrix4 matrix4_perspective(float fov, float aspect, float near, float far);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_rotation_x({0})"
		/// </summary>
		public static extern Matrix4 matrix4_rotation_x(float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_rotation_y({0})"
		/// </summary>
		public static extern Matrix4 matrix4_rotation_y(float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_rotation_z({0})"
		/// </summary>
		public static extern Matrix4 matrix4_rotation_z(float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
		/// </summary>
		public static extern Matrix4 matrix4_translation(Vector3 position);


		/// <summary>
		/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
		/// </summary>
		public static extern Matrix4 matrix4_translation(Vector4 position);


		/// <summary>
		/// @CSharpLua.Template = "vmath.ortho_inv({0})"
		/// </summary>
		public static extern Matrix4 ortho_inv(Matrix4 position);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat()"
		/// </summary>
		public static extern Quaternion quat();


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat({0})"
		/// </summary>
		public static extern Quaternion quat(Quaternion q);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat({0},{1},{2},{3})"
		/// </summary>
		public static extern Quaternion quat(float x, float y, float z, float w);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_axis_angle({0},{1})"
		/// </summary>
		public static extern Quaternion quat_axis_angle(Vector3 v, float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_basis({0},{1},{2})"
		/// </summary>
		public static extern Quaternion quat_basis(Vector3 x, Vector3 y, Vector3 z);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_from_to({0},{1})"
		/// </summary>
		public static extern Quaternion quat_from_to(Vector3 v1, Vector3 v2);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_rotation_x({0})"
		/// </summary>
		public static extern Quaternion quat_rotation_x(float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_rotation_y({0})"
		/// </summary>
		public static extern Quaternion quat_rotation_y(float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.quat_rotation_z({0})"
		/// </summary>
		public static extern Quaternion quat_rotation_z(float angle);


		/// <summary>
		/// @CSharpLua.Template = "vmath.rotate({0},{1})"
		/// </summary>
		public static extern Vector3 rotate(Quaternion q, Vector3 v);
	}
}