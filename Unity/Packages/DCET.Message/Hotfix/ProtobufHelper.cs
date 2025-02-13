﻿#if !__CSharpLua__
using DCETRuntime;
using ProtoBuf.Meta;
#endif
using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace DCET
{
	public static class ProtobufHelper
	{
		static ProtobufHelper()
		{
#if __CSharpLua__
			if (DCETRuntime.Define.IsAsync)
			{
				//int result = DCETRuntime.AssetBundles.Default.CheckRes("outermessage.unity3d", "OuterMessage.txt");
				//Log.Debug("check result:" + result);
				var textAsset = DCETRuntime.AssetBundles.Default.LoadAsset("outermessage.unity3d", "OuterMessage");
				if (textAsset != null && textAsset is TextAsset)
				{
					TextAsset prototxt = textAsset as TextAsset;
					string allmsg = prototxt.text;
					/*
					 [[
							local protoc = require "protoc"
							DCET.Log.Debug("load proto:"..allmsg)
							protoc:load(allmsg)
					 ]]
					 */
				}
			}
			else {
				/*
				[[
						local pb = require "pb"
						pb.loadfile("Assets/Res/Lua/pbc/AutoGeneratedCode/OuterMessage.pb")
				]]
				*/
			}
#endif
		}

		public static void ToStream(object message, MemoryStream memoryStream)
		{
#if !__CSharpLua__
			RuntimeTypeModel.Default.Serialize(memoryStream, message);
#else
			byte[] bytes = null;

			/*
			[[
			 bytes = encodeProtobuf(message)
			]]
			*/

			DCETRuntime.StreamHelper.WriteBytes(memoryStream, bytes);
#endif
		}

		public static object FromStream(object message, MemoryStream memoryStream)
		{
			if(message != null)
			{
#if !__CSharpLua__
				return RuntimeTypeModel.Default.Deserialize(memoryStream, null, message.GetType());
#else
				byte[] bytes = DCETRuntime.StreamHelper.ReadBytes(memoryStream, DCET.Packet.MessageIndex);

				if(bytes != null)
				{
					/*
					[[
					return decodeProtobuf(bytes, message)
					]]
					*/
				}
#endif
			}

			return null;
		}
	}
}