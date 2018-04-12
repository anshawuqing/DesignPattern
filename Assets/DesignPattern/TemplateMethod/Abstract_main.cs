using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  模板模式的 客户端
/// </summary>
public class Abstract_main
{
     void main()
    {

    AbstractClass abstracct1_view;
    abstracct1_view = new ConcreateClassA();
abstracct1_view .TemplateMethod();

        
         
    AbstractClass abstracct2_view;
        abstracct2_view = new ConcreateClassB();
        abstracct2_view.TemplateMethod();

    }
	
}
