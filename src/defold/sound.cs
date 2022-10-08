using System;
using types;

/// <summary>
/// Sound API documentation
/// 
/// @CSharpLua.Ignore
/// </summary>
public static class sound
{
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.is_music_playing()"
	/// </summary>
	public static extern bool is_music_playing();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_rms({0}, {1})"
	/// </summary>
	public static extern double get_rms(string group_p1, double window_p2, out double rms_r_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_rms({0}, {1})"
	/// </summary>
	public static extern double get_rms(Hash group_p1, double window_p2, out double rms_r_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_peak({0}, {1})"
	/// </summary>
	public static extern double get_peak(string group_p1, double window_p2, out double peak_r_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_peak({0}, {1})"
	/// </summary>
	public static extern double get_peak(Hash group_p1, double window_p2, out double peak_r_o1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_group_gain({0}, {1})"
	/// </summary>
	public static extern void set_group_gain(string group_p1, double gain_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_group_gain({0}, {1})"
	/// </summary>
	public static extern void set_group_gain(Hash group_p1, double gain_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_group_gain({0})"
	/// </summary>
	public static extern double get_group_gain(string group_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_group_gain({0})"
	/// </summary>
	public static extern double get_group_gain(Hash group_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_groups()"
	/// </summary>
	public static extern ILuaTable get_groups();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_group_name({0})"
	/// </summary>
	public static extern string get_group_name(string group_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.get_group_name({0})"
	/// </summary>
	public static extern string get_group_name(Hash group_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.is_phone_call_active()"
	/// </summary>
	public static extern bool is_phone_call_active();
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0})"
	/// </summary>
	public static extern double play(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1})"
	/// </summary>
	public static extern double play(string url_p1, ILuaTable play_properties_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1}, {2})"
	/// </summary>
	public static extern double play(string url_p1, ILuaTable play_properties_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0})"
	/// </summary>
	public static extern double play(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1})"
	/// </summary>
	public static extern double play(Hash url_p1, ILuaTable play_properties_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1}, {2})"
	/// </summary>
	public static extern double play(Hash url_p1, ILuaTable play_properties_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0})"
	/// </summary>
	public static extern double play(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1})"
	/// </summary>
	public static extern double play(Url url_p1, ILuaTable play_properties_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1}, {2})"
	/// </summary>
	public static extern double play(Url url_p1, ILuaTable play_properties_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.stop({0})"
	/// </summary>
	public static extern void stop(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.stop({0})"
	/// </summary>
	public static extern void stop(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.stop({0})"
	/// </summary>
	public static extern void stop(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.pause({0}, {1})"
	/// </summary>
	public static extern void pause(string url_p1, bool pause_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.pause({0}, {1})"
	/// </summary>
	public static extern void pause(Hash url_p1, bool pause_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.pause({0}, {1})"
	/// </summary>
	public static extern void pause(Url url_p1, bool pause_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0})"
	/// </summary>
	public static extern void set_gain(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0}, {1})"
	/// </summary>
	public static extern void set_gain(string url_p1, double gain_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0})"
	/// </summary>
	public static extern void set_gain(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0}, {1})"
	/// </summary>
	public static extern void set_gain(Hash url_p1, double gain_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0})"
	/// </summary>
	public static extern void set_gain(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0}, {1})"
	/// </summary>
	public static extern void set_gain(Url url_p1, double gain_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0})"
	/// </summary>
	public static extern void set_pan(string url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0}, {1})"
	/// </summary>
	public static extern void set_pan(string url_p1, double pan_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0})"
	/// </summary>
	public static extern void set_pan(Hash url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0}, {1})"
	/// </summary>
	public static extern void set_pan(Hash url_p1, double pan_p2);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0})"
	/// </summary>
	public static extern void set_pan(Url url_p1);
		
		
	/// <summary>
	/// 
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0}, {1})"
	/// </summary>
	public static extern void set_pan(Url url_p1, double pan_p2);
		
		
}