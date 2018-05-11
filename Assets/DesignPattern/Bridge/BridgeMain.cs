using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 桥接 模式的 客户端 
/// </summary>
public class BridgeMain
{
       void  MainView()
    {

        Abstraction ab = new RefinedAbstraction();
        // 确定 要 选择的 实现方式
        ab.SetImplementor(new ConcreteImplementorA());
        /// 确定抽象的实现方式
        ab.Operation();

        
        ab.SetImplementor(new ConcreteImplementorB());
        ab.Operation();

        Debug.Log("更新文件");

    }

}
