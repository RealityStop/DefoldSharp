using System;
using lua;

namespace types
{
	/// <summary>
	/// </summary>
	public enum TilemapTransforms
	{
		H_FLIP = 1,
		V_FLIP = 2,
		ROTATE_90 = 4,
		ROTATE_180 = -3,
		ROTATE_270 = -7,
	}
}
