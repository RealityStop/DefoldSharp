namespace types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class Vector4
	{
		public float x, y, u, v;


/// <summary>
/// @CSharpLua.Template = "vmath.vector4()"
/// </summary>
public extern Vector4();

/// <summary>
/// @CSharpLua.Template = "vmath.vector4({0},{1},{2},{3})"
/// </summary>
public extern Vector4(float x, float y, float u, float v);


/// <summary>
/// @CSharpLua.Template = "{0} + {1}"
/// </summary>
public static extern Vector4 operator +(Vector4 a, Vector4 b);


/// <summary>
/// @CSharpLua.Template = "{0} - {1}"
/// </summary>
public static extern Vector4 operator -(Vector4 a, Vector4 b);

/// <summary>
/// @CSharpLua.Template = "-{0}"
/// </summary>
public static extern Vector4 neg(Vector4 a);


/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Vector4 operator *(Vector4 a, float b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Vector4 operator *(float a, Vector4 b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Vector4 operator *(Vector4 a, Vector4 b);


/// <summary>
/// @CSharpLua.Template = "{0} / {1}"
/// </summary>
public static extern Vector4 operator /(Vector4 a, float b);

/// <summary>
/// @CSharpLua.Template = "vmath.length({this})"
/// </summary>
public static extern float Magnitude();


/// <summary>
/// @CSharpLua.Template = "vmath.mul_per_elem({this},{0})"
/// </summary>
public extern Vector4 MultiplyByElement(Vector4 other);


/// <summary>
/// @CSharpLua.Template = "vmath.normalize({this})"
/// </summary>
public extern Vector4 Normalize();
	}
}
