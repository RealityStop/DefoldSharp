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
	/// @CSharpLua.Ignore
	/// </summary>
	public class apply_force_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("apply_force");
		public Vector3 force;
		public Vector3 position;
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class collision_response_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("collision_response");
		public Hash other_id;
		public Vector3 other_position;
		public Hash other_group;
		public Hash own_group;
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class contact_point_response_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("contact_point_response");
		public Vector3 position;
		public Vector3 normal;
		public Vector3 relative_velocity;
		public double distance;
		public double applied_impulse;
		public double life_time;
		public double mass;
		public double other_mass;
		public Hash other_id;
		public Vector3 other_position;
		public Hash other_group;
		public Hash own_group;
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class trigger_response_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("trigger_response");
		public Hash other_id;
		public bool enter;
		public Hash other_group;
		public Hash own_group;
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class ray_cast_response_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("ray_cast_response");
		public double fraction;
		public Vector3 position;
		public Vector3 normal;
		public Hash id;
		public Hash group;
		public double request_id;
	}
	
	
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class ray_cast_missed_message : StandardMessageImplementation
	{
		public override Hash Code { get; } = Defold.hash("ray_cast_missed");
		public double request_id;
	}
	
	
	/// <summary>
	/// Ray casts are used to test for intersections against collision objects in the physics world.
	/// Collision objects of types kinematic, dynamic and static are tested against. Trigger objects
	/// do not intersect with ray casts.
	/// Which collision objects to hit is filtered by their collision groups and can be configured
	/// through <code>groups</code>.
	/// The actual ray cast will be performed during the physics-update.
	/// <ul>
	/// <li>If an object is hit, the result will be reported via a <code>ray_cast_response</code> message.</li>
	/// <li>If there is no object hit, the result will be reported via a <code>ray_cast_missed</code> message.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "physics.raycast_async({0}, {1}, {2})"
	/// </summary>
	public static extern void raycast_async(Vector3 from_p1, Vector3 to_p2, ILuaTable groups_p3);
	
	
	/// <summary>
	/// Ray casts are used to test for intersections against collision objects in the physics world.
	/// Collision objects of types kinematic, dynamic and static are tested against. Trigger objects
	/// do not intersect with ray casts.
	/// Which collision objects to hit is filtered by their collision groups and can be configured
	/// through <code>groups</code>.
	/// The actual ray cast will be performed during the physics-update.
	/// <ul>
	/// <li>If an object is hit, the result will be reported via a <code>ray_cast_response</code> message.</li>
	/// <li>If there is no object hit, the result will be reported via a <code>ray_cast_missed</code> message.</li>
	/// </ul>
	/// 
	/// @CSharpLua.Template = "physics.raycast_async({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void raycast_async(Vector3 from_p1, Vector3 to_p2, ILuaTable groups_p3, double request_id_p4);
	
	
	/// <summary>
	/// Ray casts are used to test for intersections against collision objects in the physics world.
	/// Collision objects of types kinematic, dynamic and static are tested against. Trigger objects
	/// do not intersect with ray casts.
	/// Which collision objects to hit is filtered by their collision groups and can be configured
	/// through <code>groups</code>.
	/// 
	/// @CSharpLua.Template = "physics.raycast({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern ILuaTable raycast(Vector3 from_p1, Vector3 to_p2, ILuaTable groups_p3, ILuaTable options_p4);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, string collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Hash collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, string joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, string collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Hash collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6);
	
	
	/// <summary>
	/// Create a physics joint between two collision object components.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.create_joint({0}, {1}, {2}, {3}, {4}, {5}, {6})"
	/// </summary>
	public static extern void create_joint(double joint_type_p1, Url collisionobject_a_p2, Hash joint_id_p3, Vector3 position_a_p4, Url collisionobject_b_p5, Vector3 position_b_p6, ILuaTable properties_p7);
	
	
	/// <summary>
	/// Destroy an already physics joint. The joint has to be created before a
	/// destroy can be issued.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(string collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Destroy an already physics joint. The joint has to be created before a
	/// destroy can be issued.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(string collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Destroy an already physics joint. The joint has to be created before a
	/// destroy can be issued.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Hash collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Destroy an already physics joint. The joint has to be created before a
	/// destroy can be issued.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Hash collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Destroy an already physics joint. The joint has to be created before a
	/// destroy can be issued.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Url collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Destroy an already physics joint. The joint has to be created before a
	/// destroy can be issued.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.destroy_joint({0}, {1})"
	/// </summary>
	public static extern void destroy_joint(Url collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get a table for properties for a connected joint. The joint has to be created before
	/// properties can be retrieved.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(string collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get a table for properties for a connected joint. The joint has to be created before
	/// properties can be retrieved.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(string collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get a table for properties for a connected joint. The joint has to be created before
	/// properties can be retrieved.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Hash collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get a table for properties for a connected joint. The joint has to be created before
	/// properties can be retrieved.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Hash collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get a table for properties for a connected joint. The joint has to be created before
	/// properties can be retrieved.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Url collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get a table for properties for a connected joint. The joint has to be created before
	/// properties can be retrieved.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_properties({0}, {1})"
	/// </summary>
	public static extern ILuaTable get_joint_properties(Url collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Updates the properties for an already connected joint. The joint has to be created before
	/// properties can be changed.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(string collisionobject_p1, string joint_id_p2, ILuaTable properties_p3);
	
	
	/// <summary>
	/// Updates the properties for an already connected joint. The joint has to be created before
	/// properties can be changed.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(string collisionobject_p1, Hash joint_id_p2, ILuaTable properties_p3);
	
	
	/// <summary>
	/// Updates the properties for an already connected joint. The joint has to be created before
	/// properties can be changed.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Hash collisionobject_p1, string joint_id_p2, ILuaTable properties_p3);
	
	
	/// <summary>
	/// Updates the properties for an already connected joint. The joint has to be created before
	/// properties can be changed.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Hash collisionobject_p1, Hash joint_id_p2, ILuaTable properties_p3);
	
	
	/// <summary>
	/// Updates the properties for an already connected joint. The joint has to be created before
	/// properties can be changed.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Url collisionobject_p1, string joint_id_p2, ILuaTable properties_p3);
	
	
	/// <summary>
	/// Updates the properties for an already connected joint. The joint has to be created before
	/// properties can be changed.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.set_joint_properties({0}, {1}, {2})"
	/// </summary>
	public static extern void set_joint_properties(Url collisionobject_p1, Hash joint_id_p2, ILuaTable properties_p3);
	
	
	/// <summary>
	/// Get the reaction force for a joint. The joint has to be created before
	/// the reaction force can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(string collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction force for a joint. The joint has to be created before
	/// the reaction force can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(string collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction force for a joint. The joint has to be created before
	/// the reaction force can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Hash collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction force for a joint. The joint has to be created before
	/// the reaction force can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Hash collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction force for a joint. The joint has to be created before
	/// the reaction force can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Url collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction force for a joint. The joint has to be created before
	/// the reaction force can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_force({0}, {1})"
	/// </summary>
	public static extern Vector3 get_joint_reaction_force(Url collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction torque for a joint. The joint has to be created before
	/// the reaction torque can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(string collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction torque for a joint. The joint has to be created before
	/// the reaction torque can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(string collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction torque for a joint. The joint has to be created before
	/// the reaction torque can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Hash collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction torque for a joint. The joint has to be created before
	/// the reaction torque can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Hash collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction torque for a joint. The joint has to be created before
	/// the reaction torque can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Url collisionobject_p1, string joint_id_p2);
	
	
	/// <summary>
	/// Get the reaction torque for a joint. The joint has to be created before
	/// the reaction torque can be calculated.
	/// Note: Currently only supported in 2D physics.
	/// 
	/// @CSharpLua.Template = "physics.get_joint_reaction_torque({0}, {1})"
	/// </summary>
	public static extern double get_joint_reaction_torque(Url collisionobject_p1, Hash joint_id_p2);
	
	
	/// <summary>
	/// Set the gravity in runtime. The gravity change is not global, it will only affect
	/// the collection that the function is called from.
	/// Note: For 2D physics the z component of the gravity vector will be ignored.
	/// 
	/// @CSharpLua.Template = "physics.set_gravity({0})"
	/// </summary>
	public static extern void set_gravity(Vector3 gravity_p1);
	
	
	/// <summary>
	/// Get the gravity in runtime. The gravity returned is not global, it will return
	/// the gravity for the collection that the function is called from.
	/// Note: For 2D physics the z component will always be zero.
	/// 
	/// @CSharpLua.Template = "physics.get_gravity()"
	/// </summary>
	public static extern Vector3 get_gravity();
	
	
	/// <summary>
	/// Flips the collision shapes horizontally for a collision object
	/// 
	/// @CSharpLua.Template = "physics.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(string url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Flips the collision shapes horizontally for a collision object
	/// 
	/// @CSharpLua.Template = "physics.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Hash url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Flips the collision shapes horizontally for a collision object
	/// 
	/// @CSharpLua.Template = "physics.set_hflip({0}, {1})"
	/// </summary>
	public static extern void set_hflip(Url url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Flips the collision shapes vertically for a collision object
	/// 
	/// @CSharpLua.Template = "physics.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(string url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Flips the collision shapes vertically for a collision object
	/// 
	/// @CSharpLua.Template = "physics.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Hash url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Flips the collision shapes vertically for a collision object
	/// 
	/// @CSharpLua.Template = "physics.set_vflip({0}, {1})"
	/// </summary>
	public static extern void set_vflip(Url url_p1, bool flip_p2);
	
	
	/// <summary>
	/// Collision objects tend to fall asleep when inactive for a small period of time for
	/// efficiency reasons. This function wakes them up.
	/// 
	/// @CSharpLua.Template = "physics.wakeup({0})"
	/// </summary>
	public static extern void wakeup(string url_p1);
	
	
	/// <summary>
	/// Collision objects tend to fall asleep when inactive for a small period of time for
	/// efficiency reasons. This function wakes them up.
	/// 
	/// @CSharpLua.Template = "physics.wakeup({0})"
	/// </summary>
	public static extern void wakeup(Hash url_p1);
	
	
	/// <summary>
	/// Collision objects tend to fall asleep when inactive for a small period of time for
	/// efficiency reasons. This function wakes them up.
	/// 
	/// @CSharpLua.Template = "physics.wakeup({0})"
	/// </summary>
	public static extern void wakeup(Url url_p1);
	
	
	/// <summary>
	/// Updates the group property of a collision object to the specified
	/// string value. The group name should exist i.e. have been used in
	/// a collision object in the editor.
	/// 
	/// @CSharpLua.Template = "physics.set_group({0}, {1})"
	/// </summary>
	public static extern void set_group(string url_p1, string group_p2);
	
	
	/// <summary>
	/// Updates the group property of a collision object to the specified
	/// string value. The group name should exist i.e. have been used in
	/// a collision object in the editor.
	/// 
	/// @CSharpLua.Template = "physics.set_group({0}, {1})"
	/// </summary>
	public static extern void set_group(Hash url_p1, string group_p2);
	
	
	/// <summary>
	/// Updates the group property of a collision object to the specified
	/// string value. The group name should exist i.e. have been used in
	/// a collision object in the editor.
	/// 
	/// @CSharpLua.Template = "physics.set_group({0}, {1})"
	/// </summary>
	public static extern void set_group(Url url_p1, string group_p2);
	
	
	/// <summary>
	/// Returns the group name of a collision object as a hash.
	/// 
	/// @CSharpLua.Template = "physics.get_group({0})"
	/// </summary>
	public static extern Hash get_group(string url_p1);
	
	
	/// <summary>
	/// Returns the group name of a collision object as a hash.
	/// 
	/// @CSharpLua.Template = "physics.get_group({0})"
	/// </summary>
	public static extern Hash get_group(Hash url_p1);
	
	
	/// <summary>
	/// Returns the group name of a collision object as a hash.
	/// 
	/// @CSharpLua.Template = "physics.get_group({0})"
	/// </summary>
	public static extern Hash get_group(Url url_p1);
	
	
	/// <summary>
	/// Sets or clears the masking of a group (maskbit) in a collision object.
	/// 
	/// @CSharpLua.Template = "physics.set_maskbit({0}, {1}, {2})"
	/// </summary>
	public static extern void set_maskbit(string url_p1, string group_p2, bool maskbit_p3);
	
	
	/// <summary>
	/// Sets or clears the masking of a group (maskbit) in a collision object.
	/// 
	/// @CSharpLua.Template = "physics.set_maskbit({0}, {1}, {2})"
	/// </summary>
	public static extern void set_maskbit(Hash url_p1, string group_p2, bool maskbit_p3);
	
	
	/// <summary>
	/// Sets or clears the masking of a group (maskbit) in a collision object.
	/// 
	/// @CSharpLua.Template = "physics.set_maskbit({0}, {1}, {2})"
	/// </summary>
	public static extern void set_maskbit(Url url_p1, string group_p2, bool maskbit_p3);
	
	
	/// <summary>
	/// Returns true if the specified group is set in the mask of a collision
	/// object, false otherwise.
	/// 
	/// @CSharpLua.Template = "physics.get_maskbit({0}, {1})"
	/// </summary>
	public static extern bool get_maskbit(string url_p1, string group_p2);
	
	
	/// <summary>
	/// Returns true if the specified group is set in the mask of a collision
	/// object, false otherwise.
	/// 
	/// @CSharpLua.Template = "physics.get_maskbit({0}, {1})"
	/// </summary>
	public static extern bool get_maskbit(Hash url_p1, string group_p2);
	
	
	/// <summary>
	/// Returns true if the specified group is set in the mask of a collision
	/// object, false otherwise.
	/// 
	/// @CSharpLua.Template = "physics.get_maskbit({0}, {1})"
	/// </summary>
	public static extern bool get_maskbit(Url url_p1, string group_p2);
	
	
}
