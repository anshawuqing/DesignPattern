using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 建造者模式
/// </summary>
class PersonThinBuilder : PersonBuilder  {

  public  PersonThinBuilder (Graphics g, Sprite s) : base ( g,s)
    {
    
    }



    /// <summary>
    /// 
    /// </summary>
    public override void BuildArmleft()
    {
           
    }

    public override void BuildArmright()
    {
        throw new System.NotImplementedException();
    }

    public override void BuildBody()
    {
        throw new System.NotImplementedException();
    }

    public override void BuildHead()
    {
        throw new System.NotImplementedException();
    }

    public override void BuildLegLeft()
    {
        throw new System.NotImplementedException();
    }

    public override void BuildLegRight()
    {
        throw new System.NotImplementedException();
    }
}
