using System;
using types;

/// <summary>
/// Vector math API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class vmath
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector3()"
	/// </summary>
	public static extern Vector3 vector3();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector3({0})"
	/// </summary>
	public static extern Vector3 vector3(double n_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector3({0})"
	/// </summary>
	public static extern Vector3 vector3(Vector3 v1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector3({0}, {1}, {2})"
	/// </summary>
	public static extern Vector3 vector3(double x_p1, double y_p2, double z_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector4()"
	/// </summary>
	public static extern Vector4 vector4();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector4({0})"
	/// </summary>
	public static extern Vector4 vector4(double n_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector4({0})"
	/// </summary>
	public static extern Vector4 vector4(Vector4 v1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.vector4({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Vector4 vector4(double x_p1, double y_p2, double z_p3, double w_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat()"
	/// </summary>
	public static extern Quaternion quat();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat({0})"
	/// </summary>
	public static extern Quaternion quat(Quaternion q1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Quaternion quat(double x_p1, double y_p2, double z_p3, double w_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat_from_to({0}, {1})"
	/// </summary>
	public static extern Quaternion quat_from_to(Vector3 v1_p1, Vector3 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat_axis_angle({0}, {1})"
	/// </summary>
	public static extern Quaternion quat_axis_angle(Vector3 v_p1, double angle_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat_basis({0}, {1}, {2})"
	/// </summary>
	public static extern Quaternion quat_basis(Vector3 x_p1, Vector3 y_p2, Vector3 z_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat_rotation_x({0})"
	/// </summary>
	public static extern Quaternion quat_rotation_x(double angle_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat_rotation_y({0})"
	/// </summary>
	public static extern Quaternion quat_rotation_y(double angle_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.quat_rotation_z({0})"
	/// </summary>
	public static extern Quaternion quat_rotation_z(double angle_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4()"
	/// </summary>
	public static extern Matrix4 matrix4();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4({0})"
	/// </summary>
	public static extern Matrix4 matrix4(Matrix4 m1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_frustum({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern Matrix4 matrix4_frustum(double left_p1, double right_p2, double bottom_p3, double top_p4, double near_p5, double far_p6);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_look_at({0}, {1}, {2})"
	/// </summary>
	public static extern Matrix4 matrix4_look_at(Vector3 eye_p1, Vector3 look_at_p2, Vector3 up_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_orthographic({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern Matrix4 matrix4_orthographic(double left_p1, double right_p2, double bottom_p3, double top_p4, double near_p5, double far_p6);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_perspective({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Matrix4 matrix4_perspective(double fov_p1, double aspect_p2, double near_p3, double far_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_from_quat({0})"
	/// </summary>
	public static extern Matrix4 matrix4_from_quat(Quaternion q_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_axis_angle({0}, {1})"
	/// </summary>
	public static extern Matrix4 matrix4_axis_angle(Vector3 v_p1, double angle_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_rotation_x({0})"
	/// </summary>
	public static extern Matrix4 matrix4_rotation_x(double angle_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_rotation_y({0})"
	/// </summary>
	public static extern Matrix4 matrix4_rotation_y(double angle_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_rotation_z({0})"
	/// </summary>
	public static extern Matrix4 matrix4_rotation_z(double angle_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
	/// </summary>
	public static extern Matrix4 matrix4_translation(Vector3 position_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
	/// </summary>
	public static extern Matrix4 matrix4_translation(Vector4 position_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.inv({0})"
	/// </summary>
	public static extern Matrix4 inv(Matrix4 m1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.ortho_inv({0})"
	/// </summary>
	public static extern Matrix4 ortho_inv(Matrix4 m1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(Vector3 v1_p1, Vector3 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(Vector3 v1_p1, Vector4 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(Vector4 v1_p1, Vector3 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(Vector4 v1_p1, Vector4 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.length_sqr({0})"
	/// </summary>
	public static extern double length_sqr(Vector3 v_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.length_sqr({0})"
	/// </summary>
	public static extern double length_sqr(Vector4 v_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.length_sqr({0})"
	/// </summary>
	public static extern double length_sqr(Quaternion v_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.length({0})"
	/// </summary>
	public static extern double length(Vector3 v_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.length({0})"
	/// </summary>
	public static extern double length(Vector4 v_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.length({0})"
	/// </summary>
	public static extern double length(Quaternion v_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.normalize({0})"
	/// </summary>
	public static extern Vector3 normalize(Vector3 v1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.normalize({0})"
	/// </summary>
	public static extern Vector4 normalize(Vector4 v1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.normalize({0})"
	/// </summary>
	public static extern Quaternion normalize(Quaternion v1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.cross({0}, {1})"
	/// </summary>
	public static extern Vector3 cross(Vector3 v1_p1, Vector3 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern Vector3 lerp(double t_p1, Vector3 v1_p2, Vector3 v2_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern Vector4 lerp(double t_p1, Vector4 v1_p2, Vector4 v2_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern Quaternion lerp(double t_p1, Quaternion v1_p2, Quaternion v2_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern double lerp(double t_p1, double v1_p2, double v2_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.slerp({0}, {1}, {2})"
	/// </summary>
	public static extern Vector3 slerp(double t_p1, Vector3 v1_p2, Vector3 v2_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.slerp({0}, {1}, {2})"
	/// </summary>
	public static extern Vector4 slerp(double t_p1, Vector4 v1_p2, Vector4 v2_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.slerp({0}, {1}, {2})"
	/// </summary>
	public static extern Quaternion slerp(double t_p1, Quaternion v1_p2, Quaternion v2_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.conj({0})"
	/// </summary>
	public static extern Quaternion conj(Quaternion q1_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.rotate({0}, {1})"
	/// </summary>
	public static extern Vector3 rotate(Quaternion q_p1, Vector3 v1_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.project({0}, {1})"
	/// </summary>
	public static extern double project(Vector3 v1_p1, Vector3 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.mul_per_elem({0}, {1})"
	/// </summary>
	public static extern Vector3 mul_per_elem(Vector3 v1_p1, Vector3 v2_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "vmath.mul_per_elem({0}, {1})"
	/// </summary>
	public static extern Vector4 mul_per_elem(Vector4 v1_p1, Vector4 v2_p2);
		
		
}