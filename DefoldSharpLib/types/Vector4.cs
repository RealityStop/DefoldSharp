namespace DefoldSharp
{
	/// <summary>
	/// </summary>
	public class vector4 : ILuaType
	{
		public double x, y, u, v;


		/// <summary>
		///     @CSharpLua.Template = "vmath.vector4()"
		/// </summary>
		public extern vector4();


		/// <summary>
		///     @CSharpLua.Template = "vmath.vector4({0},{1},{2},{3})"
		/// </summary>
		public extern vector4(double x, double y, double u, double v);


		/// <summary>
		///     @CSharpLua.Template = "{0} + {1}"
		/// </summary>
		public static extern vector4 operator +(vector4 a, vector4 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} - {1}"
		/// </summary>
		public static extern vector4 operator -(vector4 a, vector4 b);


		/// <summary>
		///     @CSharpLua.Template = "-{0}"
		/// </summary>
		public static extern vector4 neg(vector4 a);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector4 operator *(vector4 a, double b);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector4 operator *(double a, vector4 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern vector4 operator *(vector4 a, vector4 b);


		/// <summary>
		///     @CSharpLua.Template = "{0} / {1}"
		/// </summary>
		public static extern vector4 operator /(vector4 a, double b);


		/// <summary>
		///     @CSharpLua.Template = "vmath.length({this})"
		/// </summary>
		public static extern double Magnitude();


		/// <summary>
		///     @CSharpLua.Template = "vmath.length_sqr({this})"
		/// </summary>
		public extern double MagnitudeSqr();


		/// <summary>
		///     @CSharpLua.Template = "vmath.mul_per_elem({this},{0})"
		/// </summary>
		public extern vector4 MultiplyByElement(vector4 other);


		/// <summary>
		///     @CSharpLua.Template = "vmath.normalize({this})"
		/// </summary>
		public extern vector4 Normalize();
	}
}
