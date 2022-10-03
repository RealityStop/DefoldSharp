namespace types
{
	/// <summary>
	/// @CSharpLua.Ignore
	/// </summary>
	public class LuaTableOf<TKey, TValue> : LuaTableBase
	{
		/// <summary>
/// @CSharpLua.Template = "{}"
/// </summary> 
public extern LuaTableOf();


/// <summary>
/// @CSharpLua.Template = "{this}[{0}] = {1}"
/// </summary> 
public extern void Add(TKey key, TValue value);


/// <summary>
/// @CSharpLua.Template = "{this}.{0} = nil"
/// </summary>
public extern bool Remove(TKey key);


/// <summary>
/// @CSharpLua.Template = for k in next, {this} do rawset({this}, k, nil) end
/// </summary>
public extern void Clear();


/// <summary>
/// @CSharpLua.Template = "{this}[{0}]"
/// </summary>
public extern bool ContainsKey(TKey key);

/// <summary>
/// @CSharpLua.Template = "{this}[{0}]"
/// </summary>
public extern LuaType Get(TKey key);


/// <summary>
/// @CSharpLua.Template = "{this}[{0}] = {1}"
/// </summary>
public extern void Set(TKey key, TValue value);
	}
}
