using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 需要进行适配的类  
/// </summary>
public class Adaptee
{
    /// <summary>
    ///   特殊类的请求
    /// </summary>
     public void  SpecificRequest()
    {
        Debug.Log("特殊请求");
    }


}
