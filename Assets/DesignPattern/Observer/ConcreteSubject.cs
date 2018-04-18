using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///具体主题 或者  具体通知者 ,将有关对象存入 观察者对象；在具体主题的内部状态发生改变的
///时，给所有登记过的观察者发出通知。具体主题角色通常通过一个具体的子类进行实现
///
/// </summary>
  class ConcreteSubject :Subject {
 
    //具体 被观察者的状态
    private string subjectState;


    /// <summary>
    ///更改具体观察者的状态
    /// </summary>
    public string SubjectState
    {
        get { return subjectState; }

        set { subjectState = value; }
    }

  
}