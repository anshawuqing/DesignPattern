using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 具体的 同事对象
/// </summary>
class ConcreteColleague1 : Colleague
{
     /// <summary>
     ///  在构造函数中 
     /// </summary>
     /// <param name="mediator"></param>
    public ConcreteColleague1(Mediator mediator) : base(mediator)
    {      }


    /// <summary>
    ///   发送消息
    /// </summary>
    public void  Send( string message)
    {
   
        /// 发送消息  (通常是中介者  进行发送消息)
        mediator.Send(message ,this); 
    }

    /// <summary>
    ///  通知同事得到 消息 
    /// </summary>
    public void  Notify(string message)
    {
        Debug.Log("同事1 得到消息"+message); 
    }
}
