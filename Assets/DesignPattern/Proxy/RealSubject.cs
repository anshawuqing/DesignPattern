using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 定义 Proxy 类（接口文件类）所代表的真实实体
/// </summary>
    class RealSubject : ProxySubject
{

    public override void Request()
    {
        Debug.Log("实现具体的对象"); 
    } }
