using System;
using types;

/// <summary>
/// Model API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class model
{
	/// <summary>
	/// Cancels all animation on a model component.
	/// 
	/// @CSharpLua.Template = "model.cancel({0})"
	/// </summary>
	public static extern void cancel(string url_p1);
	
	
	/// <summary>
	/// Cancels all animation on a model component.
	/// 
	/// @CSharpLua.Template = "model.cancel({0})"
	/// </summary>
	public static extern void cancel(Hash url_p1);
	
	
	/// <summary>
	/// Cancels all animation on a model component.
	/// 
	/// @CSharpLua.Template = "model.cancel({0})"
	/// </summary>
	public static extern void cancel(Url url_p1);
	
	
	/// <summary>
	/// Gets the id of the game object that corresponds to a model skeleton bone.
	/// The returned game object can be used for parenting and transform queries.
	/// This function has complexity <code>O(n)</code>, where <code>n</code> is the number of bones in the model skeleton.
	/// Game objects corresponding to a model skeleton bone can not be individually deleted.
	/// 
	/// @CSharpLua.Template = "model.get_go({0}, {1})"
	/// </summary>
	public static extern Hash get_go(string url_p1, string bone_id_p2);
	
	
	/// <summary>
	/// Gets the id of the game object that corresponds to a model skeleton bone.
	/// The returned game object can be used for parenting and transform queries.
	/// This function has complexity <code>O(n)</code>, where <code>n</code> is the number of bones in the model skeleton.
	/// Game objects corresponding to a model skeleton bone can not be individually deleted.
	/// 
	/// @CSharpLua.Template = "model.get_go({0}, {1})"
	/// </summary>
	public static extern Hash get_go(string url_p1, Hash bone_id_p2);
	
	
	/// <summary>
	/// Gets the id of the game object that corresponds to a model skeleton bone.
	/// The returned game object can be used for parenting and transform queries.
	/// This function has complexity <code>O(n)</code>, where <code>n</code> is the number of bones in the model skeleton.
	/// Game objects corresponding to a model skeleton bone can not be individually deleted.
	/// 
	/// @CSharpLua.Template = "model.get_go({0}, {1})"
	/// </summary>
	public static extern Hash get_go(Hash url_p1, string bone_id_p2);
	
	
	/// <summary>
	/// Gets the id of the game object that corresponds to a model skeleton bone.
	/// The returned game object can be used for parenting and transform queries.
	/// This function has complexity <code>O(n)</code>, where <code>n</code> is the number of bones in the model skeleton.
	/// Game objects corresponding to a model skeleton bone can not be individually deleted.
	/// 
	/// @CSharpLua.Template = "model.get_go({0}, {1})"
	/// </summary>
	public static extern Hash get_go(Hash url_p1, Hash bone_id_p2);
	
	
	/// <summary>
	/// Gets the id of the game object that corresponds to a model skeleton bone.
	/// The returned game object can be used for parenting and transform queries.
	/// This function has complexity <code>O(n)</code>, where <code>n</code> is the number of bones in the model skeleton.
	/// Game objects corresponding to a model skeleton bone can not be individually deleted.
	/// 
	/// @CSharpLua.Template = "model.get_go({0}, {1})"
	/// </summary>
	public static extern Hash get_go(Url url_p1, string bone_id_p2);
	
	
	/// <summary>
	/// Gets the id of the game object that corresponds to a model skeleton bone.
	/// The returned game object can be used for parenting and transform queries.
	/// This function has complexity <code>O(n)</code>, where <code>n</code> is the number of bones in the model skeleton.
	/// Game objects corresponding to a model skeleton bone can not be individually deleted.
	/// 
	/// @CSharpLua.Template = "model.get_go({0}, {1})"
	/// </summary>
	public static extern Hash get_go(Url url_p1, Hash bone_id_p2);
	
	
}
