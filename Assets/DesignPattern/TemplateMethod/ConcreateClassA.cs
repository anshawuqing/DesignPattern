using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ConcreateClassA : AbstractClass
{

    public override void PrimitiveOperation1()
    {
        Debug.Log("方法  A的 实现 ");
    }

    public override void PrimitiveOperation2()
    {
       
        Debug.Log("方法  B的 实现 ");
    }

 
   
}