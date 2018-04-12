using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  客户端代码 
/// </summary>
public class main : MonoBehaviour {

    /// <summary>
    ///实例化 代理类
    /// </summary>
   
     ///实例化  代理
     //  用代理类实现相关的功能
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   /// <summary>
   ///工厂模式  客户端实现代码
   /// </summary>
   void Factory_main()
    {
        /// 实现接口
        IFactory OperaFatory = new AddFactory();  // 客户端 根据需要  选择相应的工厂
        Operation opera = OperaFatory.CreateOperation();
        opera.NumberA = 1;
        opera.NumberB = 2;
        double result = opera.GetResult();  // 计算出结果

    }

   
}
