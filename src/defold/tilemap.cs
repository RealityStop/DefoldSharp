using System;
using support;
using types;

/// <summary>
/// Tilemap API documentation
/// 
/// </summary>
public class Tilemap : BuiltInComponentBase
{
	#region Defold API
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public extern void set_tile(string url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public extern void set_tile(string url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public extern void set_tile(string url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public extern void set_tile(string url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public extern void set_tile(Hash url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public extern void set_tile(Hash url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public extern void set_tile(Hash url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public extern void set_tile(Hash url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public extern void set_tile(Url url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public extern void set_tile(Url url_p1, string layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public extern void set_tile(Url url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5);
	
	
	/// <summary>
	/// Replace a tile in a tile map with a new tile.
	/// The coordinates of the tiles are indexed so that the "first" tile just
	/// above and to the right of origin has coordinates 1,1.
	/// Tiles to the left of and below origin are indexed 0, -1, -2 and so forth.
	/// <pre>
	/// +-------+-------+------+------+
	/// |  0,3  |  1,3  | 2,3  | 3,3  |
	/// +-------+-------+------+------+
	/// |  0,2  |  1,2  | 2,2  | 3,2  |
	/// +-------+-------+------+------+
	/// |  0,1  |  1,1  | 2,1  | 3,1  |
	/// +-------O-------+------+------+
	/// |  0,0  |  1,0  | 2,0  | 3,0  |
	/// +-------+-------+------+------+
	/// </pre>
	/// The coordinates must be within the bounds of the tile map as it were created.
	/// That is, it is not possible to extend the size of a tile map by setting tiles outside the edges.
	/// To clear a tile, set the tile to number 0. Which tile map and layer to manipulate is identified by the URL and the layer name parameters.
	/// Transform bitmask is arithmetic sum of one or both FLIP constants (<code>tilemap.H_FLIP</code>, <code>tilemap.V_FLIP</code>) and/or one of ROTATION constants
	/// (<code>tilemap.ROTATE_90</code>, <code>tilemap.ROTATE_180</code>, <code>tilemap.ROTATE_270</code>).
	/// Flip always applies before rotation (clockwise).
	/// 
	/// @CSharpLua.Template = "tilemap.set_tile({0}, {1}, {2}, {3}, {4}, {5})"
	/// </summary>
	public extern void set_tile(Url url_p1, Hash layer_p2, double x_p3, double y_p4, double tile_p5, double transform_bitmask_p6);
	
	
	/// <summary>
	/// Get the tile set at the specified position in the tilemap.
	/// The position is identified by the tile index starting at origin
	/// with index 1, 1. (see <a href="/ref/tilemap#tilemap.set_tile()">tilemap.set_tile()</a>)
	/// Which tile map and layer to query is identified by the URL and the
	/// layer name parameters.
	/// 
	/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
	/// </summary>
	public extern double get_tile(string url_p1, string layer_p2, double x_p3, double y_p4);
	
	
	/// <summary>
	/// Get the tile set at the specified position in the tilemap.
	/// The position is identified by the tile index starting at origin
	/// with index 1, 1. (see <a href="/ref/tilemap#tilemap.set_tile()">tilemap.set_tile()</a>)
	/// Which tile map and layer to query is identified by the URL and the
	/// layer name parameters.
	/// 
	/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
	/// </summary>
	public extern double get_tile(string url_p1, Hash layer_p2, double x_p3, double y_p4);
	
	
	/// <summary>
	/// Get the tile set at the specified position in the tilemap.
	/// The position is identified by the tile index starting at origin
	/// with index 1, 1. (see <a href="/ref/tilemap#tilemap.set_tile()">tilemap.set_tile()</a>)
	/// Which tile map and layer to query is identified by the URL and the
	/// layer name parameters.
	/// 
	/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
	/// </summary>
	public extern double get_tile(Hash url_p1, string layer_p2, double x_p3, double y_p4);
	
	
	/// <summary>
	/// Get the tile set at the specified position in the tilemap.
	/// The position is identified by the tile index starting at origin
	/// with index 1, 1. (see <a href="/ref/tilemap#tilemap.set_tile()">tilemap.set_tile()</a>)
	/// Which tile map and layer to query is identified by the URL and the
	/// layer name parameters.
	/// 
	/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
	/// </summary>
	public extern double get_tile(Hash url_p1, Hash layer_p2, double x_p3, double y_p4);
	
	
	/// <summary>
	/// Get the tile set at the specified position in the tilemap.
	/// The position is identified by the tile index starting at origin
	/// with index 1, 1. (see <a href="/ref/tilemap#tilemap.set_tile()">tilemap.set_tile()</a>)
	/// Which tile map and layer to query is identified by the URL and the
	/// layer name parameters.
	/// 
	/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
	/// </summary>
	public extern double get_tile(Url url_p1, string layer_p2, double x_p3, double y_p4);
	
	
	/// <summary>
	/// Get the tile set at the specified position in the tilemap.
	/// The position is identified by the tile index starting at origin
	/// with index 1, 1. (see <a href="/ref/tilemap#tilemap.set_tile()">tilemap.set_tile()</a>)
	/// Which tile map and layer to query is identified by the URL and the
	/// layer name parameters.
	/// 
	/// @CSharpLua.Template = "tilemap.get_tile({0}, {1}, {2}, {3})"
	/// </summary>
	public extern double get_tile(Url url_p1, Hash layer_p2, double x_p3, double y_p4);
	
	
	/// <summary>
	/// Get the bounds for a tile map. This function returns multiple values:
	/// The lower left corner index x and y coordinates (1-indexed),
	/// the tile map width and the tile map height.
	/// The resulting values take all tile map layers into account, meaning that
	/// the bounds are calculated as if all layers were collapsed into one.
	/// 
	/// @CSharpLua.Template = "tilemap.get_bounds({0})"
	/// </summary>
	public extern double get_bounds(string url_p1, out double y_o1, out double w_o2, out double h_o3);
	
	
	/// <summary>
	/// Get the bounds for a tile map. This function returns multiple values:
	/// The lower left corner index x and y coordinates (1-indexed),
	/// the tile map width and the tile map height.
	/// The resulting values take all tile map layers into account, meaning that
	/// the bounds are calculated as if all layers were collapsed into one.
	/// 
	/// @CSharpLua.Template = "tilemap.get_bounds({0})"
	/// </summary>
	public extern double get_bounds(Hash url_p1, out double y_o1, out double w_o2, out double h_o3);
	
	
	/// <summary>
	/// Get the bounds for a tile map. This function returns multiple values:
	/// The lower left corner index x and y coordinates (1-indexed),
	/// the tile map width and the tile map height.
	/// The resulting values take all tile map layers into account, meaning that
	/// the bounds are calculated as if all layers were collapsed into one.
	/// 
	/// @CSharpLua.Template = "tilemap.get_bounds({0})"
	/// </summary>
	public extern double get_bounds(Url url_p1, out double y_o1, out double w_o2, out double h_o3);
	
	
	/// <summary>
	/// Sets the visibility of the tilemap layer
	/// 
	/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
	/// </summary>
	public extern void set_visible(string url_p1, string layer_p2, bool visible_p3);
	
	
	/// <summary>
	/// Sets the visibility of the tilemap layer
	/// 
	/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
	/// </summary>
	public extern void set_visible(string url_p1, Hash layer_p2, bool visible_p3);
	
	
	/// <summary>
	/// Sets the visibility of the tilemap layer
	/// 
	/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
	/// </summary>
	public extern void set_visible(Hash url_p1, string layer_p2, bool visible_p3);
	
	
	/// <summary>
	/// Sets the visibility of the tilemap layer
	/// 
	/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
	/// </summary>
	public extern void set_visible(Hash url_p1, Hash layer_p2, bool visible_p3);
	
	
	/// <summary>
	/// Sets the visibility of the tilemap layer
	/// 
	/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
	/// </summary>
	public extern void set_visible(Url url_p1, string layer_p2, bool visible_p3);
	
	
	/// <summary>
	/// Sets the visibility of the tilemap layer
	/// 
	/// @CSharpLua.Template = "tilemap.set_visible({0}, {1}, {2})"
	/// </summary>
	public extern void set_visible(Url url_p1, Hash layer_p2, bool visible_p3);
	
	
	#endregion Defold API
	
	
	
	
	//Cacheables
	private Rect _cachedBounds;
	
	/// <summary>
	/// Gets the bounds for the tilemap.  
	/// </summary>
	/// <returns></returns>
	public Rect Bounds
	{
	   get
	   {
	      if (IsCachingEnabled)
	         if (_cachedBounds != null)
	            return _cachedBounds;
	
	
	      var x = get_bounds(this, out var y, out var w, out var h);
	      var returnVal = new Rect(x, y, w, h);
	
	      if (IsCachingEnabled)
	         _cachedBounds = returnVal;
	
	      return returnVal;
	   }
	}
	
	
	
	public int GetTile(int x, int y, string layer)
	{
	   return (int)get_tile(this, layer, x, y);
	}
	   
	public int GetTile(int x, int y, Hash layer)
	{
	   return (int)get_tile(this, layer, x, y);
	}
	
	
	public void SetTile(int x, int y, int tile, string layer)
	{
	   ValidateCachedBounds(x, y);
	   set_tile(this, layer, x, y, tile);
	}
	public void SetTile(int x, int y, int tile, string layer, TilemapTransforms transformBitmask)
	{
	   ValidateCachedBounds(x, y);
	   set_tile(this, layer, x, y, tile, (int)transformBitmask);
	}
	   
	public void SetTile(int x, int y, int tile, Hash layer)
	{
	   ValidateCachedBounds(x, y);
	   set_tile(this, layer, x, y, tile);
	}
	public void SetTile(int x, int y, int tile, Hash layer, TilemapTransforms transformBitmask)
	{
	   ValidateCachedBounds(x, y);
	   set_tile(this, layer, x, y, tile, (int)transformBitmask);
	}
	   
	
	private void ValidateCachedBounds(int x, int y)
	{
	   if (IsCachingEnabled)
	      if (_cachedBounds != null)
	      {
	         //If we're setting a tile outside the cached boundaries,
	         //clear the cache so the next request will re-fetch.
	         if (!_cachedBounds.InRect(x, y))
	            _cachedBounds = null;
	      }
	}
	   
	   
	   
	
	public void SetLayerVisible(string layer, bool visible = true)
	{
	   set_visible(this, layer, visible);
	}
	   
	public void SetLayerVisible(Hash layer, bool visible = true)
	{
	   set_visible(this, layer, visible);
	}
}
