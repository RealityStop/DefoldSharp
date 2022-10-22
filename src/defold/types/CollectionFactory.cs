using System.Runtime.CompilerServices;
using support;

namespace types
{
	public readonly struct CollectionFactoryCreateResult
	{
		public readonly Hash RelativeHash;
		public readonly Hash UniqueHash;


		public CollectionFactoryCreateResult(Hash relativeHash, Hash uniqueHash)
		{
			RelativeHash = relativeHash;
			UniqueHash = uniqueHash;
		}
	}
	
	public class CollectionFactory : NonCachingComponentReference
	{
		public FactoryStatus Status => collectionfactory.get_status(this);


		public LuaTableOf<Hash, Hash> Create()
		{
			return (LuaTableOf<Hash, Hash>)collectionfactory.create(this);
		}
		
		public LuaTableOf<Hash, Hash> Create(Vector3 position)
		{
			return (LuaTableOf<Hash, Hash>)collectionfactory.create(this, position);
		}
		
		public LuaTableOf<Hash, Hash> Create(Vector3 position, Quaternion rotation)
		{
			return (LuaTableOf<Hash, Hash>)collectionfactory.create(this, position, rotation);
		}
		
		public LuaTableOf<Hash, Hash> Create(Vector3 position, Quaternion rotation, ILuaTable properties)
		{
			return (LuaTableOf<Hash, Hash>)collectionfactory.create(this, position, rotation, properties);
		}
	}
}