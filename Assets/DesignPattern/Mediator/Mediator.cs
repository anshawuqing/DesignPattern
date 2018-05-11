using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  抽象中介者,定义了 同事对象到中介者之间的接口
/// </summary>
abstract   class Mediator
{
    /// <summary>
    ///   定义一个抽象的 发送消息的方法，得到同事对象和 发送对象
    /// </summary>
    /// <param name="message"></param>
    /// <param name="colleage"></param>
    public abstract void Send(string message, Colleague colleage);

    internal void Send()
    {
        throw new NotImplementedException();
    }
}
