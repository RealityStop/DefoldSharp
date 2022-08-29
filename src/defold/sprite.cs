using src2.defold.types;

namespace src2.defold
{
	public static class Sprite
	{
		//TODO:  play_flipbook  -- this is pending, because we don't have
		// support for custom callbacks in .script generation yet.


		/// <summary>
		/// @CSharpLua.Template = "sprite.reset_constant({0},{1})"
		/// </summary>
		public static extern void reset_constant(UrlOrString url, HashOrString name);


		/// <summary>
		/// @CSharpLua.Template = "sprite.set_constant({0},{1},{2})"
		/// </summary>
		public static extern void set_constant(UrlOrString url, HashOrString name, Vector4 value);


		/// <summary>
		/// @CSharpLua.Template = "sprite.set_hflip({0},{1})"
		/// </summary>
		public static extern void set_hflip(UrlOrString url, bool flip);


		/// <summary>
		/// @CSharpLua.Template = "sprite.set_vflip({0},{1})"
		/// </summary>
		public static extern void set_vflip(UrlOrString url, bool flip);


		/// <summary>
		/// msg.post("{0}, "play_animation", {id = {1} })
		/// </summary>
		public static extern void play_animation(HashOrStringOrUrl target, Hash targetAnimationID);
		
		


		public class Animation_DoneMessage : StandardMessageImplementation
		{
			private static Hash _CODE_ = new Hash("animation_done");
			public override Hash Code => _CODE_;

			/// <summary>
			/// The current tile of the sprite
			/// </summary>
			public int current_tile = 0;

			/// <summary>
			/// ID of the animation that was completed
			/// </summary>
			public Hash id = null;
		}

		public class Play_AnimationMessage : StandardMessageImplementation
		{
			private static Hash _CODE_ = new Hash("play_animation");
			public override Hash Code => _CODE_;

			/// <summary>
			/// The id of the animation to play.
			/// </summary>
			public Hash id = null;
		}

		public class Play_FlipbookMessage : StandardMessageImplementation
		{
			private static Hash _CODE_ = new Hash("play_flipbook");
			public override Hash Code => _CODE_;

			/// <summary>
			/// the normalized initial value of the animation cursor when the animation starts playing.
			/// </summary>
			public float offset = 0;

			/// <summary>
			/// the rate with which the animation will be played. Must be positive.
			/// </summary>
			public float playback_rate = 0;
		}
	}
}