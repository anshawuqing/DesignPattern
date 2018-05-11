using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// </summary>
class Invoker
{
    /// <summary>
    /// 
    /// </summary>
    private Command command;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
   public void  SetCommand  ( Command command)
    {
        this.command = command;
    }

    /// <summary>
    ///  
    /// </summary>
    public void  ExecuteCommand()
    {
        command.Execute();
    }
}
