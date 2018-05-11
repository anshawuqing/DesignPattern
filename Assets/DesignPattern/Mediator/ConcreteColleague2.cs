using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ConcreteColleague2 :Colleague 
    {
    public ConcreteColleague2(Mediator mediator) : base(mediator)
    {
    }



    /// <summary>
    ///   发送消息
    /// </summary>
    public void Send(string message)
    {

        /// 发送消息  (通常是中介者  进行发送消息)
        mediator.Send(message, this);
    }

    /// <summary>
    ///  通知同事得到 消息 
    /// </summary>
    public void Notify(string message)
    {
        Debug.Log("同事2 得到消息" + message);
    }
}
