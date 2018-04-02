using UnityEngine;
using System.Collections;
using System;


/// <summary>
/// 定义了一个具体的对象，可以给这些对象动态的添加一些职责
/// </summary>
class ConcreteComponent : Component
{


    public override void Operation()
    {

        Debug.Log("具体对象的操作");
    }

}
