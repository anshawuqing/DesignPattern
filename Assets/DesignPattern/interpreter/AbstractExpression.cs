using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 声明一个抽象的 解释操作，这个接口为 抽象语法树中的 所有节点 所共享
/// </summary>
 abstract class AbstractExpression
{

    /// <summary>
    ///  
    /// </summary>
    /// <param name="context"></param>
    public abstract void Interpret(Context context);

    


}
