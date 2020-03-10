﻿using System;
using System.IO;

namespace DCET
{
	public class MongoPacker: IMessagePacker
	{
		public byte[] SerializeTo(object obj)
		{
			return DCETRuntime.MongoHelper.ToBson(obj);
		}

		public void SerializeTo(object obj, MemoryStream stream)
		{
			DCETRuntime.MongoHelper.ToBson(obj, stream);
		}

		public object DeserializeFrom(Type type, byte[] bytes, int index, int count)
		{
			return DCETRuntime.MongoHelper.FromBson(type, bytes, index, count);
		}

		public object DeserializeFrom(object instance, byte[] bytes, int index, int count)
		{
			return DCETRuntime.MongoHelper.FromBson(instance, bytes, index, count);
		}

		public object DeserializeFrom(Type type, MemoryStream stream)
		{
			return DCETRuntime.MongoHelper.FromStream(type, stream);
		}

		public object DeserializeFrom(object instance, MemoryStream stream)
		{
			return DCETRuntime.MongoHelper.FromBson(instance, stream);
		}
	}
}
