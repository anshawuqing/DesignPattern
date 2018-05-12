using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 具体状态C
/// </summary>
class ConcreteStateC : State
{
    public override void Handle(Context context)
    {
        Debug.Log("实现状态C"); 
    }
}
