using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 状态模式的抽象类
/// </summary>
abstract  class State 
{

    /// <summary>
    /// 定义一个接口 以 封装 与 Context的 一个特定状态相关的 行为
    /// </summary>
    /// <param name="context"></param>
    public abstract void Handle(Context context);
  



}
