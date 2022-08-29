using src2.defold.types;

namespace src2.defold.support
{
	/// <summary>
	/// Base class for all game object scripts (.script).
	/// </summary>
	[GenGOScript]
	public abstract class GameObjectScript
	{
		protected bool IsInputFocusHeld { get; private set; }


		protected void RequestInput()
		{
			InputHelpers.RequestInput();
			IsInputFocusHeld = true;
		}


		protected void ReleaseInput()
		{
			IsInputFocusHeld = false;
			InputHelpers.ReleaseInput();
		}

		/// <summary>
		/// Called when a script component is initialized.
		///
		/// This is a callback-function, which is called by the engine when a script component is initialized. It can be used
		/// to set the initial state of the script.
		/// </summary>
		protected virtual void init()
		{
		}


		/// <summary>
		///         Called when a script component is finalized.
		/// This is a callback-function, which is called by the engine when a script component is finalized (destroyed). It can
		/// be used to e.g. take some last action, report the finalization to other game object instances, delete spawned objects
		/// or release user input focus (see `release_input_focus`).
		/// </summary>
		protected virtual void final()
		{
		}
	
		/// <summary>
		/// Called every frame to update the script component.
		///	This is a callback-function, which is called by the engine every frame to update the state of a script component.
		///	It can be used to perform any kind of game related tasks, e.g. moving the game object instance.
		/// </summary>
		/// <param name="dt">frame update timestep</param>
		protected virtual void update(float dt)
		{
		}


		/// <summary>
		/// Called every frame to update the script component.
		///
		///	Frame-rate independent update. dt contains the delta time since the last update.
		///	Useful when you wish to manipulate physics objects at regular intervals to achieve a stable physics simulation.
		///	Requires that `physics.use_fixed_timestep` is enabled in game.project.
		/// </summary>
		/// <param name="dt">frame update timestep</param>
		protected virtual void fixed_update(float dt)
		{
		}

		/// <summary>
		/// Called when a message has been sent to the script component.
		///
		///		This is a callback-function, which is called by the engine whenever a message has been sent to the script component.
		///		It can be used to take action on the message, e.g. send a response back to the sender of the message.
		///
		///		The `message` parameter is a table containing the message data. If the message is sent from the engine, the
		///		documentation of the message specifies which data is supplied.
		/// </summary>
		/// <param name="message_id">id of the received message</param>
		/// <param name="message">a table containing the message data</param>
		/// <param name="sender">address of the sender</param>
		protected virtual void on_message(Hash message_id, object message, object sender)
		{
		}

		/// <summary>
		/// Called when user input is received.
		///
		///		This is a callback-function, which is called by the engine when user input is sent to the game object instance of the script.
		///		It can be used to take action on the input, e.g. move the instance according to the input.
		///
		///		For an instance to obtain user input, it must first acquire input focuse through the message `acquire_input_focus`.
		///		See the documentation of that message for more information.
		///
		///		The `action` parameter is a table containing data about the input mapped to the `action_id`.
		///		For mapped actions it specifies the value of the input and if it was just pressed or released.
		///		Actions are mapped to input in an input_binding-file.
		///
		///		Mouse movement is specifically handled and uses `nil` as its `action_id`.
		///		The `action` only contains positional parameters in this case, such as x and y of the pointer.
		/// </summary>
		/// <param name="action_id">id of the received input action, as mapped in the input_binding-file</param>
		/// <param name="action">a table containing the input data, see above for a description</param>
		/// <returns>boolean to signal if the input should be consumed (not passed on to others) or not, default is false</returns>
		protected virtual bool on_input(Hash action_id, object action)
		{
			return false;
		}
	
	
		/// <summary>
		/// Called when the script component is reloaded.
		///
		///	This is a callback-function, which is called by the engine when the script component is reloaded, e.g. from the editor.
		///	It can be used for live development, e.g. to tweak constants or set up the state properly for the instance.
		/// </summary>
		protected virtual void on_reload()
		{
		}
	}
}