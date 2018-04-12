using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 外观模式_界面
/// </summary>
public class Facade_main 
{

 
    void Main()
    {
        Facade NewFace = new Facade();
        NewFace.BuyFuction();
        Debug.Log("调用成功");
    }
  


}
