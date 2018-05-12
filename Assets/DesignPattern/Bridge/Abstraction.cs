using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
///抽象类 
/// </summary>
  class Abstraction
{

    /// <summary>
    ///  
    /// </summary>
    protected Implementor implementor;

    /// <summary>
    ///   
    /// </summary>
    /// <param name="implementor"></param>
    public  void SetImplementor(Implementor implementor )
    {
        this.implementor = implementor;
    }

    /// <summary>
    ///  
    /// </summary>
    public virtual void Operation()
    {
        implementor.Operation();   
    }
}
