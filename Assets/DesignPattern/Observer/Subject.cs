using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;

/// <summary>
///  它把 所有对观察者对象的引用 保存在一个聚集里‘
/// 每个主题都可以有 任何数量的观察者。抽象主题可以提供一个接口
/// 可以增加和删除 观察者 对象
/// </summary>
abstract  class Subject
{

    private IList<Observer> observers = new List<Observer>();   //定义观察者的集合
    
 

    /// <summary>
    ///  增加观察者
    /// </summary>
    /// <param name="observer"></param>
    public void Attach(Observer  observer)
    {
        observers.Add(observer);
    }

    /// <summary>
    ///  移除观察者
    /// </summary>
    /// <param name="observer"></param>
    public  void  Detach( Observer  observer)
    {
        observers.Remove(observer);
    }


    /// <summary>
    /// 通知观察者 
    /// </summary>
  public void Notify()
    {
        foreach (  Observer o  in observers ) 
        {
            o.Update();
        }
    }
}
