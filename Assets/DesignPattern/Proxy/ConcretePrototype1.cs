using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



  /// <summary>
  ///具体 原型类,
  /// </summary>
    class ConcretePrototype1 : Prototype
    {
    public ConcretePrototype1  (string id) :base (id)
    {

    }

    public override Prototype Clone()
     {
        ///创建 当前对象的 浅表副本。方法是 创建一个新的对象，然后将当前对象
        ///的非静态 字段复制到 该新对象。 如果字段 是值类型的，则对该字段执行逐位复制
        ///如果字段是引用类型，则复制引用但不复制引用的对象：因此，原始对象及其副本引用同一对象
        return (Prototype)this.MemberwiseClone(); 
    }
}

