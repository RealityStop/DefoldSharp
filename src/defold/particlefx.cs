using System;
using lua;
using types;

/// <summary>
/// Particle effects API documentation
/// 
/// </summary>
public static class Particlefx
{
	#region Defold API
	/// <summary>
	/// Starts playing a particle FX component.
	/// Particle FX started this way need to be manually stopped through <code>particlefx.stop()</code>.
	/// Which particle FX to play is identified by the URL.
	/// <span class="icon-attention"></span> A particle FX will continue to emit particles even if the game object the particle FX component belonged to is deleted. You can call <code>particlefx.stop()</code> to stop it from emitting more particles.
	/// 
	/// @CSharpLua.Template = "particlefx.play({0})"
	/// </summary>
	public static extern void play(string url_p1);


	/// <summary>
	/// Starts playing a particle FX component.
	/// Particle FX started this way need to be manually stopped through <code>particlefx.stop()</code>.
	/// Which particle FX to play is identified by the URL.
	/// <span class="icon-attention"></span> A particle FX will continue to emit particles even if the game object the particle FX component belonged to is deleted. You can call <code>particlefx.stop()</code> to stop it from emitting more particles.
	/// 
	/// @CSharpLua.Template = "particlefx.play({0}, {1})"
	/// </summary>
	public static extern void play(string url_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);


	/// <summary>
	/// Starts playing a particle FX component.
	/// Particle FX started this way need to be manually stopped through <code>particlefx.stop()</code>.
	/// Which particle FX to play is identified by the URL.
	/// <span class="icon-attention"></span> A particle FX will continue to emit particles even if the game object the particle FX component belonged to is deleted. You can call <code>particlefx.stop()</code> to stop it from emitting more particles.
	/// 
	/// @CSharpLua.Template = "particlefx.play({0})"
	/// </summary>
	public static extern void play(Hash url_p1);


	/// <summary>
	/// Starts playing a particle FX component.
	/// Particle FX started this way need to be manually stopped through <code>particlefx.stop()</code>.
	/// Which particle FX to play is identified by the URL.
	/// <span class="icon-attention"></span> A particle FX will continue to emit particles even if the game object the particle FX component belonged to is deleted. You can call <code>particlefx.stop()</code> to stop it from emitting more particles.
	/// 
	/// @CSharpLua.Template = "particlefx.play({0}, {1})"
	/// </summary>
	public static extern void play(Hash url_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);


	/// <summary>
	/// Starts playing a particle FX component.
	/// Particle FX started this way need to be manually stopped through <code>particlefx.stop()</code>.
	/// Which particle FX to play is identified by the URL.
	/// <span class="icon-attention"></span> A particle FX will continue to emit particles even if the game object the particle FX component belonged to is deleted. You can call <code>particlefx.stop()</code> to stop it from emitting more particles.
	/// 
	/// @CSharpLua.Template = "particlefx.play({0})"
	/// </summary>
	public static extern void play(Url url_p1);


	/// <summary>
	/// Starts playing a particle FX component.
	/// Particle FX started this way need to be manually stopped through <code>particlefx.stop()</code>.
	/// Which particle FX to play is identified by the URL.
	/// <span class="icon-attention"></span> A particle FX will continue to emit particles even if the game object the particle FX component belonged to is deleted. You can call <code>particlefx.stop()</code> to stop it from emitting more particles.
	/// 
	/// @CSharpLua.Template = "particlefx.play({0}, {1})"
	/// </summary>
	public static extern void play(Url url_p1, Action<object,Hash,Hash,ParticleEmitterState> emitter_state_function_p2);


	/// <summary>
	/// Stops a particle FX component from playing.
	/// Stopping a particle FX does not remove already spawned particles.
	/// Which particle FX to stop is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.stop({0}, {1})"
	/// </summary>
	public static extern void stop(string url_p1, LuaTable options_p2);


	/// <summary>
	/// Stops a particle FX component from playing.
	/// Stopping a particle FX does not remove already spawned particles.
	/// Which particle FX to stop is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.stop({0}, {1})"
	/// </summary>
	public static extern void stop(Hash url_p1, LuaTable options_p2);


	/// <summary>
	/// Stops a particle FX component from playing.
	/// Stopping a particle FX does not remove already spawned particles.
	/// Which particle FX to stop is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.stop({0}, {1})"
	/// </summary>
	public static extern void stop(Url url_p1, LuaTable options_p2);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, string emitter_p2, string constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, string emitter_p2, Hash constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, Hash emitter_p2, string constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(string url_p1, Hash emitter_p2, Hash constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, string emitter_p2, string constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, string emitter_p2, Hash constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, Hash emitter_p2, string constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Hash url_p1, Hash emitter_p2, Hash constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, string emitter_p2, string constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, string emitter_p2, Hash constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, Hash emitter_p2, string constant_p3, Vector4 value_p4);


	/// <summary>
	/// Sets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Setting a constant through this function will override the value set for that constant in the material.
	/// The value will be overridden until particlefx.reset_constant is called.
	/// Which particle FX to set a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.set_constant({0}, {1}, {2}, {3})"
	/// </summary>
	public static extern void set_constant(Url url_p1, Hash emitter_p2, Hash constant_p3, Vector4 value_p4);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, string emitter_p2, string constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, string emitter_p2, Hash constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, Hash emitter_p2, string constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(string url_p1, Hash emitter_p2, Hash constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, string emitter_p2, string constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, string emitter_p2, Hash constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, Hash emitter_p2, string constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Hash url_p1, Hash emitter_p2, Hash constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, string emitter_p2, string constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, string emitter_p2, Hash constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, Hash emitter_p2, string constant_p3);


	/// <summary>
	/// Resets a shader constant for a particle FX component emitter.
	/// The constant must be defined in the material assigned to the emitter.
	/// Resetting a constant through this function implies that the value defined in the material will be used.
	/// Which particle FX to reset a constant for is identified by the URL.
	/// 
	/// @CSharpLua.Template = "particlefx.reset_constant({0}, {1}, {2})"
	/// </summary>
	public static extern void reset_constant(Url url_p1, Hash emitter_p2, Hash constant_p3);


	#endregion Defold API
}