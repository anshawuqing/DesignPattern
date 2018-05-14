using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>全局信息 
///  包含解释器之外的一些
/// </summary>
class Context
{
    /// <summary>
    ///  外部的输入信息
    /// </summary>
    private string input;

    /// <summary>
    /// 
    /// </summary>
    public string Input
    {
        get { return input; }
        set { input = value; }
    }

    /// <summary>
    /// 外部输入的信息
    /// </summary>
    private string output;

    /// <summary>
    /// 外部输入的信息
    /// </summary>
    public string Output
    {
        get { return output; }
        set { output = value; }
    }

}
