using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// 工厂方法模式
/// </summary>
    class OperationFactory :MonoBehaviour
    {


    public static Operation createOperate(string operate)
    {
        Operation opera = null;

   switch ( operate )
	{
            case "+":
                {
                    opera = new OperationAdd();  
                }break;
             case "-":
                {
                    opera = new OperationSub();  
                }break;
              case "*":
                {
                    opera = new OperationMul();  
                }break;
               case "/":
                {
                    opera = new OperationDiv();  
                }break;
		default:
 break;
	}
        return opera;
    }
     
    

           
    }

