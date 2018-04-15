using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  具体的 建造者类
/// </summary>
 class ConcreteBuilder : Builder
{
   
  
    private Product product = new Product();
    /// <summary>
    ///  建造   A 部分
    /// </summary>
    public override void BuildPartA()
    {
        Debug.Log("建造A部分"); 
    }

    public override void BuildPartB()
    {
        Debug.Log("建造A部分"); 
    }

    /// <summary>
    ///  得到  结果 
    /// </summary>
    public override Product  GetResult()
    {
        return product; 
    }

    
}
