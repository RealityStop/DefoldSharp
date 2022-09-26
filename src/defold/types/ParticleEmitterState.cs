using System;
using defold.types;

namespace defold.types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public enum ParticleEmitterState
	{
		EMITTER_STATE_SLEEPING = 0,
		EMITTER_STATE_PRESPAWN = 1,
		EMITTER_STATE_SPAWNING = 2,
		EMITTER_STATE_POSTSPAWN = 3,
	}
}
