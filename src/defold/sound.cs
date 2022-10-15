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
	/// Checks if background music is playing, e.g. from iTunes.
	/// <span class="icon-macos"></span><span class="icon-windows"></span><span class="icon-linux"></span><span class="icon-html5"></span> On non mobile platforms,
	/// this function always return <code>false</code>.
	/// <span class="icon-attention"></span><span class="icon-android"></span> On Android you can only get a correct reading
	/// of this state if your game is not playing any sounds itself. This is a limitation
	/// in the Android SDK. If your game is playing any sounds, <em>even with a gain of zero</em>, this
	/// function will return <code>false</code>.
	/// The best time to call this function is:
	/// <ul>
	/// <li>In the <code>init</code> function of your main collection script before any sounds are triggered</li>
	/// <li>In a window listener callback when the window.WINDOW_EVENT_FOCUS_GAINED event is received</li>
	/// </ul>
	/// Both those times will give you a correct reading of the state even when your application is
	/// swapped out and in while playing sounds and it works equally well on Android and iOS.
	/// 
	/// @CSharpLua.Template = "sound.is_music_playing()"
	/// </summary>
	public static extern bool is_music_playing();
	
	
	/// <summary>
	/// Get RMS (Root Mean Square) value from mixer group. This value is the
	/// square root of the mean (average) value of the squared function of
	/// the instantaneous values.
	/// For instance: for a sinewave signal with a peak gain of -1.94 dB (0.8 linear),
	/// the RMS is <code>0.8 &times; 1/sqrt(2)</code> which is about 0.566.
	/// <span class="icon-attention"></span> Note the returned value might be an approximation and in particular
	/// the effective window might be larger than specified.
	/// 
	/// @CSharpLua.Template = "sound.get_rms({0}, {1})"
	/// </summary>
	public static extern double get_rms(string group_p1, double window_p2, out double rms_r_o1);
	
	
	/// <summary>
	/// Get RMS (Root Mean Square) value from mixer group. This value is the
	/// square root of the mean (average) value of the squared function of
	/// the instantaneous values.
	/// For instance: for a sinewave signal with a peak gain of -1.94 dB (0.8 linear),
	/// the RMS is <code>0.8 &times; 1/sqrt(2)</code> which is about 0.566.
	/// <span class="icon-attention"></span> Note the returned value might be an approximation and in particular
	/// the effective window might be larger than specified.
	/// 
	/// @CSharpLua.Template = "sound.get_rms({0}, {1})"
	/// </summary>
	public static extern double get_rms(Hash group_p1, double window_p2, out double rms_r_o1);
	
	
	/// <summary>
	/// Get peak value from mixer group.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// Also note that the returned value might be an approximation and in particular
	/// the effective window might be larger than specified.
	/// 
	/// @CSharpLua.Template = "sound.get_peak({0}, {1})"
	/// </summary>
	public static extern double get_peak(string group_p1, double window_p2, out double peak_r_o1);
	
	
	/// <summary>
	/// Get peak value from mixer group.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// Also note that the returned value might be an approximation and in particular
	/// the effective window might be larger than specified.
	/// 
	/// @CSharpLua.Template = "sound.get_peak({0}, {1})"
	/// </summary>
	public static extern double get_peak(Hash group_p1, double window_p2, out double peak_r_o1);
	
	
	/// <summary>
	/// Set mixer group gain
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_group_gain({0}, {1})"
	/// </summary>
	public static extern void set_group_gain(string group_p1, double gain_p2);
	
	
	/// <summary>
	/// Set mixer group gain
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_group_gain({0}, {1})"
	/// </summary>
	public static extern void set_group_gain(Hash group_p1, double gain_p2);
	
	
	/// <summary>
	/// Get mixer group gain
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.get_group_gain({0})"
	/// </summary>
	public static extern double get_group_gain(string group_p1);
	
	
	/// <summary>
	/// Get mixer group gain
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.get_group_gain({0})"
	/// </summary>
	public static extern double get_group_gain(Hash group_p1);
	
	
	/// <summary>
	/// Get a table of all mixer group names (hashes).
	/// 
	/// @CSharpLua.Template = "sound.get_groups()"
	/// </summary>
	public static extern ILuaTable get_groups();
	
	
	/// <summary>
	/// Get a mixer group name as a string.
	/// <span class="icon-attention"></span> This function is to be used for debugging and
	/// development tooling only. The function does a reverse hash lookup, which does not
	/// return a proper string value when the game is built in release mode.
	/// 
	/// @CSharpLua.Template = "sound.get_group_name({0})"
	/// </summary>
	public static extern string get_group_name(string group_p1);
	
	
	/// <summary>
	/// Get a mixer group name as a string.
	/// <span class="icon-attention"></span> This function is to be used for debugging and
	/// development tooling only. The function does a reverse hash lookup, which does not
	/// return a proper string value when the game is built in release mode.
	/// 
	/// @CSharpLua.Template = "sound.get_group_name({0})"
	/// </summary>
	public static extern string get_group_name(Hash group_p1);
	
	
	/// <summary>
	/// Checks if a phone call is active. If there is an active phone call all
	/// other sounds will be muted until the phone call is finished.
	/// <span class="icon-macos"></span><span class="icon-windows"></span><span class="icon-linux"></span><span class="icon-html5"></span> On non mobile platforms,
	/// this function always return <code>false</code>.
	/// 
	/// @CSharpLua.Template = "sound.is_phone_call_active()"
	/// </summary>
	public static extern bool is_phone_call_active();
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0})"
	/// </summary>
	public static extern double play(string url_p1);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1})"
	/// </summary>
	public static extern double play(string url_p1, ILuaTable play_properties_p2);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1}, {2})"
	/// </summary>
	public static extern double play(string url_p1, ILuaTable play_properties_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0})"
	/// </summary>
	public static extern double play(Hash url_p1);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1})"
	/// </summary>
	public static extern double play(Hash url_p1, ILuaTable play_properties_p2);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1}, {2})"
	/// </summary>
	public static extern double play(Hash url_p1, ILuaTable play_properties_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0})"
	/// </summary>
	public static extern double play(Url url_p1);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1})"
	/// </summary>
	public static extern double play(Url url_p1, ILuaTable play_properties_p2);
	
	
	/// <summary>
	/// Make the sound component play its sound. Multiple voices are supported. The limit is set to 32 voices per sound component.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// <span class="icon-attention"></span> A sound will continue to play even if the game object the sound component belonged to is deleted. You can call <code>sound.stop()</code> to stop the sound.
	/// 
	/// @CSharpLua.Template = "sound.play({0}, {1}, {2})"
	/// </summary>
	public static extern double play(Url url_p1, ILuaTable play_properties_p2, Action<object,Hash,ILuaTable,Url> complete_function_p3);
	
	
	/// <summary>
	/// Stop playing all active voices
	/// 
	/// @CSharpLua.Template = "sound.stop({0})"
	/// </summary>
	public static extern void stop(string url_p1);
	
	
	/// <summary>
	/// Stop playing all active voices
	/// 
	/// @CSharpLua.Template = "sound.stop({0})"
	/// </summary>
	public static extern void stop(Hash url_p1);
	
	
	/// <summary>
	/// Stop playing all active voices
	/// 
	/// @CSharpLua.Template = "sound.stop({0})"
	/// </summary>
	public static extern void stop(Url url_p1);
	
	
	/// <summary>
	/// Pause all active voices
	/// 
	/// @CSharpLua.Template = "sound.pause({0}, {1})"
	/// </summary>
	public static extern void pause(string url_p1, bool pause_p2);
	
	
	/// <summary>
	/// Pause all active voices
	/// 
	/// @CSharpLua.Template = "sound.pause({0}, {1})"
	/// </summary>
	public static extern void pause(Hash url_p1, bool pause_p2);
	
	
	/// <summary>
	/// Pause all active voices
	/// 
	/// @CSharpLua.Template = "sound.pause({0}, {1})"
	/// </summary>
	public static extern void pause(Url url_p1, bool pause_p2);
	
	
	/// <summary>
	/// Set gain on all active playing voices of a sound.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0})"
	/// </summary>
	public static extern void set_gain(string url_p1);
	
	
	/// <summary>
	/// Set gain on all active playing voices of a sound.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0}, {1})"
	/// </summary>
	public static extern void set_gain(string url_p1, double gain_p2);
	
	
	/// <summary>
	/// Set gain on all active playing voices of a sound.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0})"
	/// </summary>
	public static extern void set_gain(Hash url_p1);
	
	
	/// <summary>
	/// Set gain on all active playing voices of a sound.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0}, {1})"
	/// </summary>
	public static extern void set_gain(Hash url_p1, double gain_p2);
	
	
	/// <summary>
	/// Set gain on all active playing voices of a sound.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0})"
	/// </summary>
	public static extern void set_gain(Url url_p1);
	
	
	/// <summary>
	/// Set gain on all active playing voices of a sound.
	/// <span class="icon-attention"></span> Note that gain is in linear scale, between 0 and 1.
	/// To get the dB value from the gain, use the formula <code>20 * log(gain)</code>.
	/// Inversely, to find the linear value from a dB value, use the formula
	/// <code>10<sup>db/20</sup></code>.
	/// 
	/// @CSharpLua.Template = "sound.set_gain({0}, {1})"
	/// </summary>
	public static extern void set_gain(Url url_p1, double gain_p2);
	
	
	/// <summary>
	/// Set panning on all active playing voices of a sound.
	/// The valid range is from -1.0 to 1.0, representing -45 degrees left, to +45 degrees right.
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0})"
	/// </summary>
	public static extern void set_pan(string url_p1);
	
	
	/// <summary>
	/// Set panning on all active playing voices of a sound.
	/// The valid range is from -1.0 to 1.0, representing -45 degrees left, to +45 degrees right.
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0}, {1})"
	/// </summary>
	public static extern void set_pan(string url_p1, double pan_p2);
	
	
	/// <summary>
	/// Set panning on all active playing voices of a sound.
	/// The valid range is from -1.0 to 1.0, representing -45 degrees left, to +45 degrees right.
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0})"
	/// </summary>
	public static extern void set_pan(Hash url_p1);
	
	
	/// <summary>
	/// Set panning on all active playing voices of a sound.
	/// The valid range is from -1.0 to 1.0, representing -45 degrees left, to +45 degrees right.
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0}, {1})"
	/// </summary>
	public static extern void set_pan(Hash url_p1, double pan_p2);
	
	
	/// <summary>
	/// Set panning on all active playing voices of a sound.
	/// The valid range is from -1.0 to 1.0, representing -45 degrees left, to +45 degrees right.
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0})"
	/// </summary>
	public static extern void set_pan(Url url_p1);
	
	
	/// <summary>
	/// Set panning on all active playing voices of a sound.
	/// The valid range is from -1.0 to 1.0, representing -45 degrees left, to +45 degrees right.
	/// 
	/// @CSharpLua.Template = "sound.set_pan({0}, {1})"
	/// </summary>
	public static extern void set_pan(Url url_p1, double pan_p2);
	
	
}
