using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  在 组合中表示叶节点 对象,叶节点没有子节点
/// </summary>
class Leaf : Component_C
{
    public Leaf(string name) : base(name)
    {
        
    }

    public override void Add(Component_C c)
    {
        Debug.Log("无法添加节点");
    }


    /// <summary>
    /// 显示节点的名称和级别
    /// </summary>
    /// <param name="depth"></param>
    public override void Display(int depth)
    {
        Debug.Log( new  String('-',depth)+name ); 
    }

    
    public override void Remove(Component_C c)
    {
        Debug.Log("无法删除节点");
    }
}
