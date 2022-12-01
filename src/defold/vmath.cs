using System;
using support;
using lua;
using types;

/// <summary>
/// Vector math API documentation
/// 
/// </summary>
public static class Vmath
{
	#region Defold API
	/// <summary>
	/// Creates a new zero vector with all components set to 0.
	/// 
	/// @CSharpLua.Template = "vmath.vector3()"
	/// </summary>
	public static extern vector3 vector3();


	/// <summary>
	/// Creates a new vector with all components set to the
	/// supplied scalar value.
	/// 
	/// @CSharpLua.Template = "vmath.vector3({0})"
	/// </summary>
	public static extern vector3 vector3(double n_p1);


	/// <summary>
	/// Creates a new vector with all components set to the
	/// corresponding values from the supplied vector. I.e.
	/// This function creates a copy of the given vector.
	/// 
	/// @CSharpLua.Template = "vmath.vector3({0})"
	/// </summary>
	public static extern vector3 vector3(vector3 v1_p1);


	/// <summary>
	/// Creates a new vector with the components set to the
	/// supplied values.
	/// 
	/// @CSharpLua.Template = "vmath.vector3({0}, {1}, {2})"
	/// </summary>
	public static extern vector3 vector3(double x_p1, double y_p2, double z_p3);


	/// <summary>
	/// Creates a new zero vector with all components set to 0.
	/// 
	/// @CSharpLua.Template = "vmath.vector4()"
	/// </summary>
	public static extern vector4 vector4();


	/// <summary>
	/// Creates a new vector with all components set to the
	/// supplied scalar value.
	/// 
	/// @CSharpLua.Template = "vmath.vector4({0})"
	/// </summary>
	public static extern vector4 vector4(double n_p1);


	/// <summary>
	/// Creates a new vector with all components set to the
	/// corresponding values from the supplied vector. I.e.
	/// This function creates a copy of the given vector.
	/// 
	/// @CSharpLua.Template = "vmath.vector4({0})"
	/// </summary>
	public static extern vector4 vector4(vector4 v1_p1);


	/// <summary>
	/// Creates a new vector with the components set to the
	/// supplied values.
	/// 
	/// @CSharpLua.Template = "vmath.vector4({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern vector4 vector4(double x_p1, double y_p2, double z_p3, double w_p4);


	/// <summary>
	/// Creates a new identity quaternion. The identity
	/// quaternion is equal to:
	/// <code>vmath.quat(0, 0, 0, 1)</code>
	/// 
	/// @CSharpLua.Template = "vmath.quat()"
	/// </summary>
	public static extern Quaternion quat();


	/// <summary>
	/// Creates a new quaternion with all components set to the
	/// corresponding values from the supplied quaternion. I.e.
	/// This function creates a copy of the given quaternion.
	/// 
	/// @CSharpLua.Template = "vmath.quat({0})"
	/// </summary>
	public static extern Quaternion quat(Quaternion q1_p1);


	/// <summary>
	/// Creates a new quaternion with the components set
	/// according to the supplied parameter values.
	/// 
	/// @CSharpLua.Template = "vmath.quat({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Quaternion quat(double x_p1, double y_p2, double z_p3, double w_p4);


	/// <summary>
	/// The resulting quaternion describes the rotation that,
	/// if applied to the first vector, would rotate the first
	/// vector to the second. The two vectors must be unit
	/// vectors (of length 1).
	/// <span class="icon-attention"></span> The result is undefined if the two vectors point in opposite directions
	/// 
	/// @CSharpLua.Template = "vmath.quat_from_to({0}, {1})"
	/// </summary>
	public static extern Quaternion quat_from_to(vector3 v1_p1, vector3 v2_p2);


	/// <summary>
	/// The resulting quaternion describes a rotation of <code>angle</code>
	/// radians around the axis described by the unit vector <code>v</code>.
	/// 
	/// @CSharpLua.Template = "vmath.quat_axis_angle({0}, {1})"
	/// </summary>
	public static extern Quaternion quat_axis_angle(vector3 v_p1, double angle_p2);


	/// <summary>
	/// The resulting quaternion describes the rotation from the
	/// identity quaternion (no rotation) to the coordinate system
	/// as described by the given x, y and z base unit vectors.
	/// 
	/// @CSharpLua.Template = "vmath.quat_basis({0}, {1}, {2})"
	/// </summary>
	public static extern Quaternion quat_basis(vector3 x_p1, vector3 y_p2, vector3 z_p3);


	/// <summary>
	/// The resulting quaternion describes a rotation of <code>angle</code>
	/// radians around the x-axis.
	/// 
	/// @CSharpLua.Template = "vmath.quat_rotation_x({0})"
	/// </summary>
	public static extern Quaternion quat_rotation_x(double angle_p1);


	/// <summary>
	/// The resulting quaternion describes a rotation of <code>angle</code>
	/// radians around the y-axis.
	/// 
	/// @CSharpLua.Template = "vmath.quat_rotation_y({0})"
	/// </summary>
	public static extern Quaternion quat_rotation_y(double angle_p1);


	/// <summary>
	/// The resulting quaternion describes a rotation of <code>angle</code>
	/// radians around the z-axis.
	/// 
	/// @CSharpLua.Template = "vmath.quat_rotation_z({0})"
	/// </summary>
	public static extern Quaternion quat_rotation_z(double angle_p1);


	/// <summary>
	/// The resulting identity matrix describes a transform with
	/// no translation or rotation.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4()"
	/// </summary>
	public static extern Matrix4 matrix4();


	/// <summary>
	/// Creates a new matrix with all components set to the
	/// corresponding values from the supplied matrix. I.e.
	/// the function creates a copy of the given matrix.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4({0})"
	/// </summary>
	public static extern Matrix4 matrix4(Matrix4 m1_p1);


	/// <summary>
	/// Constructs a frustum matrix from the given values. The left, right,
	/// top and bottom coordinates of the view cone are expressed as distances
	/// from the center of the near clipping plane. The near and far coordinates
	/// are expressed as distances from the tip of the view frustum cone.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_frustum({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern Matrix4 matrix4_frustum(double left_p1, double right_p2, double bottom_p3, double top_p4, double near_p5, double far_p6);


	/// <summary>
	/// The resulting matrix is created from the supplied look-at parameters.
	/// This is useful for constructing a view matrix for a camera or
	/// rendering in general.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_look_at({0}, {1}, {2})"
	/// </summary>
	public static extern Matrix4 matrix4_look_at(vector3 eye_p1, vector3 look_at_p2, vector3 up_p3);


	/// <summary>
	/// Creates an orthographic projection matrix.
	/// This is useful to construct a projection matrix for a camera or rendering in general.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_orthographic({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern Matrix4 matrix4_orthographic(double left_p1, double right_p2, double bottom_p3, double top_p4, double near_p5, double far_p6);


	/// <summary>
	/// Creates a perspective projection matrix.
	/// This is useful to construct a projection matrix for a camera or rendering in general.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_perspective({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern Matrix4 matrix4_perspective(double fov_p1, double aspect_p2, double near_p3, double far_p4);


	/// <summary>
	/// The resulting matrix describes the same rotation as the quaternion, but does not have any translation (also like the quaternion).
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_from_quat({0})"
	/// </summary>
	public static extern Matrix4 matrix4_from_quat(Quaternion q_p1);


	/// <summary>
	/// The resulting matrix describes a rotation around the axis by the specified angle.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_axis_angle({0}, {1})"
	/// </summary>
	public static extern Matrix4 matrix4_axis_angle(vector3 v_p1, double angle_p2);


	/// <summary>
	/// The resulting matrix describes a rotation around the x-axis
	/// by the specified angle.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_rotation_x({0})"
	/// </summary>
	public static extern Matrix4 matrix4_rotation_x(double angle_p1);


	/// <summary>
	/// The resulting matrix describes a rotation around the y-axis
	/// by the specified angle.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_rotation_y({0})"
	/// </summary>
	public static extern Matrix4 matrix4_rotation_y(double angle_p1);


	/// <summary>
	/// The resulting matrix describes a rotation around the z-axis
	/// by the specified angle.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_rotation_z({0})"
	/// </summary>
	public static extern Matrix4 matrix4_rotation_z(double angle_p1);


	/// <summary>
	/// The resulting matrix describes a translation of a point
	/// in euclidean space.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
	/// </summary>
	public static extern Matrix4 matrix4_translation(vector3 position_p1);


	/// <summary>
	/// The resulting matrix describes a translation of a point
	/// in euclidean space.
	/// 
	/// @CSharpLua.Template = "vmath.matrix4_translation({0})"
	/// </summary>
	public static extern Matrix4 matrix4_translation(vector4 position_p1);


	/// <summary>
	/// The resulting matrix is the inverse of the supplied matrix.
	/// <span class="icon-attention"></span> For ortho-normal matrices, e.g. regular object transformation,
	/// use <code>vmath.ortho_inv()</code> instead.
	/// The specialized inverse for ortho-normalized matrices is much faster
	/// than the general inverse.
	/// 
	/// @CSharpLua.Template = "vmath.inv({0})"
	/// </summary>
	public static extern Matrix4 inv(Matrix4 m1_p1);


	/// <summary>
	/// The resulting matrix is the inverse of the supplied matrix.
	/// The supplied matrix has to be an ortho-normal matrix, e.g.
	/// describe a regular object transformation.
	/// <span class="icon-attention"></span> For matrices that are not ortho-normal
	/// use the general inverse <code>vmath.inv()</code> instead.
	/// 
	/// @CSharpLua.Template = "vmath.ortho_inv({0})"
	/// </summary>
	public static extern Matrix4 ortho_inv(Matrix4 m1_p1);


	/// <summary>
	/// The returned value is a scalar defined as:
	/// <code>P &#x22C5; Q = |P| |Q| cos &#x03B8;</code>
	/// where &#x03B8; is the angle between the vectors P and Q.
	/// <ul>
	/// <li>If the dot product is positive then the angle between the vectors is below 90 degrees.</li>
	/// <li>If the dot product is zero the vectors are perpendicular (at right-angles to each other).</li>
	/// <li>If the dot product is negative then the angle between the vectors is more than 90 degrees.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(vector3 v1_p1, vector3 v2_p2);


	/// <summary>
	/// The returned value is a scalar defined as:
	/// <code>P &#x22C5; Q = |P| |Q| cos &#x03B8;</code>
	/// where &#x03B8; is the angle between the vectors P and Q.
	/// <ul>
	/// <li>If the dot product is positive then the angle between the vectors is below 90 degrees.</li>
	/// <li>If the dot product is zero the vectors are perpendicular (at right-angles to each other).</li>
	/// <li>If the dot product is negative then the angle between the vectors is more than 90 degrees.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(vector3 v1_p1, vector4 v2_p2);


	/// <summary>
	/// The returned value is a scalar defined as:
	/// <code>P &#x22C5; Q = |P| |Q| cos &#x03B8;</code>
	/// where &#x03B8; is the angle between the vectors P and Q.
	/// <ul>
	/// <li>If the dot product is positive then the angle between the vectors is below 90 degrees.</li>
	/// <li>If the dot product is zero the vectors are perpendicular (at right-angles to each other).</li>
	/// <li>If the dot product is negative then the angle between the vectors is more than 90 degrees.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(vector4 v1_p1, vector3 v2_p2);


	/// <summary>
	/// The returned value is a scalar defined as:
	/// <code>P &#x22C5; Q = |P| |Q| cos &#x03B8;</code>
	/// where &#x03B8; is the angle between the vectors P and Q.
	/// <ul>
	/// <li>If the dot product is positive then the angle between the vectors is below 90 degrees.</li>
	/// <li>If the dot product is zero the vectors are perpendicular (at right-angles to each other).</li>
	/// <li>If the dot product is negative then the angle between the vectors is more than 90 degrees.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "vmath.dot({0}, {1})"
	/// </summary>
	public static extern double dot(vector4 v1_p1, vector4 v2_p2);


	/// <summary>
	/// Returns the squared length of the supplied vector or quaternion.
	/// 
	/// @CSharpLua.Template = "vmath.length_sqr({0})"
	/// </summary>
	public static extern double length_sqr(vector3 v_p1);


	/// <summary>
	/// Returns the squared length of the supplied vector or quaternion.
	/// 
	/// @CSharpLua.Template = "vmath.length_sqr({0})"
	/// </summary>
	public static extern double length_sqr(vector4 v_p1);


	/// <summary>
	/// Returns the squared length of the supplied vector or quaternion.
	/// 
	/// @CSharpLua.Template = "vmath.length_sqr({0})"
	/// </summary>
	public static extern double length_sqr(Quaternion v_p1);


	/// <summary>
	/// Returns the length of the supplied vector or quaternion.
	/// If you are comparing the lengths of vectors or quaternions, you should compare
	/// the length squared instead as it is slightly more efficient to calculate
	/// (it eliminates a square root calculation).
	/// 
	/// @CSharpLua.Template = "vmath.length({0})"
	/// </summary>
	public static extern double length(vector3 v_p1);


	/// <summary>
	/// Returns the length of the supplied vector or quaternion.
	/// If you are comparing the lengths of vectors or quaternions, you should compare
	/// the length squared instead as it is slightly more efficient to calculate
	/// (it eliminates a square root calculation).
	/// 
	/// @CSharpLua.Template = "vmath.length({0})"
	/// </summary>
	public static extern double length(vector4 v_p1);


	/// <summary>
	/// Returns the length of the supplied vector or quaternion.
	/// If you are comparing the lengths of vectors or quaternions, you should compare
	/// the length squared instead as it is slightly more efficient to calculate
	/// (it eliminates a square root calculation).
	/// 
	/// @CSharpLua.Template = "vmath.length({0})"
	/// </summary>
	public static extern double length(Quaternion v_p1);


	/// <summary>
	/// Normalizes a vector, i.e. returns a new vector with the same
	/// direction as the input vector, but with length 1.
	/// <span class="icon-attention"></span> The length of the vector must be above 0, otherwise a
	/// division-by-zero will occur.
	/// 
	/// @CSharpLua.Template = "vmath.normalize({0})"
	/// </summary>
	public static extern vector3 normalize(vector3 v1_p1);


	/// <summary>
	/// Normalizes a vector, i.e. returns a new vector with the same
	/// direction as the input vector, but with length 1.
	/// <span class="icon-attention"></span> The length of the vector must be above 0, otherwise a
	/// division-by-zero will occur.
	/// 
	/// @CSharpLua.Template = "vmath.normalize({0})"
	/// </summary>
	public static extern vector4 normalize(vector4 v1_p1);


	/// <summary>
	/// Normalizes a vector, i.e. returns a new vector with the same
	/// direction as the input vector, but with length 1.
	/// <span class="icon-attention"></span> The length of the vector must be above 0, otherwise a
	/// division-by-zero will occur.
	/// 
	/// @CSharpLua.Template = "vmath.normalize({0})"
	/// </summary>
	public static extern Quaternion normalize(Quaternion v1_p1);


	/// <summary>
	/// Given two linearly independent vectors P and Q, the cross product,
	/// P &#x00D7; Q, is a vector that is perpendicular to both P and Q and
	/// therefore normal to the plane containing them.
	/// If the two vectors have the same direction (or have the exact
	/// opposite direction from one another, i.e. are not linearly independent)
	/// or if either one has zero length, then their cross product is zero.
	/// 
	/// @CSharpLua.Template = "vmath.cross({0}, {1})"
	/// </summary>
	public static extern vector3 cross(vector3 v1_p1, vector3 v2_p2);


	/// <summary>
	/// Linearly interpolate between two vectors. The function
	/// treats the vectors as positions and interpolates between
	/// the positions in a straight line. Lerp is useful to describe
	/// transitions from one place to another over time.
	/// <span class="icon-attention"></span> The function does not clamp t between 0 and 1.
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern vector3 lerp(double t_p1, vector3 v1_p2, vector3 v2_p3);


	/// <summary>
	/// Linearly interpolate between two vectors. The function
	/// treats the vectors as positions and interpolates between
	/// the positions in a straight line. Lerp is useful to describe
	/// transitions from one place to another over time.
	/// <span class="icon-attention"></span> The function does not clamp t between 0 and 1.
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern vector4 lerp(double t_p1, vector4 v1_p2, vector4 v2_p3);


	/// <summary>
	/// Linearly interpolate between two vectors. The function
	/// treats the vectors as positions and interpolates between
	/// the positions in a straight line. Lerp is useful to describe
	/// transitions from one place to another over time.
	/// <span class="icon-attention"></span> The function does not clamp t between 0 and 1.
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern Quaternion lerp(double t_p1, Quaternion v1_p2, Quaternion v2_p3);


	/// <summary>
	/// Linearly interpolate between two vectors. The function
	/// treats the vectors as positions and interpolates between
	/// the positions in a straight line. Lerp is useful to describe
	/// transitions from one place to another over time.
	/// <span class="icon-attention"></span> The function does not clamp t between 0 and 1.
	/// 
	/// @CSharpLua.Template = "vmath.lerp({0}, {1}, {2})"
	/// </summary>
	public static extern double lerp(double t_p1, double v1_p2, double v2_p3);


	/// <summary>
	/// Spherically interpolates between two vectors. The difference to
	/// lerp is that slerp treats the vectors as directions instead of
	/// positions in space.
	/// The direction of the returned vector is interpolated by the angle
	/// and the magnitude is interpolated between the magnitudes of the
	/// from and to vectors.
	/// <span class="icon-attention"></span> Slerp is computationally more expensive than lerp.
	/// The function does not clamp t between 0 and 1.
	/// 
	/// @CSharpLua.Template = "vmath.slerp({0}, {1}, {2})"
	/// </summary>
	public static extern vector3 slerp(double t_p1, vector3 v1_p2, vector3 v2_p3);


	/// <summary>
	/// Spherically interpolates between two vectors. The difference to
	/// lerp is that slerp treats the vectors as directions instead of
	/// positions in space.
	/// The direction of the returned vector is interpolated by the angle
	/// and the magnitude is interpolated between the magnitudes of the
	/// from and to vectors.
	/// <span class="icon-attention"></span> Slerp is computationally more expensive than lerp.
	/// The function does not clamp t between 0 and 1.
	/// 
	/// @CSharpLua.Template = "vmath.slerp({0}, {1}, {2})"
	/// </summary>
	public static extern vector4 slerp(double t_p1, vector4 v1_p2, vector4 v2_p3);


	/// <summary>
	/// Spherically interpolates between two vectors. The difference to
	/// lerp is that slerp treats the vectors as directions instead of
	/// positions in space.
	/// The direction of the returned vector is interpolated by the angle
	/// and the magnitude is interpolated between the magnitudes of the
	/// from and to vectors.
	/// <span class="icon-attention"></span> Slerp is computationally more expensive than lerp.
	/// The function does not clamp t between 0 and 1.
	/// 
	/// @CSharpLua.Template = "vmath.slerp({0}, {1}, {2})"
	/// </summary>
	public static extern Quaternion slerp(double t_p1, Quaternion v1_p2, Quaternion v2_p3);


	/// <summary>
	/// Calculates the conjugate of a quaternion. The result is a
	/// quaternion with the same magnitudes but with the sign of
	/// the imaginary (vector) parts changed:
	/// <code>q<super>*</super> = [w, -v]</code>
	/// 
	/// @CSharpLua.Template = "vmath.conj({0})"
	/// </summary>
	public static extern Quaternion conj(Quaternion q1_p1);


	/// <summary>
	/// Returns a new vector from the supplied vector that is
	/// rotated by the rotation described by the supplied
	/// quaternion.
	/// 
	/// @CSharpLua.Template = "vmath.rotate({0}, {1})"
	/// </summary>
	public static extern vector3 rotate(Quaternion q_p1, vector3 v1_p2);


	/// <summary>
	/// Calculates the extent the projection of the first vector onto the second.
	/// The returned value is a scalar p defined as:
	/// <code>p = |P| cos &#x03B8; / |Q|</code>
	/// where &#x03B8; is the angle between the vectors P and Q.
	/// 
	/// @CSharpLua.Template = "vmath.project({0}, {1})"
	/// </summary>
	public static extern double project(vector3 v1_p1, vector3 v2_p2);


	/// <summary>
	/// Performs an element wise multiplication between two vectors of the same type
	/// The returned value is a vector defined as (e.g. for a vector3):
	/// <code>v = vmath.mul_per_elem(a, b) = vmath.vector3(a.x * b.x, a.y * b.y, a.z * b.z)</code>
	/// 
	/// @CSharpLua.Template = "vmath.mul_per_elem({0}, {1})"
	/// </summary>
	public static extern vector3 mul_per_elem(vector3 v1_p1, vector3 v2_p2);


	/// <summary>
	/// Performs an element wise multiplication between two vectors of the same type
	/// The returned value is a vector defined as (e.g. for a vector3):
	/// <code>v = vmath.mul_per_elem(a, b) = vmath.vector3(a.x * b.x, a.y * b.y, a.z * b.z)</code>
	/// 
	/// @CSharpLua.Template = "vmath.mul_per_elem({0}, {1})"
	/// </summary>
	public static extern vector4 mul_per_elem(vector4 v1_p1, vector4 v2_p2);


	#endregion Defold API
}
