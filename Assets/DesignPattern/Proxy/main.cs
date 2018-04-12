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
        RealSubject thenew = new RealSubject();
        thenew.Request();   ///通过代理模式  将 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
