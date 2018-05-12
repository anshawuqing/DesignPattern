using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
class ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver) : base(receiver)
    {

    }


    public override void Execute()
    {
        receiver.Action();
    }
}
