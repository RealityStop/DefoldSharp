using System;
using types;

/// <summary>
/// Particle effects API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class particlefx
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.play({0}, {1})"
	/// </summary>
	public static extern void play(string url_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.play({0}, {1})"
	/// </summary>
	public static extern void play(Hash url_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.play({0}, {1})"
	/// </summary>
	public static extern void play(Url url_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.stop({0}, {1})"
	/// </summary>
	public static extern void stop(string url_p1, ILuaTable options_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.stop({0}, {1})"
	/// </summary>
	public static extern void stop(Hash url_p1, ILuaTable options_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.stop({0}, {1})"
	/// </summary>
	public static extern void stop(Url url_p1, ILuaTable options_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, string emitter_p2, string constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, string emitter_p2, Hash constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, Hash emitter_p2, string constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, Hash emitter_p2, Hash constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, string emitter_p2, string constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, string emitter_p2, Hash constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, Hash emitter_p2, string constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, Hash emitter_p2, Hash constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, string emitter_p2, string constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, string emitter_p2, Hash constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, Hash emitter_p2, string constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, Hash emitter_p2, Hash constant_p3, Vector4 value_p4);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, string emitter_p2, string constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, string emitter_p2, Hash constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, Hash emitter_p2, string constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, Hash emitter_p2, Hash constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, string emitter_p2, string constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, string emitter_p2, Hash constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, Hash emitter_p2, string constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, Hash emitter_p2, Hash constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, string emitter_p2, string constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, string emitter_p2, Hash constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, Hash emitter_p2, string constant_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, Hash emitter_p2, Hash constant_p3);
		
		
}