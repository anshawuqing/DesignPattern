using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 状态A
/// </summary>
class ConcreteStateB : State
{
    
    public override void Handle(Context context)
    {
        Debug.Log("状态B");   
    }
}
