using System;
using types;

/// <summary>
/// Collision object physics API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class physics
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.raycast_async({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void raycast_async(Vector3 from_p1, Vector3 to_p2, ILuaTable groups_p3, double request_id_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.raycast({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern ILuaTable raycast(Vector3 from_p1, Vector3 to_p2, ILuaTable groups_p3, ILuaTable options_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(string collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(string collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Hash collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Hash collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Url collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Url collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(string collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(string collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Hash collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Hash collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Url collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Url collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(string collisionobject_p1, string joint_id_p2, ILuaTable properties_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(string collisionobject_p1, Hash joint_id_p2, ILuaTable properties_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Hash collisionobject_p1, string joint_id_p2, ILuaTable properties_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Hash collisionobject_p1, Hash joint_id_p2, ILuaTable properties_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Url collisionobject_p1, string joint_id_p2, ILuaTable properties_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Url collisionobject_p1, Hash joint_id_p2, ILuaTable properties_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(string collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(string collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Hash collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Hash collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Url collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Url collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(string collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(string collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Hash collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Hash collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Url collisionobject_p1, string joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Url collisionobject_p1, Hash joint_id_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_gravity({0})"
	/// </summary>
	public static extern void set_gravity(Vector3 gravity_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_gravity()"
	/// </summary>
	public static extern Vector3 get_gravity();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(string url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Hash url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Url url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(string url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Hash url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Url url_p1, bool flip_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.wakeup({0})"
	/// </summary>
	public static extern void wakeup(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.wakeup({0})"
	/// </summary>
	public static extern void wakeup(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.wakeup({0})"
	/// </summary>
	public static extern void wakeup(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_group({0}, {1})"
	/// </summary>
	public static extern void set_group(string url_p1, string group_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_group({0}, {1})"
	/// </summary>
	public static extern void set_group(Hash url_p1, string group_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_group({0}, {1})"
	/// </summary>
	public static extern void set_group(Url url_p1, string group_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_group({0})"
	/// </summary>
	public static extern Hash get_group(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_group({0})"
	/// </summary>
	public static extern Hash get_group(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_group({0})"
	/// </summary>
	public static extern Hash get_group(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_maskbit({0}, {1}, {2})"
	/// </summary>
	public static extern void set_maskbit(string url_p1, string group_p2, bool maskbit_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_maskbit({0}, {1}, {2})"
	/// </summary>
	public static extern void set_maskbit(Hash url_p1, string group_p2, bool maskbit_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.set_maskbit({0}, {1}, {2})"
	/// </summary>
	public static extern void set_maskbit(Url url_p1, string group_p2, bool maskbit_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_maskbit({0}, {1})"
	/// </summary>
	public static extern bool get_maskbit(string url_p1, string group_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_maskbit({0}, {1})"
	/// </summary>
	public static extern bool get_maskbit(Hash url_p1, string group_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "physics.get_maskbit({0}, {1})"
	/// </summary>
	public static extern bool get_maskbit(Url url_p1, string group_p2);
		
		
}