using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 非终结符表达式，为文法中的 非终结符 实现解释操作。对 文法中的的 
/// 的每一条规则 R1  R2 R3   都需要一个 具体的非终结符表达式类
/// </summary>
class NonterminalExpression : AbstractExpression
{
    public override void Interpret(Context context)
    {
        Debug.Log("非终端解释器"); 
    }
}
