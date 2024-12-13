using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class xLuaTest : MonoBehaviour
{
    private LuaEnv luaEnv;
    // Start is called before the first frame update
    void Start()
    {
        luaEnv = new LuaEnv();
        luaEnv.DoString("print('hello Lua')");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        luaEnv.Dispose();
    }
}
