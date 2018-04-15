using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 建造者模式 建造者抽象类
/// 定义 建造的  抽象接口
/// </summary>
 abstract class Builder : MonoBehaviour {


    /// <summary>
    /// 抽象 方法 建造  A部分
    /// </summary>
    public abstract void BuildPartA();

    /// <summary>
    /// 建造 B部分
    /// </summary>
    public abstract void BuildPartB();


    /// <summary>
    /// 得到  建造的结果
    /// </summary>
    public abstract  Product GetResult();

}
