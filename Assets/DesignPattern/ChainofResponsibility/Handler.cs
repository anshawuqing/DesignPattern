using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  职责链模式
/// </summary>
abstract  class Handler
{

    /// <summary>
    ///  
    /// </summary>
    protected Handler successor;


    /// <summary>
    ///  设置 继任者
    /// </summary>
    /// <param name="successor"></param>
    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    /// <summary>
    ///  处理请求的抽象 方法
    /// </summary>
    /// <param name="request"></param>
    public abstract void HendleRequest(int request); 
   

   
}
