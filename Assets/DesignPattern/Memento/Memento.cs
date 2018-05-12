using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  备忘录  负责存储 Originator  的内部状态，并可防止 Originator  以外的其他对象进行访问备忘录 Memento 
///  备忘录有两个接口， 
/// </summary>
public class Memento  
    {

    /// <summary>
    ///  
    /// </summary>
    private string state;


    public  string State
    {
        get { return state; }
    }
    /// <summary>
    ///构造方法 将相关的数据导入 
    /// </summary>
    /// <param name="state"></param>
    public Memento   (string state)
    {
        this.state = state;
    }

}
