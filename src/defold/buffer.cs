using System;
using types;

/// <summary>
/// Buffer API documentation
/// 
/// </summary>
public static class Buffer
{
	/// <summary>
	/// Create a new data buffer containing a specified set of streams. A data buffer
	/// can contain one or more streams with typed data. This is useful for managing
	/// compound data, for instance a vertex buffer could contain separate streams for
	/// vertex position, color, normal etc.
	/// 
	/// @CSharpLua.Template = "buffer.create({0}, {1})"
	/// </summary>
	public static extern DataBuffer Create(double element_count_p1, ILuaTable declaration_p2);
	
	
	/// <summary>
	/// Get a specified stream from a buffer.
	/// 
	/// @CSharpLua.Template = "buffer.get_stream({0}, {1})"
	/// </summary>
	public static extern BufferStream Get_stream(DataBuffer buffer_p1, Hash stream_name_p2);
	
	
	/// <summary>
	/// Get a specified stream from a buffer.
	/// 
	/// @CSharpLua.Template = "buffer.get_stream({0}, {1})"
	/// </summary>
	public static extern BufferStream Get_stream(DataBuffer buffer_p1, string stream_name_p2);
	
	
	/// <summary>
	/// Copy a specified amount of data from one stream to another.
	/// <span class="icon-attention"></span> The value type and size must match between source and destination streams.
	/// The source and destination streams can be the same.
	/// 
	/// @CSharpLua.Template = "buffer.copy_stream({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern void Copy_stream(BufferStream dst_p1, double dstoffset_p2, BufferStream src_p3, double srcoffset_p4, double count_p5);
	
	
	/// <summary>
	/// Copy all data streams from one buffer to another, element wise.
	/// <span class="icon-attention"></span> Each of the source streams must have a matching stream in the
	/// destination buffer. The streams must match in both type and size.
	/// The source and destination buffer can be the same.
	/// 
	/// @CSharpLua.Template = "buffer.copy_buffer({0}, {1}, {2}, {3}, {4})"
	/// </summary>
	public static extern void Copy_buffer(DataBuffer dst_p1, double dstoffset_p2, DataBuffer src_p3, double srcoffset_p4, double count_p5);
	
	
	/// <summary>
	/// Get a copy of all the bytes from a specified stream as a Lua string.
	/// 
	/// @CSharpLua.Template = "buffer.get_bytes({0}, {1})"
	/// </summary>
	public static extern string Get_bytes(DataBuffer buffer_p1, Hash stream_name_p2);
	
	
}
