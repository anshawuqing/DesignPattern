using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 观察者模式
/// 抽象观察者，为所有的具体观察者定义一个 接口 ，在得到主题的
/// 通知时更新自己
/// </summary>
 abstract  class Observer
 {
 

    /// <summary>
    ///抽象的更新方法
    /// </summary>
    public abstract void Update(); 
 



}
