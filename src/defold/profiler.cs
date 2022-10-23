using types;

/// <summary>
///     Profiler API documentation
/// </summary>
public static class Profiler
{
	/// <summary>
	///     Get the amount of memory used (resident/working set) by the application in bytes, as reported by the OS.
	///     <span class="icon-attention"></span> This function is not available on <span class="icon-html5"></span> HTML5.
	///     The values are gathered from internal OS functions which correspond to the following;
	///     <table>
	///         <thead>
	///             <tr>
	///                 <th>OS</th>
	///                 <th>Value</th>
	///             </tr>
	///         </thead>
	///         <tbody>
	///             <tr>
	///                 <td>
	///                     <span class="icon-ios"></span> iOS<br /><span class="icon-macos"></span> MacOS<br />
	///                     <span class="icon-android"></span><br />Androd<br /><span class="icon-linux"></span> Linux
	///                 </td>
	///                 <td>
	///                     <a href="https://en.wikipedia.org/wiki/Resident_set_size">Resident memory</a>
	///                 </td>
	///             </tr>
	///             <tr>
	///                 <td><span class="icon-windows"></span> Windows</td>
	///                 <td>
	///                     <a href="https://en.wikipedia.org/wiki/Working_set">Working set</a>
	///                 </td>
	///             </tr>
	///             <tr>
	///                 <td><span class="icon-html5"></span> HTML5</td>
	///                 <td><span class="icon-attention"></span> Not available</td>
	///             </tr>
	///         </tbody>
	///     </table>
	///     @CSharpLua.Template = "profiler.get_memory_usage()"
	/// </summary>
	public static extern double Get_memory_usage();


	/// <summary>
	///     Get the percent of CPU usage by the application, as reported by the OS.
	///     <span class="icon-attention"></span> This function is not available on <span class="icon-html5"></span> HTML5.
	///     For some platforms (<span class="icon-android"></span> Android, <span class="icon-linux"></span> Linux and
	///     <span class="icon-windows"></span> Windows), this information is only available
	///     by default in the debug version of the engine. It can be enabled in release version as well
	///     by checking <code>track_cpu</code> under <code>profiler</code> in the <code>game.project</code> file.
	///     (This means that the engine will sample the CPU usage in intervalls during execution even in release mode.)
	///     @CSharpLua.Template = "profiler.get_cpu_usage()"
	/// </summary>
	public static extern double Get_cpu_usage();


	/// <summary>
	///     Creates and shows or hides and destroys the on-sceen profiler ui
	///     The profiler is a real-time tool that shows the numbers of milliseconds spent
	///     in each scope per frame as well as counters. The profiler is very useful for
	///     tracking down performance and resource problems.
	///     @CSharpLua.Template = "profiler.enable_ui({0})"
	/// </summary>
	public static extern void Enable_ui(bool enabled_p1);


	/// <summary>
	///     Set the on-screen profile mode - run, pause, record or show peak frame
	///     @CSharpLua.Template = "profiler.set_ui_mode({0})"
	/// </summary>
	public static extern void Set_ui_mode(ProfilerMode mode_p1);


	/// <summary>
	///     Set the on-screen profile view mode - minimized or expanded
	///     @CSharpLua.Template = "profiler.set_ui_view_mode({0})"
	/// </summary>
	public static extern void Set_ui_view_mode(ProfilerViewMode mode_p1);


	/// <summary>
	///     Shows or hides the time the engine waits for vsync in the on-screen profiler
	///     Each frame the engine waits for vsync and depending on your vsync settings and how much time
	///     your game logic takes this time can dwarf the time in the game logic making it hard to
	///     see details in the on-screen profiler graph and lists.
	///     Also, by hiding this the FPS times in the header show the time spent each time excuding the
	///     time spent waiting for vsync. This shows you how long time your game is spending actively
	///     working each frame.
	///     This setting also effects the display of recorded frames but does not affect the actual
	///     recorded frames so it is possible to toggle this on and off when viewing recorded frames.
	///     By default the vsync wait times is displayed in the profiler.
	///     @CSharpLua.Template = "profiler.set_ui_vsync_wait_visible({0})"
	/// </summary>
	public static extern void Set_ui_vsync_wait_visible(bool visible_p1);


	/// <summary>
	///     Get the number of recorded frames in the on-screen profiler ui recording buffer
	///     @CSharpLua.Template = "profiler.recorded_frame_count()"
	/// </summary>
	public static extern double Recorded_frame_count();


	/// <summary>
	///     Pauses and displays a frame from the recording buffer in the on-screen profiler ui
	///     The frame to show can either be an absolute frame or a relative frame to the current frame.
	///     @CSharpLua.Template = "profiler.view_recorded_frame({0})"
	/// </summary>
	public static extern void View_recorded_frame(ILuaTable frame_index_p1);


	/// <summary>
	///     Send a text to the profiler
	///     @CSharpLua.Template = "profiler.log_text({0})"
	/// </summary>
	public static extern void Log_text(string text_p1);


	/// <summary>
	///     Starts a profile scope.
	///     @CSharpLua.Template = "profiler.scope_begin({0})"
	/// </summary>
	public static extern void Scope_begin(string name_p1);


	/// <summary>
	///     End the current profile scope.
	///     @CSharpLua.Template = "profiler.scope_end()"
	/// </summary>
	public static extern void Scope_end();
}