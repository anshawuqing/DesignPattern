using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  备忘录 模式 的客户端程序
/// </summary>
public class MementoMain
{
    void  Main ()
    {
        Originator o = new Originator();   //创建 一个发起人
        o.State = "On";  // 更改状态
        o.Show();  //显示状态

       
        Caretaker C = new Caretaker();  //创建一个  管理者
        C.Memento = o.CreateMemento();   //创建备忘录 保存状态 

        o.State = "off";
        o.Show();

        //恢复原始 初始状态
       
        o.SetMemento(C.Memento);
        o.Show();
       
    }
     
}
