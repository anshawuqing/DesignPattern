using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
/// <summary>
///  享元模式 抽象类
/// 所有享元类的超类或接口，通过这接口 Flyweight 可以接受并作用于外部状态
/// </summary>
 abstract  class Flyweight
{
    /// <summary>
    ///  享元 类的抽象接口
    /// </summary>
    /// <param name="extrinsicstate"></param>
    public abstract void Operation(int extrinsicstate);
}
