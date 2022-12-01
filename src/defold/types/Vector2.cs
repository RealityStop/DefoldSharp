using System;
using lua;

namespace types
{
	/// <summary>
	/// </summary>
	public class vector2 : ILuaType
	{
		public double x, y;


		/// <summary>
		///     @CSharpLua.Template = "vmath.vector3()"
		/// </summary>
		public extern vector2();


		/// <summary>
		///     @CSharpLua.Template = "vmath.vector3({0},{1},0)"
		/// </summary>
		public extern vector2(double x, double y);


		/// <summary>
		///     @CSharpLua.Template = "{0} + {1}"
		/// </summary>
		public static extern vector2 operator +(vector2 a, vector2 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} - {1}"
		/// </summary>
		public static extern vector2 operator -(vector2 a, vector2 b);


		/// <summary>
		///     @CSharpLua.Template = "-{0}"
		/// </summary>
		public static extern vector2 neg(vector2 a);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector2 operator *(vector2 a, double b);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector2 operator *(double a, vector2 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector2 operator *(vector2 a, vector2 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} / {1}"
		/// </summary>
		public static extern vector2 operator /(vector2 a, double b);


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
		public extern double Project(vector2 v);


		/// <summary>
		///     @CSharpLua.Template = "vmath.project({this},{0})"
		/// </summary>
		public extern double Project(vector3 v);


		/// <summary>
		///     @CSharpLua.Template = "{0}"
		/// </summary>
		public static implicit operator vector3(vector2 v)
		{
		   return default;
		}
	}
}
