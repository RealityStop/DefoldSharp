using src2.defold.types;

namespace src2.defold.support
{
	public static class LuaTableSerializableExt
	{
		public static ILuaTable DefaultTableSerialization(this ILuaTableSerializable self)
		{
			/*
			[[
			local table = {}
			local metadata = self.__metadata__
			if metadata.fields then
			  for _, value in ipairs(metadata.fields) do
			    table[ value[1] ] = self[ value[1] ];
			  end
			end
			
			if metadata.properties then
			  for _, value in ipairs(metadata.properties) do
			    table[ value[1] ] = self[ value[1] ];
			  end
			end			
			]]*/

			return ReturnTable();
		}
		
		// Because "table" only exists in lua, we have to fool C# AND the serialization engine.  So we return a call from
		// this function which C# thinks is a ILuaTable, but lua thinks is just "table".
		
		/// <summary>
		/// @CSharpLua.Template = table
		/// </summary>					
		private static extern ILuaTable ReturnTable();
		
		public static T DefaultTableDeserialization<T>(this ILuaTable self) where T:ILuaTableSerializable, new()
		{
			T table = new T();
			/*
			[[
			local metadata = table.__metadata__
			if metadata.fields then
			  for _, value in ipairs(metadata.fields) do
			    table[ value[1] ] = self[ value[1] ];
			  end
			end
			
			if metadata.properties then
			  for _, value in ipairs(metadata.properties) do
			    table[ value[1] ] = self[ value[1] ];
			  end
			end			
			]]*/

			return table;
		}


	}
}