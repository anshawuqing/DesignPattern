using UnityEngine;
using System.Collections;

/// <summary>
/// 具体的装饰对象,起到  给 Component  添加职责的功能
/// </summary>
 class ConcreteDecoratorA :  Decorator {

   
    private string AddedState;

    public override void Operation()
    {
        base.Operation();
        AddedState = "new state";
        Debug.Log("具体装饰对象A 的操作");
    }


    /// <summary>
    /// 该类独有的方法 
    /// </summary>
  private void AddeBehavior()
    {

    }

}
