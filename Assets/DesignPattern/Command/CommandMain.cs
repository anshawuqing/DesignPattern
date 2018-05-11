using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class CommandMain
{
    
    void  Main()
    {
        Receiver r = new Receiver();    // 创建一个接收者
        Command c = new ConcreteCommand(r);   //创建一个  执行者
        Invoker i = new Invoker();
        i.SetCommand(c);
        i.ExecuteCommand();

        Debug.Log(""); 
  
    }

}
