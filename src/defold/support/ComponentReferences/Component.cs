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
		private class ComponentRecord
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


		public static bool DefaultToCaching = true;

		private static Type builtInType = typeof(IBuiltInComponent);
		private static Type userComponentType = typeof(IUserComponent);


		public static void Register<TComponent>(Url locator, TComponent data) where TComponent : IComponent
		{
			var newRecord = new ComponentRecord(typeof(TComponent), data);
			ComponentsByLocator.Add(locator, newRecord);
		}


		public static void Unregister(Url locator)
		{
			ComponentsByLocator.Remove(locator);
		}

		
		
		public static TComponent At<TComponent>(ComponentLocator locator)
			where TComponent : IComponent, new()
		{
			if (builtInType.IsAssignableFrom(typeof(TComponent)))
				return AtBuiltIn<TComponent>(locator);
			
			if (userComponentType.IsAssignableFrom(typeof(TComponent)))
				return AtUser<TComponent>(locator);
			
			Defold.pprint($"Unhandled component type!  {typeof(TComponent).Name}");
			throw new NotImplementedException();
		}

		
		/// <summary>
		/// Specialized variant that will handle a USERCOMPONENT only.  But exists as an unsafe private that supposedly
		/// allows any component.  However, it really only supports IUserComponent.
		/// </summary>
		/// <param name="locator"></param>
		/// <typeparam name="TComponent"></typeparam>
		/// <returns></returns>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="KeyNotFoundException"></exception>
		private static TComponent AtUser<TComponent>(ComponentLocator locator)
			where TComponent : IComponent, new()
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
				Defold.pprint(
					$"Component of type ({typeof(TComponent).Name}) at the specified address could not be found.");
				Defold.pprint(url);
				throw new KeyNotFoundException();
			}
		}


		/// <summary>
		/// Specialized variant that will handle a USERCOMPONENT only.  But exists as an unsafe private that supposedly
		/// allows any component.  However, it really only supports IBuiltInComponent.
		/// </summary>
		/// <param name="locator"></param>
		/// <typeparam name="TComponent"></typeparam>
		/// <returns></returns>
		/// <exception cref="InvalidCastException"></exception>
		/// <exception cref="KeyNotFoundException"></exception>
		private static TComponent AtBuiltIn<TComponent>(ComponentLocator locator)
			where TComponent : IComponent, new()
		{
			var url = locator.FetchUrl();

			
			//Built in components are not cached, because we cannot determine when they are cleared.

			IBuiltInComponent newComponent = (dynamic)new TComponent();
			newComponent.AssignLocator(locator);
			Register<TComponent>(url, (dynamic)newComponent);
			return (dynamic)newComponent;
		}
	}
}