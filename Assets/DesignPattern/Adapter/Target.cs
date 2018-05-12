using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
///  客户所用的接口,目标可以是  具体的或 抽象的类，也可以是接口  
/// </summary>
class Target
{
    public virtual void  Request()
    {
        Debug.Log("目标请求");
    }

}
