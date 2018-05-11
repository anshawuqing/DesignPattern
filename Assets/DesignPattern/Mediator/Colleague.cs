using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  中介者 模式 中的 抽象同事类  
/// </summary>
 abstract  class Colleague
{

    /// <summary>
    /// 声明一个 中介者,     
    /// </summary>
    protected Mediator mediator;
   
    /// <summary>
    ///  在 构造函数中 得到 中介者
    /// </summary>
    /// <param name="mediator"> 中介者</param>
    public  Colleague (Mediator  mediator)
    {
      
    } 
      
}
