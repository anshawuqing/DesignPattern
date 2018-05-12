using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 适配器模式的  客户端代码
/// </summary>
public class AdapterMain : MonoBehaviour {


    /// <summary>
    ///  
    /// </summary>
     void miain ()
    {
        Target target = new Adapter ();  //新建一个 私有的    
        target.Request();   //首先调用的是  普通请求
                                     //然后调用的是  特殊请求 
         
    } 
 
}
