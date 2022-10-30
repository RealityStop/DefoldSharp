using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using types;

namespace support
{
	public class GameObjectReference
	{
		public bool isDestroyed = false;
		
		public GameObjectReference(Url locatorUrl)
		{
			LocatorUrl = locatorUrl;
		}


		public Url LocatorUrl { get; }
		
		
		
		public Vector3 Position
		{
			get
			{
				return Go.get_position(LocatorUrl);
			}
			set
			{
				Go.set_position(value, LocatorUrl);
			}
		}


		

		public Quaternion Rotation
		{
			get
			{
				return Go.get_rotation(LocatorUrl);
			}
			set
			{
				Go.set_rotation(value, LocatorUrl);
			}
		}


		public Vector3 Scale
		{
			get
			{
				return Go.get_scale(LocatorUrl);
			}
			set
			{
				Go.set_scale(value, LocatorUrl);
			}
		}
		
		public double UniformScale
		{
			get
			{
				return Go.get_scale_uniform(LocatorUrl);
			}
		}
		
		
		public Vector3 WorldPosition
		{
			get
			{
				return Go.get_world_position(LocatorUrl);
			}
		}
		
		public Quaternion WorldRotation
		{
			get
			{
				return Go.get_world_rotation(LocatorUrl);
			}
		}

		public Vector3 WorldScale
		{
			get
			{
				return Go.get_world_scale(LocatorUrl);
			}
		}

		public double WorldScaleUniform
		{
			get
			{
				return Go.get_world_scale_uniform(LocatorUrl);
			}
		}


		public Matrix4 WorldTransform
		{
			get
			{
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