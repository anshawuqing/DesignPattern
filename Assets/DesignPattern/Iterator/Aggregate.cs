﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 聚集抽象类 
/// </summary>
 abstract  class Aggregate
{
     /// <summary>
     /// 创建迭代器
     /// </summary>
     /// <returns></returns>
    public abstract Iterator CreateIterator();
 

}
