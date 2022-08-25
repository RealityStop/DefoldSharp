using src2.defold.types;

namespace src2.defold
{
	/// <summary>
	///     Functions, core hooks, messages and constants for manipulation of
	/// game objects. The "go" namespace is accessible from game object script
	/// files.
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class go
	{
		//TODO: animate
		//TODO: cancel_animations
		
		

		/// <summary>
		///  @CSharpLua.Template = "go.delete()"
		/// </summary>
		public static extern void delete();
		
		/// <summary>
		///   @CSharpLua.Template = "go.delete({0},{1})"
		/// </summary>
		/// <param name="id"></param>
		/// <param name="recursive"></param>
		public static extern void delete(HashOrStringOrUrl id, bool recursive = false);
		//TODO: Table version
		
		
		//TODO: get


		/// <summary>
		///   @CSharpLua.Template = "go.get_id()"
		/// </summary>
		/// <returns></returns>
		public static extern Hash get_id();
		
		/// <summary>
		///   @CSharpLua.Template = "go.get_id({0})"
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static extern Hash get_id(string path);
		
		
		///  <summary>
		/// 	go.get_position([id])
		/// 
		///  The position is relative the parent (if any). Use go.get_world_position to retrieve the global world position.
		///  
		///  @CSharpLua.Template = "go.get_position()"
		///  </summary>
		///  <param name="id">optional id of the game object instance to get the position for, by default the instance of the calling script</param>
		///  <returns></returns>
		public static extern Vector3 get_position();
		/// <summary>
		///  @CSharpLua.Template = "go.get_position({0})"
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static extern Vector3 get_position(HashOrStringOrUrl id);
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_position({0})"
		/// </summary>
		/// <param name="pos"></param>
		public static extern void set_position(Vector3 pos);
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_position({0}, {1})"
		/// </summary>
		/// <param name="hash"></param>
		/// <param name="pos"></param>
		public static extern void set_position(HashOrStringOrUrl id, Vector3 pos);
		

		/// <summary>
		///  @CSharpLua.Template = "go.get_scale()"
		/// </summary>
		public static extern Vector3 get_scale();
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_scale({0})"
		/// </summary>
		public static extern Vector3 get_scale(HashOrStringOrUrl id);


		/// <summary>
		///  @CSharpLua.Template = "go.get_scale_uniform()"
		/// </summary>
		public static extern float get_scale_uniform();
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_scale_uniform({0})"
		/// </summary>
		public static extern float get_scale_uniform(HashOrStringOrUrl id);
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_scale_uniform()"
		/// </summary>
		public static extern Hash get_parent();
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_scale_uniform({0})"
		/// </summary>
		public static extern Hash get_parent(HashOrStringOrUrl id);
		
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_position()"
		/// </summary>
		public static extern Vector3 get_world_position();
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_position({0})"
		/// </summary>
		public static extern Vector3 get_world_position(HashOrStringOrUrl id);
	
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_position()"
		/// </summary>
		public static extern Quaternion get_world_rotation();
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_position({0})"
		/// </summary>
		public static extern Quaternion get_world_rotation(HashOrStringOrUrl id);

		
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_scale()"
		/// </summary>
		public static extern Vector3 get_world_scale();
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_scale({0})"
		/// </summary>
		public static extern Vector3 get_world_scale(HashOrStringOrUrl id);
		
		
		
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_scale_uniform()"
		/// </summary>
		public static extern float get_world_scale_uniform();
		
		/// <summary>
		///  @CSharpLua.Template = "go.get_world_scale_uniform({0})"
		/// </summary>
		public static extern float get_world_scale_uniform(HashOrStringOrUrl id);
		
		
		//TODO:get_world_transform
		//TODO:set
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_parent()"
		/// </summary>
		public static extern void set_parent();
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_parent({0})"
		/// </summary>
		public static extern void set_parent(HashOrStringOrUrl id);
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_parent({0},{1})"
		/// </summary>
		public static extern void set_parent(HashOrStringOrUrl id, HashOrStringOrUrl parent_id);
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_parent({0},{1},{2})"
		/// </summary>
		public static extern void set_parent(HashOrStringOrUrl id, HashOrStringOrUrl parent_id, bool keep_world_transform);

		
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_rotation({0})"
		/// </summary>
		public static extern void set_rotation(Quaternion rotation);
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_rotation({0},{1})"
		/// </summary>
		public static extern void set_rotation(Quaternion rotation, HashOrStringOrUrl id);

		
				
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_scale({0})"
		/// </summary>
		public static extern void set_scale(float scale);
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_scale({0})"
		/// </summary>
		public static extern void set_scale(Vector3 scale);
		

		
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_scale({0},{1})"
		/// </summary>
		public static extern void set_scale(float scale, HashOrStringOrUrl id);
		
		
		/// <summary>
		///  @CSharpLua.Template = "go.set_scale({0},{1})"
		/// </summary>
		public static extern void set_scale(Vector3 scale, HashOrStringOrUrl id);
		
	}
}