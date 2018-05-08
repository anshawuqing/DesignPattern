using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 客户端 代码
/// </summary>
public class StateMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void  Main()
    {

        // 设置 Context 的初始状态为 ConcreteStateA 
        Context C = new Context(new ConcreteStateA ());
      
        //不断的更改状态
        C.Request();
        C.Request();
        C.Request();
        C.Request();
    }
}
