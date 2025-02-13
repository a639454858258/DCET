﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class PFEndingConditionDistanceWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(PF.EndingConditionDistance);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 1, 1);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TargetFound", _m_TargetFound);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmaxGScore", _g_get_maxGScore);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmaxGScore", _s_set_maxGScore);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxGScore", _g_get_maxGScore);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxGScore", _s_set_maxGScore);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
            
			
			
			
			
			
            
			
			
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<PF.Path>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					PF.Path _p = (PF.Path)translator.GetObject(L, 2, typeof(PF.Path));
					int _maxGScore = LuaAPI.xlua_tointeger(L, 3);
					
					PF.EndingConditionDistance gen_ret = new PF.EndingConditionDistance(_p, _maxGScore);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to PF.EndingConditionDistance constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TargetFound(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                PF.EndingConditionDistance gen_to_be_invoked = (PF.EndingConditionDistance)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    PF.PathNode _node = (PF.PathNode)translator.GetObject(L, 2, typeof(PF.PathNode));
                    
                        bool gen_ret = gen_to_be_invoked.TargetFound( 
                        _node );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxGScore(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PF.EndingConditionDistance gen_to_be_invoked = (PF.EndingConditionDistance)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.maxGScore);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxGScore(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PF.EndingConditionDistance gen_to_be_invoked = (PF.EndingConditionDistance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxGScore = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
