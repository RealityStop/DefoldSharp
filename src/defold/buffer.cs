using System;
using defold.types;

namespace defold
{
	/// <summary>
	/// Buffer API documentation
	/// 
	/// @CSharpLua.Ignore
	/// </summary>
	public static class buffer
	{
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "buffer.create({0}, {1})"
		/// </summary>
		public static extern DataBuffer create(double element_count_p1, ILuaTable declaration_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "buffer.get_stream({0}, {1})"
		/// </summary>
		public static extern BufferStream get_stream(DataBuffer buffer_p1, Hash stream_name_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "buffer.get_stream({0}, {1})"
		/// </summary>
		public static extern BufferStream get_stream(DataBuffer buffer_p1, string stream_name_p2);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "buffer.copy_stream({0}, {1}, {2}, {3}, {4})"
		/// </summary>
		public static extern void copy_stream(BufferStream dst_p1, double dstoffset_p2, BufferStream src_p3, double srcoffset_p4, double count_p5);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "buffer.copy_buffer({0}, {1}, {2}, {3}, {4})"
		/// </summary>
		public static extern void copy_buffer(DataBuffer dst_p1, double dstoffset_p2, DataBuffer src_p3, double srcoffset_p4, double count_p5);
		
		
		/// <summary>
		/// 
		/// 
		/// @CSharpLua.Template = "buffer.get_bytes({0}, {1})"
		/// </summary>
		public static extern string get_bytes(DataBuffer buffer_p1, Hash stream_name_p2);
		
		
	}
}
