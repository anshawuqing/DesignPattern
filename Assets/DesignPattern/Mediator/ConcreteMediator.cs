using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  具体的  中介者类
/// </summary>
class ConcreteMediator : Mediator
{

  
    /// <summary>
    /// 设置具体 通知对象的属性 
    /// </summary>
    private ConcreteColleague1 colleague1;
   
    /// <summary>
    /// 设置 第二的通知对象 
    /// </summary>
    private ConcreteColleague2 colleague2;

    /// <summary>
    ///  设置 
    /// </summary>
     public  ConcreteColleague1 Colleague1
    {
        set { colleague1 = value; }
    }

    /// <summary>
    /// 
    /// </summary>
    public ConcreteColleague2 Colleague2
    {
        set { colleague2 = value; }
    }


   
 /// <summary>
 ///  重写发送信息的方法，根据对象做出选择 和判断 ，通知对象 
 /// </summary>
 /// <param name="message">要发送的信息 </param>
 /// <param name="colleage" >  具体的通知者 </param>
    public override void Send(string message, Colleague colleage)
    {
        if ( colleage == colleague1)
        {
            colleague1.Notify( message);
        }
        else
        {
            colleague2.Notify( message);
        } 
         
    }
}
