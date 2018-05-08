using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  通过在 内部包装 一个 Adaptee  对象,把 源接口转换成 目标接口  
/// </summary>
  class Adapter :  Target
{
    private Adaptee adaptee = new Adaptee();  

    public override void Request()
    {
        adaptee.SpecificRequest();  
      
    }
}
