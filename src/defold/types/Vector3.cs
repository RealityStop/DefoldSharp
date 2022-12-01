using System;
using lua;

namespace types
{
	/// <summary>
	/// </summary>
	public class vector3 : ILuaType
	{
		public double x, y, z;


		/// <summary>
		///     @CSharpLua.Template = "vmath.vector3()"
		/// </summary>
		public extern vector3();


		/// <summary>
		///     @CSharpLua.Template = "vmath.vector3({0},{1},{2})"
		/// </summary>
		public extern vector3(double x, double y, double z);


		/// <summary>
		///     @CSharpLua.Template = "{0} + {1}"
		/// </summary>
		public static extern vector3 operator +(vector3 a, vector3 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} - {1}"
		/// </summary>
		public static extern vector3 operator -(vector3 a, vector3 b);


		/// <summary>
		///     @CSharpLua.Template = "-{0}"
		/// </summary>
		public static extern vector3 neg(vector3 a);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector3 operator *(vector3 a, double b);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector3 operator *(double a, vector3 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector3 operator *(vector3 a, vector3 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} / {1}"
		/// </summary>
		public static extern vector3 operator /(vector3 a, double b);


		/// <summary>
		///     @CSharpLua.Template = "vmath.length({this})"
		/// </summary>
		public extern double Magnitude();


		/// <summary>
		///     @CSharpLua.Template = "vmath.length_sqr({this})"
		/// </summary>
		public extern double MagnitudeSqr();


		/// <summary>
		///     @CSharpLua.Template = "vmath.mul_per_elem({this},{0})"
		/// </summary>
		public extern vector3 MultiplyByElement(vector3 other);


		/// <summary>
		///     @CSharpLua.Template = "vmath.normalize({this})"
		/// </summary>
		public extern vector3 Normalize();


		/// <summary>
		///     @CSharpLua.Template = "vmath.project({this},{0})"
		/// </summary>
		public extern double Project(vector3 v);


		/// <summary>
		///     @CSharpLua.Template = "{this}"
		/// </summary>
		public extern vector2 Tovector2();
	}
}
