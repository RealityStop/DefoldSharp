namespace src2.defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class Vector3
	{
		public float x, y, z;
	
		/// <summary>
		/// @CSharpLua.Template = "vmath.vector3({0},{1},{2})"
		/// </summary>
		public extern Vector3(float x, float y, float z);


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
		public static extern Vector3 operator *(Vector3 a, float b);
	
		/// <summary>
		/// @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern Vector3 operator *(float a, Vector3 b);
	
		/// <summary>
		/// @CSharpLua.Template = "{0} * {1}"
		/// </summary>
		public static extern Vector3 operator *(Vector3 a, Vector3 b);

	
		/// <summary>
		/// @CSharpLua.Template = "{0} / {1}"
		/// </summary>
		public static extern Vector3 operator /(Vector3 a, float b);


		/// <summary>
		/// @CSharpLua.Template = "vmath.length({this})"
		/// </summary>
		public static extern float Magnitude();
		
		
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
		public extern float Project(Vector3 v);
		
		
		/// <summary>
		/// @CSharpLua.Template = "{this}"
		/// </summary>
		public extern Vector2 ToVector2();
	}
}