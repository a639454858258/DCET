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
    public class FairyGUIInputTextFieldWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyGUI.InputTextField);
			Utils.BeginObjectRegister(type, L, translator, 0, 31, 15, 11);
			
            			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSelection", _m_SetSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReplaceSelection", _m_ReplaceSelection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReplaceText", _m_ReplaceText);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
						
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getmaxLength", _g_get_maxLength);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getkeyboardInput", _g_get_keyboardInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getkeyboardType", _g_get_keyboardType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "geteditable", _g_get_editable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gethideInput", _g_get_hideInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonFocusIn", _g_get_onFocusIn);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonFocusOut", _g_get_onFocusOut);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonChanged", _g_get_onChanged);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getonSubmit", _g_get_onSubmit);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettext", _g_get_text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "gettextFormat", _g_get_textFormat);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getrestrict", _g_get_restrict);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getcaretPosition", _g_get_caretPosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getpromptText", _g_get_promptText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "getdisplayAsPassword", _g_get_displayAsPassword);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "setmaxLength", _s_set_maxLength);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setkeyboardInput", _s_set_keyboardInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setkeyboardType", _s_set_keyboardType);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "seteditable", _s_set_editable);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "sethideInput", _s_set_hideInput);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settext", _s_set_text);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "settextFormat", _s_set_textFormat);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setrestrict", _s_set_restrict);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setcaretPosition", _s_set_caretPosition);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setpromptText", _s_set_promptText);
            Utils.RegisterFunc(L, Utils.METHOD_IDX, "setdisplayAsPassword", _s_set_displayAsPassword);
            
						
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxLength", _g_get_maxLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardInput", _g_get_keyboardInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "keyboardType", _g_get_keyboardType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "editable", _g_get_editable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hideInput", _g_get_hideInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFocusIn", _g_get_onFocusIn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onFocusOut", _g_get_onFocusOut);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onChanged", _g_get_onChanged);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "onSubmit", _g_get_onSubmit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "text", _g_get_text);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "textFormat", _g_get_textFormat);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "restrict", _g_get_restrict);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "caretPosition", _g_get_caretPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "promptText", _g_get_promptText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "displayAsPassword", _g_get_displayAsPassword);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxLength", _s_set_maxLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardInput", _s_set_keyboardInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "keyboardType", _s_set_keyboardType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "editable", _s_set_editable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hideInput", _s_set_hideInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "text", _s_set_text);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "textFormat", _s_set_textFormat);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "restrict", _s_set_restrict);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "caretPosition", _s_set_caretPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "promptText", _s_set_promptText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "displayAsPassword", _s_set_displayAsPassword);
            
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 9, 2, 2);
			
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getonCopy", _g_get_onCopy);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getonPaste", _g_get_onPaste);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "setonCopy", _s_set_onCopy);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "setonPaste", _s_set_onPaste);
            
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onCopy", _g_get_onCopy);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onPaste", _g_get_onPaste);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onCopy", _s_set_onCopy);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "onPaste", _s_set_onPaste);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					FairyGUI.InputTextField gen_ret = new FairyGUI.InputTextField();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyGUI.InputTextField constructor!");
            
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSelection(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _start = LuaAPI.xlua_tointeger(L, 2);
                    int _length = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetSelection( 
                        _start, 
                        _length );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReplaceSelection(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.ReplaceSelection( 
                        _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReplaceText(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.ReplaceText( 
                        _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.UpdateContext _context = (FairyGUI.UpdateContext)translator.GetObject(L, 2, typeof(FairyGUI.UpdateContext));
                    
                    gen_to_be_invoked.Update( 
                        _context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
			
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.maxLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.keyboardInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_keyboardType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.keyboardType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_editable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.editable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hideInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hideInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFocusIn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onFocusIn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onFocusOut(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onFocusOut);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onChanged);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onSubmit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onSubmit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.text);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_textFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.textFormat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_restrict(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.restrict);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_caretPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.caretPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_promptText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.promptText);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_displayAsPassword(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.displayAsPassword);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onCopy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.InputTextField.onCopy);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onPaste(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, FairyGUI.InputTextField.onPaste);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxLength = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardInput = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_keyboardType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.keyboardType = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_editable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.editable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hideInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hideInput = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_text(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.text = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_textFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.textFormat = (FairyGUI.TextFormat)translator.GetObject(L, 2, typeof(FairyGUI.TextFormat));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_restrict(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.restrict = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_caretPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.caretPosition = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_promptText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.promptText = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_displayAsPassword(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyGUI.InputTextField gen_to_be_invoked = (FairyGUI.InputTextField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.displayAsPassword = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onCopy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    FairyGUI.InputTextField.onCopy = translator.GetDelegate<FairyGUI.InputTextField.CopyHandler>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_onPaste(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    FairyGUI.InputTextField.onPaste = translator.GetDelegate<FairyGUI.InputTextField.PasteHandler>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
