using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 建造者模式中的  指挥者 模式
/// </summary>
class PersonDirector   {


    private PersonBuilder PB;
    
    public  PersonDirector (PersonBuilder  PB)
    {
        this.PB = PB;

    }
   
   

   /// <summary>
   // 根据用户选择 建造小人
   /// </summary>
    public void  CreatPerson()
    {
        PB.BuildArmleft();
        PB.BuildBody();
        PB.BuildArmleft();
        PB.BuildArmright();
        PB.BuildLegLeft();
        PB.BuildLegRight();
          //


    }
}
