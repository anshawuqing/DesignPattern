using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 用来声明   执行操作的接口
/// </summary>
 abstract  class Command
{

    /// <summary>
    ///  
    /// </summary>
    protected Receiver receiver;

    /// <summary>
    ///  
    /// </summary>
    /// <param name="receiver"></param>
    public  Command (Receiver  receiver)
    {
          
    }

    /// <summary>
    /// 
    /// </summary>
    abstract public void Execute(); 

    
}
