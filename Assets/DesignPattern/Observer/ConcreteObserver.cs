using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 具体观察者  实现抽象观察者角色所要求的的更新接口
/// 以便使本身的状态与主题的状态相协同
/// 具体的观察者角色 可以保存一个指向具体主题对象的引用。
/// 具体观察者角色通常用一个具体子类去实现
/// </summary>
   class ConcreteObserver : Observer
{ // Use this for initialization
    
    /// <summary>
    /// 观察者的姓名
    /// </summary>
    private string name;

    /// <summary>
    /// 主题z观察者的状态
    /// </summary>
    private string ObserverState;

    /// <summary>
    /// 具体的  主题对象
    /// </summary>
    private ConcreteSubject subject;


    /// <summary>
    ///
    /// </summary>
    /// <param name="subject"></param>
    /// <param name="name"></param>
    public   ConcreteObserver (ConcreteSubject subject , string name)
    {
        this.subject = subject;
        this.name = name;
    }
   
    public override void Update()
    {
        ObserverState = subject.SubjectState;
        Debug.Log("观察者" + name + "的状态是" + ObserverState); 
    }
 
    /// <summary>
    /// 构造函数 初始化 
    /// </summary>
   public ConcreteSubject Subject
    {
        get { return subject; } 
         set { subject = value; }
    }
   
}
