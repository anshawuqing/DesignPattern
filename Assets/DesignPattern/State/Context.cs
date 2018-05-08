using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 维护一个 ConcreteState 子类的实例 ,这个实例 定义当前的状态 
/// </summary>
 class Context
{

    /// <summary>
    /// 
    /// </summary>
    private State state;


    /// <summary>
    /// 定义Context 的初始状态
    /// </summary>
    /// <param name="state"></param>
    public  Context   (State   state)
    {
        this.state = state;
    }

    /// <summary>
    ///  可读写的状态属性, 用于读取当卡状态 和 更新最新状态
    /// </summary>
   public  State  State
    {
        get { return state; }
        set
        {
            state = value;
            Debug.Log( "当前状态为"+state);
        }
    }



    public void  Request()
    {
        ///
        state.Handle(this);
    }

}
