﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DCETRuntime_ParserStateWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(DCETRuntime.ParserState));
		L.RegConstant("PacketSize", DCETRuntime.ParserState.PacketSize);
		L.RegConstant("PacketBody", DCETRuntime.ParserState.PacketBody);
		L.EndEnum();
		TypeTraits<DCETRuntime.ParserState>.Check = CheckType;
		StackTraits<DCETRuntime.ParserState>.Push = Push;
	}

	static void Push(IntPtr L, DCETRuntime.ParserState arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(DCETRuntime.ParserState), L, pos);
	}
}

