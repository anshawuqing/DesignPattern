using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 具体迭代器 
/// </summary>
class ConcreteIterator : Iterator
{

    /// <summary>
    /// 定义 一个具体的聚集对象
    /// </summary>
    private ConcreteAggregate aggregate;

    /// <summary>
    /// 
    /// </summary>
    private int current = 0;

   /// <summary>
   ///  初始化时将 具体的聚集对象传入 
   /// </summary>
   /// <param name="aggregate"></param>
   public ConcreteIterator ( ConcreteAggregate   aggregate)
    {
        this.aggregate = aggregate;
    }

    /// <summary>
    ///  
    /// </summary>
    /// <returns></returns> 
    public override object CurrentItem()
    {
        return aggregate[ current ];     
    }

    public override object First()
    {
        return aggregate[0];
    }

    public override bool IsDone() 
    {
        return current >= aggregate.Count ? true : false; 
    }

   /// <summary>
   /// 
   /// </summary>
   /// <returns></returns>
    public override object Next()
    {
        object ret = null;
        current++;
        if ( current  < aggregate.Count)
        {
            ret = aggregate[current];
        }

        return ret;
    }
   
}
