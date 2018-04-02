using UnityEngine;
using System.Collections;


/// <summary>
/// 装饰的抽象类
/// </summary>
abstract class Decorator :Component
{

    /// <summary>
    /// 
    /// </summary>
    protected Component component;


    /// <summary>
    /// 设置  Component 
    /// </summary>
    /// <param name="component"></param>
    public void SetComponent( Component component)
    {
        this.component = component;  
    }


    /// <summary>
    /// 重写 Operation
    /// </summary>
    public override  void  Operation()
    {
         if(component != null)
        {
            component.Operation(); 
        } 
    }
    
}
