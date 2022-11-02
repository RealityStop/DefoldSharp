using System;

namespace types
{
	/// <summary>
	/// </summary>
	public class Vector3 : ILuaType
	{
		public double x, y, z;

		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3()"
		/// </summary>
		public extern Vector3();

		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3({0},{1},{2})"
		/// </summary>
		public extern Vector3(double x, double y, double z);


		/// <summary>
		/// @CSharpLua.Template = "{0} + {1}"
		/// </summary>
		public static extern Vector3 operator +(Vector3 a, Vector3 b);


		/// <summary>
		/// @CSharpLua.Template = "{0} - {1}"
		/// </summary>
		public static extern Vector3 operator -(Vector3 a, Vector3 b);

		/// <summary>
		/// @CSharpLua.Template = "-{0}"
		/// </summary>
		public static extern Vector3 neg(Vector3 a);


		/// <summary>
		/// @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern Vector3 operator *(Vector3 a, double b);

		/// <summary>
		/// @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern Vector3 operator *(double a, Vector3 b);

		/// <summary>
		/// @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern Vector3 operator *(Vector3 a, Vector3 b);


		/// <summary>
		/// @CSharpLua.Template = "{0} / {1}"
		/// </summary>
		public static extern Vector3 operator /(Vector3 a, double b);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length({this})"
		/// </summary>
		public extern double Magnitude();
		
		/// <summary>
		/// @CSharpLua.Template = "vmath.length_sqr({this})"
		/// </summary>
		public extern double MagnitudeSqr();


		/// <summary>
		/// @CSharpLua.Template = "vmath.mul_per_elem({this},{0})"
		/// </summary>
		public extern Vector3 MultiplyByElement(Vector3 other);


		/// <summary>
		/// @CSharpLua.Template = "vmath.normalize({this})"
		/// </summary>
		public extern Vector3 Normalize();


		/// <summary>
		/// @CSharpLua.Template = "vmath.project({this},{0})"
		/// </summary>
		public extern double Project(Vector3 v);


		/// <summary>
		/// @CSharpLua.Template = "{this}"
		/// </summary>
		public extern Vector2 ToVector2();
	}
}
