using System;
using lua;

namespace types
{
	/// <summary>
	/// </summary>
	public enum RenderState
	{
		STATE_DEPTH_TEST = 0,
		STATE_STENCIL_TEST = 2,
		STATE_ALPHA_TEST = 3,
		STATE_BLEND = 4,
		STATE_CULL_FACE = 5,
		STATE_POLYGON_OFFSET_FILL = 6,
	}
}
