﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  具体的聚集 类
/// </summary>
 class ConcreteAggregate :  Aggregate
{
    private IList<object> items = new List<object>();

   

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override Iterator CreateIterator()  
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get { return items.Count; }
     }

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}
