using System;
using System.Collections;
using System.Collections.Generic;
using types;

namespace support
{
	public class GameObjectReference
	{
		
		public static GameObjectReference CurrentGameObject { get; set; }
		
		public bool isDestroyed = false;
		
		public GameObjectReference(Url locatorUrl)
		{
			LocatorUrl = locatorUrl;
		}


		public Url LocatorUrl { get; }
		
		
		
		public vector3 Position
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_position();
				return Go.get_position(LocatorUrl);
			}
			set
			{
				if (CurrentGameObject == this)
					Go.set_position(value);
				else
					Go.set_position(value, LocatorUrl);
			}
		}




		public Quaternion Rotation
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_rotation();
				return Go.get_rotation(LocatorUrl);
			}
			set
			{
				if (CurrentGameObject == this)
					Go.set_rotation(value);
				else
					Go.set_rotation(value, LocatorUrl);
			}
		}


		public vector3 Scale
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_scale();
				return Go.get_scale(LocatorUrl);
			}
			set
			{
				if (CurrentGameObject == this)
					Go.set_scale(value);
				else
				Go.set_scale(value, LocatorUrl);
			}
		}
		
		public double UniformScale
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_scale_uniform();
				return Go.get_scale_uniform(LocatorUrl);
			}
		}
		
		
		public vector3 WorldPosition
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_world_position();
				return Go.get_world_position(LocatorUrl);
			}
		}
		
		public Quaternion WorldRotation
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_world_rotation();
				return Go.get_world_rotation(LocatorUrl);
			}
		}

		public vector3 WorldScale
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_world_scale();
				return Go.get_world_scale(LocatorUrl);
			}
		}

		public double WorldScaleUniform
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_world_scale_uniform();
				return Go.get_world_scale_uniform(LocatorUrl);
			}
		}


		public Matrix4 WorldTransform
		{
			get
			{
				if (CurrentGameObject == this)
					return Go.get_world_transform();
				return Go.get_world_transform(LocatorUrl);
			}
		}


		public T GetProperty<T>(__Hash2 property) where T : unmanaged, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
		{
			return (dynamic)Go.get(LocatorUrl, property.ToHash());
		}
		public string GetProperty<T>(__Hash3 property) where T : IComparable, IEnumerable, IConvertible, IEnumerable<char>, IComparable<String>, IEquatable<String>
		{
			return (dynamic)Go.get(LocatorUrl, property.ToHash());
		}
		public T GetProperty<T>(Hash property) where T:ILuaType
		{
			return (dynamic)Go.get(LocatorUrl, property);
		}
		
		public void SetProperty<T>(__Hash2 property, T value) where T : unmanaged, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
		{
			Go.set(LocatorUrl, property.ToHash(), (dynamic)value);
		}
		public void SetProperty<T>(__Hash3 property, string value) where T : IComparable, IEnumerable, IConvertible, IEnumerable<char>, IComparable<String>, IEquatable<String>
		{
			Go.set(LocatorUrl, property.ToHash(), value);
		}
		public void SetProperty<T>(Hash property, T value) where T:ILuaType
		{
			Go.set(LocatorUrl, property, (dynamic)value);
		}


		public void Delete()
		{
			isDestroyed = true;
			Go.delete(LocatorUrl);
		}
		
		/// <summary>
		/// A convenience shortcut for Component.At that handles fetching the Component relative
		/// to this gameobject.
		/// </summary>
		/// <param name="hash"></param>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public T Component<T>(Hash hash) where T : IComponent, new()
		{
			var targetUrl = new Url();
			targetUrl.socket = LocatorUrl.socket;
			targetUrl.path = LocatorUrl.path;
			targetUrl.fragment = hash;

			return support.Component.At<T>(Locator.AtUrl(targetUrl));
		}
		
		
		//TODO:Animations

	}
}