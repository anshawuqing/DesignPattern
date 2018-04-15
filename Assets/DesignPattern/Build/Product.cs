using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Product
{

    IList<string> parts = new List<string>();
 
    
    /// <summary>
    ///  添加产品部件
    /// </summary>
    /// <param name="part"></param>
    public void  Add(string  part)
    {
        parts.Add(part);

    }

    
    /// <summary>
    /// 产品创建
    /// </summary>
    public void Show()
    {
        Debug.Log("产品进行创建");
        foreach (string part in parts)
        {
            //列举所有产品的名称
            Debug.Log("名称" + part);
        }
    }
}
