using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 建造模式 的指挥者 类，
///  根据用户需求   指挥建造  产品
/// </summary>
class Director   {

    public void Construct(Builder builder)
    {
        builder.BuildPartA();  //建造部分 A
        builder.BuildPartB();   //建造 部分B
    }

	}
