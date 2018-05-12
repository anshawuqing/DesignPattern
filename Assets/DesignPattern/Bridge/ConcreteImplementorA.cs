using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// A 的具体实现
/// </summary>
class ConcreteImplementorA :  Implementor
{
    public override void Operation()
    {
        Debug.Log("A_的具体实现");
    }

}
