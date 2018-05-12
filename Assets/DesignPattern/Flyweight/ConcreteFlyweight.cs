using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 继承Flyweight  超类 或者 实现 Flyweight  接口
/// </summary>
class ConcreteFlyweight : Flyweight
{


    /// <summary>
    /// 共享的超类实现
    /// </summary>
    /// <param name="extrinsicstate"></param>
    public override void Operation(int extrinsicstate)
    {
        Debug.Log("实现具体的 超类");    
    }

}
