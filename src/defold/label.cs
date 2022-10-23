using types;

/// <summary>
///     Label API documentation
/// </summary>
public static class Label
{
	/// <summary>
	///     Sets the text of a label component
	///     <span class="icon-attention"></span> This method uses the message passing that means the value will be set after
	///     <code>dispatch messages</code> step.
	///     More information is available in the <a href="/manuals/application-lifecycle">Application Lifecycle manual</a>.
	///     @CSharpLua.Template = "label.set_text({0}, {1})"
	/// </summary>
	public static extern void Set_text(string url_p1, string text_p2);


	/// <summary>
	///     Sets the text of a label component
	///     <span class="icon-attention"></span> This method uses the message passing that means the value will be set after
	///     <code>dispatch messages</code> step.
	///     More information is available in the <a href="/manuals/application-lifecycle">Application Lifecycle manual</a>.
	///     @CSharpLua.Template = "label.set_text({0}, {1})"
	/// </summary>
	public static extern void Set_text(Hash url_p1, string text_p2);


	/// <summary>
	///     Sets the text of a label component
	///     <span class="icon-attention"></span> This method uses the message passing that means the value will be set after
	///     <code>dispatch messages</code> step.
	///     More information is available in the <a href="/manuals/application-lifecycle">Application Lifecycle manual</a>.
	///     @CSharpLua.Template = "label.set_text({0}, {1})"
	/// </summary>
	public static extern void Set_text(Url url_p1, string text_p2);


	/// <summary>
	///     Gets the text from a label component
	///     @CSharpLua.Template = "label.get_text({0})"
	/// </summary>
	public static extern string Get_text(string url_p1);


	/// <summary>
	///     Gets the text from a label component
	///     @CSharpLua.Template = "label.get_text({0})"
	/// </summary>
	public static extern string Get_text(Hash url_p1);


	/// <summary>
	///     Gets the text from a label component
	///     @CSharpLua.Template = "label.get_text({0})"
	/// </summary>
	public static extern string Get_text(Url url_p1);
}