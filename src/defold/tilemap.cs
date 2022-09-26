using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Tilemap API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class tilemap
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
		/// </summary>
		public static extern void set_tile(string url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
		/// </summary>
		public static extern void set_tile(string url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
		/// </summary>
		public static extern void set_tile(Hash url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
		/// </summary>
		public static extern void set_tile(Hash url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
		/// </summary>
		public static extern void set_tile(Url url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
		/// </summary>
		public static extern void set_tile(Url url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern double get_tile(string url_p1, string layer_p2, double x_p3, double y_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern double get_tile(string url_p1, Hash layer_p2, double x_p3, double y_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern double get_tile(Hash url_p1, string layer_p2, double x_p3, double y_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern double get_tile(Hash url_p1, Hash layer_p2, double x_p3, double y_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern double get_tile(Url url_p1, string layer_p2, double x_p3, double y_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
		/// </summary>
		public static extern double get_tile(Url url_p1, Hash layer_p2, double x_p3, double y_p4);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_bounds({0})"
		/// </summary>
		public static extern double get_bounds(string url_p1, out double y_o1, out double w_o2, out double h_o3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_bounds({0})"
		/// </summary>
		public static extern double get_bounds(Hash url_p1, out double y_o1, out double w_o2, out double h_o3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.get_bounds({0})"
		/// </summary>
		public static extern double get_bounds(Url url_p1, out double y_o1, out double w_o2, out double h_o3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
		/// </summary>
		public static extern void set_visible(string url_p1, string layer_p2, bool visible_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
		/// </summary>
		public static extern void set_visible(string url_p1, Hash layer_p2, bool visible_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
		/// </summary>
		public static extern void set_visible(Hash url_p1, string layer_p2, bool visible_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
		/// </summary>
		public static extern void set_visible(Hash url_p1, Hash layer_p2, bool visible_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
		/// </summary>
		public static extern void set_visible(Url url_p1, string layer_p2, bool visible_p3);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
		/// </summary>
		public static extern void set_visible(Url url_p1, Hash layer_p2, bool visible_p3);
		
		
	}
}
