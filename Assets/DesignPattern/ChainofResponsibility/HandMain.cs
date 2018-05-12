using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 职责链 模式 的 客户端代码
/// </summary>
public class HandMain
{
   void  Main()
    {
    Handler h1 = new ConcreteHandler1();
    Handler h2 = new ConcreteHandler2();
    Handler h3 = new ConcreteHandler3();
        h1.SetSuccessor(h2);     //  设置 职责 的上家与下家
        h2.SetSuccessor(h1);

        int[] requests= { 2,4,5,14,22,18,3,27,20};

        foreach ( int request  in requests)
        {
            h1.HendleRequest(request); 
        }

        Debug.Log(" ");
    }
        
 
  
}
