using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  组合模式 
/// </summary>
abstract class Component_C
{
    /// <summary>
    /// 名称
    /// </summary>
    protected string name;

    /// <summary>
    /// 带参数的构造函数
    /// </summary>
    /// <param name="name">姓名</param>
    public Component_C(string name)
    {
        this.name = name;
    }


    /// <summary>
    /// 添加节点
    /// </summary>
    /// <param name="c"></param>
    public abstract void Add(Component_C c);

    /// <summary>
    /// 删除节点
    /// </summary>
    /// <param name="c"></param>
    public abstract void Remove(Component_C c);


    /// <summary>
    /// 显示
    /// </summary>
    /// <param name="depth"></param>
    public abstract void Display(int depth);
}
