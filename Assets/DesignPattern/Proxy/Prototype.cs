using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



/// <summary>
///定义原型模式的抽象类
/// </summary>
 abstract    class Prototype
    {

    private string id;
    

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="id"></param>
    public Prototype (string id)
    {
        this.id = id;
    }

   public string Id
    {
          get { return id; }
    }

    /// <summary>
    ///定义  克隆方法  在 具体原型类中进行克隆
    /// </summary>
    /// <returns></returns>
    public abstract Prototype Clone();
    }



