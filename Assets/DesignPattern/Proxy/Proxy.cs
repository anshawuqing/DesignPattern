using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 代理模式  为其他对象提供一种代理以控制对这个对象的访问
/// 代理类  为其 保存一个引用使得 代理可以访问实体，
/// 并提供一个与 接口类相同的 接口，这样代理就可以用来替代  实体
/// </summary>
 class Proxy : Subject {


    /// <summary>
    /// 保存新的真实实体，使代理可以访问 实体
    /// </summary>
    RealSubject realsuibject;

    
    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
