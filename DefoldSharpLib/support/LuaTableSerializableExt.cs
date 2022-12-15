namespace DefoldSharp
{
	public static class LuaTableSerializableExt
	{
		public static LuaTable DefaultTableSerialization(this ILuaTableSerializable self)
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
			    --We want to skip over non-auto properties. Only auto-properties have implicit backing
			    --if we have getters and/or setters, then we assume that the property state can be recostructed
			    --from fields and other properties. 
			    if #value <= 3 then
			      table[ value[1] ] = self[ value[1] ];
			    end
			  end
			end			
			]]*/

			return ReturnTable();
		}


		// Because "table" only exists in lua, we have to fool C# AND the serialization engine.  So we return a call from
		// this function which C# thinks is a ILuaTable, but lua thinks is just "table".


		/// <summary>
		///     @CSharpLua.Template = table
		/// </summary>
		private static extern LuaTable ReturnTable();


		public static T DefaultTableDeserialization<T>(this LuaTable self) where T : ILuaTableSerializable, new()
		{
			var table = new T();
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
			  	--We want to skip over non-auto properties. Only auto-properties have implicit backing
			    --if we have getters and/or setters, then we assume that the property state can be recostructed
			    --from fields and other properties. 
			    if #value <= 3 then
			      table[ value[1] ] = self[ value[1] ];
			    end
			  end
			end			
			]]*/

			return table;
		}
	}
}