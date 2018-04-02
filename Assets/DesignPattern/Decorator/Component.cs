using UnityEngine;
using System.Collections;

/// <summary>
/// 定义对象的接口 ，将对象动态的添加职责
/// </summary>
 abstract  class Component {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


    }

    /// <summary>
    /// 
    /// </summary>
    public abstract void Operation();

   
}
