using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 定义有枝节点 的行为，用来存储 子部件 在接口中实现与 子部件 
/// 有关的 操作
/// </summary>
class Composite : Component_C
{
    private List<Component_C> Children = new List<Component_C>();


    public Composite(string name) : base(name)
    {
       
    }

    /// <summary>
    /// 添加节点
    /// </summary>
    /// <param name="c"></param>
    public override void Add(Component_C c)
    {
        Children.Add(c);
    }
 
    /// <summary>
    /// 显示节点的长度
    /// </summary>
    /// <param name="depth"></param>
    public override void Display(int depth)
    {
        Debug.Log("节点的长度"+ depth );

    }

    /// <summary>
    ///  移除节点
    /// </summary>
    /// <param name="c"></param>
    public override void Remove(Component_C c)
    {
        Children.Remove(c);
    }
}
