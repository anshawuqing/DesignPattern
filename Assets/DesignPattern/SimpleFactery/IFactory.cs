using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    interface  IFactory
    {

    /// <summary>
    ///  定义 一个  接口 ，子类去实现  
    /// </summary>
    /// <returns></returns>
    Operation CreateOperation();

    }

class   AddFactory : IFactory
{
    public Operation CreateOperation()
    {
        return new OperationAdd();
    }
    }
 /// <summary> 
 /// ///减法工厂
/// </summary>
class SubFactory : IFactory
{
    public Operation CreateOperation()
    {
        return new OperationSub(); 
    }
}

/// <summary>
/// 乘法工厂
/// </summary>
class MulFacctory : IFactory
{
    public Operation CreateOperation()
    {
        return new  OperationMul();

    }
}

/// <summary>
/// 除法类工厂
/// </summary>
class DivFactory : IFactory
{
    public Operation CreateOperation()
    {
        return new OperationDiv(); 
    }
}