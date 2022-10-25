using System;
using System.Collections.Generic;
using types;

namespace support
{
	/// <summary>
	/// Generic access for both builtin components and user components.
	/// </summary>
	public static class Component
	{
		private readonly struct ComponentRecord
		{
			public readonly Type type;
			public readonly object data;


			public ComponentRecord(Type type, object data)
			{
				this.type = type;
				this.data = data;
			}
		}



		private static readonly Dictionary<Url, ComponentRecord> ComponentsByLocator =
			new Dictionary<Url, ComponentRecord>();
		
		

		public static void Register<TComponent>(Url locator, TComponent data) where TComponent : IComponent
		{
			throw new NotImplementedException();
		}
		
		
		public static TComponent At<TComponent>(ComponentLocator locator)
			where TComponent : IUserComponent, new()
		{
			var url = locator.FetchUrl();

			if (ComponentsByLocator.TryGetValue(url, out var existingRecord))
			{
				if (!existingRecord.type.IsAssignableTo(typeof(TComponent)))
				{
					throw new InvalidCastException(
						$"Requesting component of type {typeof(TComponent).Name}, but record for component is {existingRecord.type.Name}");
				}
				else
					return (dynamic)existingRecord.data;
			}
			else
			{
				Defold.pprint($"Component of type ({typeof(TComponent).Name}) at the specified address could not be found.");
				Defold.pprint(url);
				throw new KeyNotFoundException();
			}
		}


		public static TComponent At<TComponent>(ComponentLocator locator, bool cacheInternals)
			where TComponent : IBuiltInComponent, new()
		{
				var url = locator.FetchUrl();

				if (ComponentsByLocator.TryGetValue(url, out var existingRecord))
				{
					if (!existingRecord.type.IsAssignableTo(typeof(TComponent)))
					{
						throw new InvalidCastException(
							$"Requesting component of type {typeof(TComponent).Name}, but record for component is {existingRecord.type.Name}");
					}
					else
						return (dynamic)existingRecord.data;
				}
				else
				{
					var newComponent = new TComponent();
					newComponent.AssignLocator(locator);
					existingRecord = new ComponentRecord(typeof(TComponent), newComponent);
					ComponentsByLocator.Add(url, existingRecord);
					if (cacheInternals)
						newComponent.EnableCaching();
					return newComponent;
				}
		}
	}
}