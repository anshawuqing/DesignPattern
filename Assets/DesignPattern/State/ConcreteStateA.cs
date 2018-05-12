using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        Debug.Log("状态A");
    }
}
