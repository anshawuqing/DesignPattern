using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  具体的 处理者 类, 处理它所负责的请求
/// </summary>
class ConcreteHandler1 : Handler
{
    /// <summary>
    ///  负责 具体的 请求
    /// </summary>
    /// <param name="request"></param>
    public override void HendleRequest(int request)
    {
        if (request >= 0 && request <=  10)
        {
            Debug.Log(" {0} 的请求");
        }
         else if ( successor !=  null )
        {
            successor.HendleRequest(request);    //  如果为空，就转移到 下一位
        }
    }
}
