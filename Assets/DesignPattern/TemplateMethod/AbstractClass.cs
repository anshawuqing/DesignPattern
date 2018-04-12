using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  模板模式  抽象类
/// </summary>
abstract  class AbstractClass  {

    public abstract void PrimitiveOperation1();
   
    //定义抽象方法 在子类中进行实现	
    public abstract void PrimitiveOperation2();

    /// <summary>
    ///  
    /// </summary>
    public void  TemplateMethod()
    {
       PrimitiveOperation1();
       PrimitiveOperation2();

        Debug.Log("");

    }
  
}
