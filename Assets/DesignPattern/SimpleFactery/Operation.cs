using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///   简单  工厂模式
/// </summary>
public class Operation  {


    /// <summary>
    ///
    /// </summary>
    /// <param name="numberA"></param>
    /// <param name="numberB"></param>
    /// <param name="operate"></param>
 //   /// <returns></returns>
	//public  static  double GetResult(double  numberA, double  numberB, string operate)
 //   {
 //       double result = 0d;

 //       switch ( operate)
 //       {

 //           case "+":
 //               {
 //                   result = numberA + numberB;
 //               }break;
 //           case "-":
 //               {
 //                   result = numberA - numberB;
 //               }break;
 //            case "*":
 //               {
 //                   result = numberA * numberB;
 //               }break;
 //             case "/":
 //               {
 //                   result = numberA / numberB;
 //               }break;
                          
 //           default:
 //               break;
 //       }

 //       return result;

 //   }


    private double _numberA = 0;

    private double _numberB = 0;

    /// <summary>
    /// 设置属性A 
    /// </summary>
    public double NumberA
    {
          get { return _numberA; }
           set { _numberB = value; }
     }



    /// <summary>
    /// 设置属性B
    /// </summary>
    public  double NumberB
    {
        get { return _numberB; }
        set { _numberB = value; }
       
    }
  


  /// <summary>
  ///虚方法  在 子类中进行重写
  /// </summary>
  public virtual   double  GetResult()
    {
        double result = 0;
        return result;
    }
}

/// <summary>
/// 加法雷
/// </summary>
class OperationAdd:Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA + NumberB;
        return result;
    }

}


/// <summary>
/// 减法类
/// </summary>
class OperationSub:Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA - NumberB;
        return result;
    }
}


/// <summary>
///乘法类
/// </summary>
class OperationMul:Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA * NumberB;
        return result;
    }
}

class OperationDiv:Operation
{
    public override double GetResult()
    {
        double result = 0;
        if (NumberB == 0)
            Debug.Log("除数不能为零");
        result = NumberA / NumberB;
        return result;
    }
}

