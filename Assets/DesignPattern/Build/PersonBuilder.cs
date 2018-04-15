using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 建造者模式的基类
/// </summary>
 abstract  class PersonBuilder
{
    protected Graphics g;
    protected Sprite s;
    

    /// <summary>
    /// 建造者模式的构造函数
    /// </summary>
    /// <param name="g"></param>
    /// <param name="s"></param>
     public PersonBuilder (Graphics g,Sprite s)
    {
        this.g = g;
        this.s = s;
     
    }

    public abstract void BuildHead();

    public abstract void BuildBody();

    public abstract void BuildArmleft();

    public abstract void BuildArmright();

    public abstract void BuildLegLeft();

    public abstract void BuildLegRight();


}
