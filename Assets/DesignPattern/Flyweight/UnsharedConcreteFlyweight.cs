using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  
/// </summary>
class UnsharedConcreteFlyweight : Flyweight
{

    /// <summary>
    /// 不共享的超类的实现 
    /// </summary>
    /// <param name="extrinsicstate"></param>
    public override void Operation(int extrinsicstate)
    {
        Debug.Log("不共享的超类的实现"); 
    }
}
