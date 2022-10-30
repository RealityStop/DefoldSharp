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
		
		public GameObjectReference(Url locator)
		{
			Locator = locator;
		}


		public Url Locator { get; }
		
		
		
		public Vector3 Position
		{
			get
			{
				return Go.get_position(Locator);
			}
			set
			{
				Go.set_position(value, Locator);
			}
		}


		

		public Quaternion Rotation
		{
			get
			{
				return Go.get_rotation(Locator);
			}
			set
			{
				Go.set_rotation(value, Locator);
			}
		}


		public Vector3 Scale
		{
			get
			{
				return Go.get_scale(Locator);
			}
			set
			{
				Go.set_scale(value, Locator);
			}
		}
		
		public double UniformScale
		{
			get
			{
				return Go.get_scale_uniform(Locator);
			}
		}
		
		
		public Vector3 WorldPosition
		{
			get
			{
				return Go.get_world_position(Locator);
			}
		}
		
		public Quaternion WorldRotation
		{
			get
			{
				return Go.get_world_rotation(Locator);
			}
		}

		public Vector3 WorldScale
		{
			get
			{
				return Go.get_world_scale(Locator);
			}
		}

		public double WorldScaleUniform
		{
			get
			{
				return Go.get_world_scale_uniform(Locator);
			}
		}


		public Matrix4 WorldTransform
		{
			get
			{
				return Go.get_world_transform(Locator);
			}
		}


		public T GetProperty<T>(__Hash2 property) where T : unmanaged, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
		{
			return (dynamic)Go.get(Locator, property.ToHash());
		}
		public string GetProperty<T>(__Hash3 property) where T : IComparable, IEnumerable, IConvertible, IEnumerable<char>, IComparable<String>, IEquatable<String>
		{
			return (dynamic)Go.get(Locator, property.ToHash());
		}
		public T GetProperty<T>(Hash property) where T:ILuaType
		{
			return (dynamic)Go.get(Locator, property);
		}
		
		public void SetProperty<T>(__Hash2 property, T value) where T : unmanaged, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
		{
			Go.set(Locator, property.ToHash(), (dynamic)value);
		}
		public void SetProperty<T>(__Hash3 property, string value) where T : IComparable, IEnumerable, IConvertible, IEnumerable<char>, IComparable<String>, IEquatable<String>
		{
			Go.set(Locator, property.ToHash(), value);
		}
		public void SetProperty<T>(Hash property, T value) where T:ILuaType
		{
			Go.set(Locator, property, (dynamic)value);
		}


		public void Delete()
		{
			isDestroyed = true;
			Go.delete(Locator);
		}
		
		//TODO:Animations
	}
}