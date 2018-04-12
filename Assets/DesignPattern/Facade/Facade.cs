using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour {

    ///

    SubSystermOne subone;
    SubSystermTwo subtwo;
    SubSystermThree subthree;


   ///初始化 
    void Facede ()
    {
        subone = new SubSystermOne();
        subtwo = new SubSystermTwo();
        subthree = new SubSystermThree();
       
    }
  
    /// <summary>
    ///  接口 方法 一
    /// </summary>
    public void  BuyFuction()
    {
        ///
        subone.MethodOne();
        subtwo.MethodTwo();
        subthree.MethodThree();
    }
    
    /// <summary>
    /// 接口方法二
    /// </summary>
    public void  SellFuction()
    {

    }
   
}
