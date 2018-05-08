using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  管理者
/// </summary>
public class Caretaker
{
    /// <summary>
    /// 设置 备忘录 属性 
    /// </summary>
    private Memento memento;
   
    
     /// <summary>
     ///  得到 或者 设置 备忘录
     /// </summary>
    public  Memento Memento
    {
        get { return memento; }
        set { memento = value; }
    }

   
}
