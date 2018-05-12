using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  B 的 具体实现
/// </summary>
class ConcreteImplementorB : Implementor
{
    public override void Operation()
    {
        Debug.Log( "B的 具体实现"); 
    }
}
