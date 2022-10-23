using System;

namespace types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class Vector2
	{
		public float x, y;


/// <summary>
/// @CSharpLua.Template = "vmath.vector3()"
/// </summary>
public extern Vector2();

/// <summary>
/// @CSharpLua.Template = "vmath.vector3({0},{1},0)"
/// </summary>
public extern Vector2(float x, float y);


/// <summary>
/// @CSharpLua.Template = "{0} + {1}"
/// </summary>
public static extern Vector2 operator +(Vector2 a, Vector2 b);


/// <summary>
/// @CSharpLua.Template = "{0} - {1}"
/// </summary>
public static extern Vector2 operator -(Vector2 a, Vector2 b);

/// <summary>
/// @CSharpLua.Template = "-{0}"
/// </summary>
public static extern Vector2 neg(Vector2 a);


/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Vector2 operator *(Vector2 a, float b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Vector2 operator *(float a, Vector2 b);

/// <summary>
/// @CSharpLua.Template = "{0} * {1}"
/// </summary>
public static extern Vector2 operator *(Vector2 a, Vector2 b);


/// <summary>
/// @CSharpLua.Template = "{0} / {1}"
/// </summary>
public static extern Vector2 operator /(Vector2 a, float b);


/// <summary>
/// @CSharpLua.Template = "vmath.length({this})"
/// </summary>
public extern float Magnitude();


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
public extern float Project(Vector2 v);
/// <summary>
/// @CSharpLua.Template = "vmath.project({this},{0})"
/// </summary>
public extern float Project(Vector3 v);


/// <summary>
/// @CSharpLua.Template = "{0}"
/// </summary>
public static implicit operator Vector3(Vector2 v)
{
   return default;
}
	}
}
