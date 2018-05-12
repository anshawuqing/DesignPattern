using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  被 提炼的抽象类
/// </summary>
  class RefinedAbstraction :  Abstraction
{

    public override void Operation()
    {
        implementor.Operation();
    }

}
